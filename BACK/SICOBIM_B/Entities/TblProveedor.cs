using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblProveedor")]
    public class TblProveedor
    {
        public int id { get; set; }
        public string proveedor { get; set; }
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
