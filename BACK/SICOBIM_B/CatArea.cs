using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatArea
    {
        public CatArea()
        {
            CtrlUsuarios = new HashSet<CtrlUsuarios>();
            TblBienesEquMedico = new HashSet<TblBienesEquMedico>();
            TblBienesMuebles = new HashSet<TblBienesMuebles>();
            TblBienesSistemas = new HashSet<TblBienesSistemas>();
            TblInstrumentalMedico = new HashSet<TblInstrumentalMedico>();
            TblResguardatarios = new HashSet<TblResguardatarios>();
        }

        public int Id { get; set; }
        public string Area { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public int IdusuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<CtrlUsuarios> CtrlUsuarios { get; set; }
        public virtual ICollection<TblBienesEquMedico> TblBienesEquMedico { get; set; }
        public virtual ICollection<TblBienesMuebles> TblBienesMuebles { get; set; }
        public virtual ICollection<TblBienesSistemas> TblBienesSistemas { get; set; }
        public virtual ICollection<TblInstrumentalMedico> TblInstrumentalMedico { get; set; }
        public virtual ICollection<TblResguardatarios> TblResguardatarios { get; set; }
    }
}
