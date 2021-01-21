using SICOBIM_B.Entities;
using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatRol : CatalogEntityBase
    {
        public CatRol()
        {
            CtrlUsuarios = new HashSet<CtrlUsuarios>();
        }


        public string Rol { get; set; }


        public virtual ICollection<CtrlUsuarios> CtrlUsuarios { get; set; }
    }
}
