using SICOBIM_B.Entities;
using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatServicio : CatalogEntityBase
    {
        public CatServicio()
        {
            CtrlUsuarios = new HashSet<CtrlUsuarios>();
            TblBienesEquMedico = new HashSet<TblBienesEquMedico>();
            TblBienesMuebles = new HashSet<TblBienesMuebles>();
            TblBienesSistemas = new HashSet<TblBienesSistemas>();
            TblInstrumentalMedico = new HashSet<TblInstrumentalMedico>();
            TblResguardatarios = new HashSet<TblResguardatarios>();
        }


        public string Servicio { get; set; }

        public virtual ICollection<CtrlUsuarios> CtrlUsuarios { get; set; }
        public virtual ICollection<TblBienesEquMedico> TblBienesEquMedico { get; set; }
        public virtual ICollection<TblBienesMuebles> TblBienesMuebles { get; set; }
        public virtual ICollection<TblBienesSistemas> TblBienesSistemas { get; set; }
        public virtual ICollection<TblInstrumentalMedico> TblInstrumentalMedico { get; set; }
        public virtual ICollection<TblResguardatarios> TblResguardatarios { get; set; }
    }
}
