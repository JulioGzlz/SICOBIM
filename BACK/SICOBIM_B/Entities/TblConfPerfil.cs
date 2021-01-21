using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblConfPerfil")]
    public class TblConfPerfil
    {

        public CatPermiso IdPermiso
        {
            get;
            set;
        }
        public CatRol IdRol
        {
            get;
            set;
        }
        public bool activo { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }



    }
}

