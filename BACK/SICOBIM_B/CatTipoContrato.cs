using SICOBIM_B.Entities;
using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatTipoContrato : CatalogEntityBase
    {
        public CatTipoContrato()
        {
            CtrlUsuarios = new HashSet<CtrlUsuarios>();
            TblResguardatarios = new HashSet<TblResguardatarios>();
        }


        public string Contrato { get; set; }


        public virtual ICollection<CtrlUsuarios> CtrlUsuarios { get; set; }
        public virtual ICollection<TblResguardatarios> TblResguardatarios { get; set; }
    }
}
