using SICOBIM_B.Entities;
using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatTurno : CatalogEntityBase
    {
        public CatTurno()
        {
            CtrlUsuarios = new HashSet<CtrlUsuarios>();
            TblResguardatarios = new HashSet<TblResguardatarios>();
        }

        public string Turno { get; set; }


        public virtual ICollection<CtrlUsuarios> CtrlUsuarios { get; set; }
        public virtual ICollection<TblResguardatarios> TblResguardatarios { get; set; }
    }
}
