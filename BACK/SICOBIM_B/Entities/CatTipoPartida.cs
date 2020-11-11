using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("CatTipoPartida")]
    public class CatTipoPartida
    {
        [Key]
        public int CatTipoPartidaId { get; set; }
        public string partidapresupestual { get; set; }
        public String descripcion { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }
        public virtual ICollection<TblBienes> tblBienes
        {
            get;
            set;
        }
        public virtual ICollection<TblBienesEquMedico> tblBienesEquMedico
        {
            get;
            set;
        }
        public virtual ICollection<TblBienesSistemas> tblBienesSistemas
        {
            get;
            set;
        }
        public virtual ICollection<TblInstrumentalMedico> tblInstrumentalMedico
        {
            get;
            set;
        }

    }

}
