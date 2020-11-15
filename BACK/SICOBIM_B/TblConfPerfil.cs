using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class TblConfPerfil
    {
        public DateTime FechaAlta { get; set; }
        public int UsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }
        public int IdUsuarioAlta { get; set; }
        public int? IdPermisoid { get; set; }
        public int? IdRolid { get; set; }

        public virtual CatPermiso IdPermiso { get; set; }
        public virtual CatRol IdRol { get; set; }
    }
}
