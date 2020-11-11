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
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string RFC { get; set; }
        public string plaza { get; set; }
        public string numeroempleado { get; set; }

        public int CatSexoId { get; set; }

        public int CatEstatusId { get; set; }

        public int CatTipoContratoId { get; set; }

        public int TblAreaServicioId { get; set; }

        public CatRol catRol
        {
            get;
            set;
        }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

       
      
        // [JsonIgnore]
        // public string Password { get; set; }

        public int idTok { get; set; }
        [JsonIgnore]
        public List<RefreshToken> RefreshTokens { get; set; }


    }
}
