using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatTipoSalida
    {
        public CatTipoSalida()
        {
            TblSalidasBien = new HashSet<TblSalidasBien>();
        }

        public int Id { get; set; }
        public string Tiposalida { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public int UsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<TblSalidasBien> TblSalidasBien { get; set; }
    }
}
