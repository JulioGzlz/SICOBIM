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
        [Key]
        public int CatTipoSalidaId { get; set; }

        public string tiposalida { get; set; }
        public string descripcion { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

        public virtual ICollection<TblSalidaBienEquMedico> tblSalidaBienEquMedico
        {
            get;
            set;
        }
        public virtual ICollection<TblSalidaBienInstrumentalMedico> TblSalidaBienInstrumentalMedico
        {
            get;
            set;
        }
        public virtual ICollection<TblSalidaBienMobiliario> TblSalidaBienMobiliario
        {
            get;
            set;
        }
        public virtual ICollection<TblSalidaBienSistemas> TblSalidaBienSistema
        {
            get;
            set;
        }
    }
}
