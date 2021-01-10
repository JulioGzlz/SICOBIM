using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("CatTipoSalida")]
    public class CatTipoSalida
    {
        public CatTipoSalida()
        {

            TblSalidasBien = new HashSet<TblSalidasBien>();

        }
        [Key]
        public int CatTipoSalidaId { get; set; }

        public string tiposalida { get; set; }
        public string descripcion { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

        public virtual ICollection<TblSalidasBien> TblSalidasBien
        {
            get;
            set;
        }

    }
}
