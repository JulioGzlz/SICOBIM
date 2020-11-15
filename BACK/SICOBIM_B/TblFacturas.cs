using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class TblFacturas
    {
        public TblFacturas()
        {
            TblBienesEquMedico = new HashSet<TblBienesEquMedico>();
            TblBienesMuebles = new HashSet<TblBienesMuebles>();
            TblBienesSistemas = new HashSet<TblBienesSistemas>();
            TblInstrumentalMedico = new HashSet<TblInstrumentalMedico>();
        }

        public int IdUsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public int UsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }
        public double Iva { get; set; }
        public double CostoTotal { get; set; }
        public double Subtotal { get; set; }
        public int CatTipoDeBienId { get; set; }
        public string Factura { get; set; }
        //public int TblBienesEquMedicoId { get; set; }
        public int IdFactura { get; set; }

        public virtual CatTipoDeBien CatTipoDeBien { get; set; }
        public virtual ICollection<TblBienesEquMedico> TblBienesEquMedico { get; set; }
        public virtual ICollection<TblBienesMuebles> TblBienesMuebles { get; set; }
        public virtual ICollection<TblBienesSistemas> TblBienesSistemas { get; set; }
        public virtual ICollection<TblInstrumentalMedico> TblInstrumentalMedico { get; set; }
    }
}
