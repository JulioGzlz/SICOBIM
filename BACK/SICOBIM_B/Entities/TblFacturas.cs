using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblFacturas")]
    public class TblFacturas

    ///una factura puede tener varios bienes
    //por factura/tipo de bien/piso/clave cabms/clave saica/por contrato/
    {
        [Key]
        public int TblFacturasId { get; set; }
        public string factura { get; set; }
        public int costounitario { get; set; }
        public double IVA { get; set; }
        public double subtotal { get; set; }
        public double costoTotal { get; set; }
        public int CatTipoDeBienId { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

        //    public TblBienesEquMedico tblBienesEquMedico { get; set; } ///1|
        //    public TblBienes TblBienes { get; set; }//2
        //    public TblBienesSistemas tblBienesSistemas { get; set; }//3
        public virtual ICollection<TblBienesSistemas> tblBienesSistemas
        {
            get;
            set;
        }
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


        public virtual ICollection<TblInstrumentalMedico> tblInstrumentalMedico
        {
            get;
            set;
        }
    }
}
