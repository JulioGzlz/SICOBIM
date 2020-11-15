using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatTurno
    {
        public CatTurno()
        {
            CtrlUsuarios = new HashSet<CtrlUsuarios>();
            TblResguardatarios = new HashSet<TblResguardatarios>();
        }

        public int Id { get; set; }
        public string Turno { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public int UsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CtrlUsuarios> CtrlUsuarios { get; set; }
        public virtual ICollection<TblResguardatarios> TblResguardatarios { get; set; }
    }
}
