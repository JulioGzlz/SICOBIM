using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("CtrlUsuarios")]

    public class User
    {

        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string correo { get; set; }

        public int idSexo { get; set; }
        public CatSexo catSexo
        {
            set;
            get;
        }

        //public string Password { get; set; }
        //public string Role { get; set; }
        //public string Token { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        //Foreign_key cat_horario

        //one-to-many  (uno a muchos)
        public int idServicio { get; set; }
        public CatServicio CatServicio
        {
            set;
            get;
        }
        //one-to-many  (uno a muchos)
        public int idRol { get; set; }
        public CatRol catRol
        {
            set;
            get;
        }
        public int idTipoBien { get; set; }
        public CatTipoDeBienes CatTipoDeBienes
        {
            set;
            get;
        }      
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }
        // [JsonIgnore]
        // public string Password { get; set; }

        [JsonIgnore]
        public List<RefreshToken> RefreshTokens { get; set; }


    }
}
