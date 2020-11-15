using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    public class TblSalidaBienMobiliario
    {
        [Key]
        public int TblSalidaBienMobiliarioId { get; set; }
        public int TblBienesId { get; set; }

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
