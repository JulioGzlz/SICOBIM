using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    public class TblConfPerfil
    {
        public int id { get; set; }
        public int idpermiso { get; set; }
        public CatPermiso catPermiso
        {
            set;
            get;
        }
        
        public int idrol { get; set; }
        public CatRol catRol
        {
            set;
            get;
        }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }
    }
}
