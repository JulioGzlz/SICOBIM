using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblFacturas")]
    public class TblFacturas


        //por factura/tipo de bien/piso/clave cabms/clave saica/por contrato/
    {
        public int id { get; set; }
        public string factura { get; set; }
        public double IVA { get; set; }
        public double subtotal { get; set; }
        public double costoTotal { get; set; }
        public TblBienesSistemas IdBienesSistema
        {
            get;
            set;
        }
        public TblBienesEquMedico IdBienesEquMedico
        {
            get;
            set;
        }
        public TblBienes IdBienesMuebles
        {
            get;
            set;
        }
        public TblInstrumentalMedico InstrumentalMedico
        {
            get;
            set;
        }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }
        public ICollection<TblBienes> tblBienes
        {
            get;
            set;
        }
        public ICollection<TblBienesEquMedico> tblBienesEquMedico
        {
            get;
            set;
        }
        public ICollection<TblBienesSistemas> tblBienesSistemas
        {
            get;
            set;
        }
        public ICollection<TblInstrumentalMedico> tblInstrumentalMedico
        {
            get;
            set;
        }
    }
}
