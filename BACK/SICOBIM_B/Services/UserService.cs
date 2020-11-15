using LinqToDB;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;


using SICOBIM_B.Entities;
using SICOBIM_B.Helpers;
using SICOBIM_B.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SICOBIM_B.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        IEnumerable<CtrlUsuarios> getAll();
        CtrlUsuarios GetById(int id);
        CtrlUsuarios Create(CtrlUsuarios user, string password);



    }
    public class UserService: IUserService
    {

        private sicobimContext _context;
        private readonly AppSettings _appSettings;
        public UserService(sicobimContext context, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }

        public  AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress)
        {
            CtrlUsuarios objUser = new CtrlUsuarios();
            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password))
                return null;
           
            objUser.Username = model.Username;

            var user = _context.CtrlUsuarios.SingleOrDefault(x => x.Username == model.Username);

            // return null if user not found
            if (user == null) return null;
            if (!VerifyPasswordHash(model.Password, user.PasswordHash, user.PasswordSalt)) 
            return null;

            // authentication successful so generate jwt and refresh tokens
            var jwtToken = generateJwtToken(user);
            var refreshToken = generateRefreshToken(ipAddress);

            // save refresh token
            // save refresh token
            user.RefreshToken.Add(refreshToken);
            _context.Update(user);
            _context.SaveChanges();

               return new AuthenticateResponse(user, jwtToken, refreshToken.Token);

        }

        private RefreshToken generateRefreshToken(string ipAddress)
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())

            {
                var randomBytes = new byte[64];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                return new RefreshToken
                {
                    Token = Convert.ToBase64String(randomBytes),
                    Expires = DateTime.UtcNow.AddMinutes(2),
                    Created = DateTime.UtcNow,
                    CreatedByIp = ipAddress
                };

            }
        }

        private string generateJwtToken(CtrlUsuarios user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private bool VerifyPasswordHash(string password, byte [] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }

        public IEnumerable<CtrlUsuarios> GetAll()
        {
            return _context.CtrlUsuarios;
        }

        public CtrlUsuarios GetById(int id)
        {
            return _context.CtrlUsuarios.Find(id);
        }
        public CtrlUsuarios Create(CtrlUsuarios user, string password)
        {
            // validation
            if (string.IsNullOrWhiteSpace(password))
                throw new AppException("Password is required");

            if (_context.CtrlUsuarios.Any(x => x.Username == user.Username))
                throw new AppException("Username \"" + user.Username + "\" is already taken");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);
            ByteArrayToString(passwordHash);


            DateTime fechaActual = DateTime.Now;
            user.IdUsuarioAlta = 1;
            user.Activo = true;
            user.FechaAlta = fechaActual;




            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _context.CtrlUsuarios.Add(user);
            _context.SaveChanges();

            return user;
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public static string  ByteArrayToString ( byte [] ba )
        {
           return BitConverter.ToString(ba).Replace("-","");
        }



        public AuthenticateResponse RefreshToken(string token, string ipAddress)
        {
            var user = _context.CtrlUsuarios.SingleOrDefault(u => u.RefreshToken.Any(t => t.Token == token));

            // return null if no user found with token
            if (user == null) return null;

            var refreshToken = user.RefreshToken.Single(x => x.Token == token);

            // return null if token is no longer active
            if (!refreshToken.IsActive) return null;

            // replace old refresh token with a new one and save
            var newRefreshToken = generateRefreshToken(ipAddress);
            refreshToken.Revoked = DateTime.UtcNow;
            refreshToken.RevokedByIp = ipAddress;
            refreshToken.ReplacedByToken = newRefreshToken.Token;
            user.RefreshToken.Add(newRefreshToken);
            _context.Update(user);
            _context.SaveChanges();

            // generate new jwt
            var jwtToken = generateJwtToken(user);

            return new AuthenticateResponse(user, jwtToken, newRefreshToken.Token);
        }

        public bool RevokeToken(string token, string ipAddress)
        { 
            var user = _context.CtrlUsuarios.SingleOrDefault(u => u.RefreshToken.Any(t => t.Token == token));

            // return false if no user found with token
            if (user == null) return false;

            var refreshToken = user.RefreshToken.Single(x => x.Token == token);

            // return false if token is not active
            if (!refreshToken.IsActive) return false;

            // revoke token and save
            refreshToken.Revoked = DateTime.UtcNow;
            refreshToken.RevokedByIp = ipAddress;
            _context.Update(user);
            _context.SaveChanges();

            return true;
        }

        public IEnumerable<CtrlUsuarios> getAll()
        {
            return _context.CtrlUsuarios;
        }
    }
}
