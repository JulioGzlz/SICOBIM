using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatTipoDeBien
    {
        public CatTipoDeBien()
        {
            TblBienesEquMedico = new HashSet<TblBienesEquMedico>();
            TblBienesMuebles = new HashSet<TblBienesMuebles>();
            TblBienesSistemas = new HashSet<TblBienesSistemas>();
            TblClaveCambs = new HashSet<TblClaveCabms>();
            TblClaveSaica = new HashSet<TblClaveSaica>();
            TblContratoBien = new HashSet<TblContratoBien>();
            TblFacturas = new HashSet<TblFacturas>();
            TblFederalizacion = new HashSet<TblFederalizacion>();
            TblInstrumentalMedico = new HashSet<TblInstrumentalMedico>();
            TblInventarios = new HashSet<TblInventarios>();
            TblProveedor = new HashSet<TblProveedor>();
            TblSalidasBien = new HashSet<TblSalidasBien>();
        }

        public string TipodeBien { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public int UsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }
        public string Descripcion { get; set; }
        public int CatTipoDeBienId { get; set; }

        public virtual ICollection<TblBienesEquMedico> TblBienesEquMedico { get; set; }
        public virtual ICollection<TblBienesMuebles> TblBienesMuebles { get; set; }
        public virtual ICollection<TblBienesSistemas> TblBienesSistemas { get; set; }
        public virtual ICollection<TblClaveCabms> TblClaveCambs { get; set; }
        public virtual ICollection<TblClaveSaica> TblClaveSaica { get; set; }
        public virtual ICollection<TblContratoBien> TblContratoBien { get; set; }
        public virtual ICollection<TblFacturas> TblFacturas { get; set; }
        public virtual ICollection<TblFederalizacion> TblFederalizacion { get; set; }
        public virtual ICollection<TblInstrumentalMedico> TblInstrumentalMedico { get; set; }
        public virtual ICollection<TblInventarios> TblInventarios { get; set; }
        public virtual ICollection<TblProveedor> TblProveedor { get; set; }
        public virtual ICollection<TblSalidasBien> TblSalidasBien { get; set; }
    }
}
