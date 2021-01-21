﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblProveedor")]
    public class TblProveedor
    {
        [Key]
        public int TblProveedorId { get; set; }
        public string proveedor { get; set; }
        public int CatTipoDeBienId { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }
       
        public virtual ICollection<TblBienesEquMedico> tblBienesEquMedico
        {
            get;
            set;
        }
        public virtual ICollection<TblBienes> tblBienes
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
