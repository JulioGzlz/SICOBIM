using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblSalidaBien")]
    public class TblSalidaBienEquMedico
    {
        [Key]
        public int TblSalidaBienEquMedicoId { get; set; }

        public int TblBienesEquMedicoId { get; set; }

        public int CatTipoSalidaId { get; set; }

        public int CatUnidadDestinoId { get; set; }
        public int CatTipoDeBienId { get; set; }

        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

      
    }
}
