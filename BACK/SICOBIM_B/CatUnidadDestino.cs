using SICOBIM_B.Entities;
using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatUnidadDestino : CatalogEntityBase
    {
        public CatUnidadDestino()
        {
            TblSalidasBien = new HashSet<TblSalidasBien>();
        }

        public string Destino { get; set; }


        public virtual ICollection<TblSalidasBien> TblSalidasBien { get; set; }
    }
}
