using SICOBIM_B.Entities;
using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatTipoSalida : CatalogEntityBase
    {
        public CatTipoSalida()
        {
            TblSalidasBien = new HashSet<TblSalidasBien>();
        }


        public string Tiposalida { get; set; }


        public virtual ICollection<TblSalidasBien> TblSalidasBien { get; set; }
    }
}
