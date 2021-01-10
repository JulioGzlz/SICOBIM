using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SICOBIM_B
{
    public partial class CtrlUsuarios
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaMod { get; set; }
        public int IdUsuarioAlta { get; set; }
        public int UsuarioMod { get; set; }
        public int? CatSexoid { get; set; }
        public string Rfc { get; set; }
        public string Cargo { get; set; }
        public int? CatEstatusid { get; set; }
        public int? CatTipoContratoid { get; set; }
        public int? CatTurnoid { get; set; }
        public string Numeroempleado { get; set; }
        public string Plaza { get; set; }
        public int IdTok { get; set; }
        //public int? IdAreaServicioid { get; set; }
        public int? Catareaid { get; set; }
        public int? Catservicioid { get; set; }
        public int? CatRolid { get; set; }

        public virtual CatEstatus CatEstatus { get; set; }
        public virtual CatRol CatRol { get; set; }
        public virtual CatSexo CatSexo { get; set; }
        public virtual CatTipoContrato CatTipoContrato { get; set; }
        public virtual CatTurno CatTurno { get; set; }
        //public virtual TblAreaServicio IdAreaServicio { get; set; }
        public virtual CatArea IdArea { get; set; }
        public virtual CatServicio IdServicio { get; set; }
        [JsonIgnore]
        public virtual List<RefreshToken> RefreshToken { get; set; }
    }
}
