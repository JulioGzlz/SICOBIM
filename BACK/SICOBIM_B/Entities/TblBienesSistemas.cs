using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblBienesSistemas")]
    public class TblBienesSistemas
    {
        public TblBienesSistemas()
        {

            TblSalidasBien = new HashSet<TblSalidasBien>();

        }
        [Key]
        public int TblBienesSistemasId { get; set; }

        public int TblFederalizacionId { get; set; }

        public int TblInventariosId { get; set; }
        public string descripcion { get; set; }

        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        public int cantidad { get; set; }

        public int TblContratoBienId { get; set; }
        public int TblProveedorId { get; set; }

        public int TblFacturasId { get; set; }

        public int CatGarantiaId { get; set; }

        public int CatTipoPartidaId { get; set; }
        public int TblClaveCabmsId { get; set; }

        public int TblClaveSaicaId { get; set; }


        public int CatTipoEntradaId { get; set; }


        public int TblAreaServicioId { get; set; }
        public int CatPisosId { get; set; }

        public int TblResguardatariosId { get; set; }
        //FK
        public int CatTipoDeBienId { get; set; }


        public int CatEstadoDelBienId { get; set; }

        public string observaciones { get; set; }

        //falta por relasionar 
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
