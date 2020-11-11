using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("CatTipoDeBien")]
    public class CatTipoDeBien
    {
        [Key]
        public int CatTipoDeBienId { get; set; }
        public string TipodeBien { get; set; }
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
        public virtual ICollection<TblFacturas> tblFacturas
        {
            get;
            set;
        }
        public virtual ICollection<TblClaveSaica> tblClaveSaica
        {
            get;
            set;
        }
        public virtual ICollection<TblContratoBien> tblContratoBien
        {
            get;
            set;
        }
        public virtual ICollection<TblFederalizacion> tblFederalizacion
        {
            get;
            set;
        }
        public virtual ICollection<TblInventarios> tblInventarios
        {
            get;
            set;
        }
        public virtual ICollection<TblProveedor> tblProveedor
        {
            get;
            set;
        }
        public virtual ICollection<TblClaveCabms> tblClaveCabms
        {
            get;
            set;
        }
    }
}
