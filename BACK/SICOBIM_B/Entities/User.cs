using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
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
        public string cargo { get; set; }
        public int idSexo { get; set; }
        public CatSexo catSexo
        {
            set;
            get;
        }
        public int idturno { get; set; }
        public CatTurno catTurno
        {
            set;
            get;
        }
        public int idtipocontrato { get; set; }
        public CatTipoContrato catTipoContrato
        {
            set;
            get;
        }

        public int idServicio { get; set; }
        public TblAreaServicio tblAreaServicio
        {
            set;
            get;
        }
        public int idrol { get; set; }
        public CatRol CatRol
        {
            set;
            get;
        }
        public int idestatus { get; set; }
        public CatEstatus catEstatus
        {
            set;
            get;
        }

        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

       
      

    }
}
