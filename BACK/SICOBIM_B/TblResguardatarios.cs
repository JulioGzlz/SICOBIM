using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class TblResguardatarios
    {
        public TblResguardatarios()
        {
            TblBienesEquMedico = new HashSet<TblBienesEquMedico>();
            TblBienesMuebles = new HashSet<TblBienesMuebles>();
            TblBienesSistemas = new HashSet<TblBienesSistemas>();
            TblInstrumentalMedico = new HashSet<TblInstrumentalMedico>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoUno { get; set; }
        public string ApellidoDos { get; set; }
        public int? CatServicioid { get; set; }
        public int? CatTurnoid { get; set; }
        public int? CatEstatusid { get; set; }
        public int? CatTipoContratoid { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public int UsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }
        public string Rfc { get; set; }
        public int? TblAreaServicioid { get; set; }
        public string Cargo { get; set; }
        public int? CatSexoid { get; set; }
        public string Numeroempleado { get; set; }
        public string Plaza { get; set; }

        public virtual CatEstatus CatEstatus { get; set; }
        public virtual CatServicio CatServicio { get; set; }
        public virtual CatSexo CatSexo { get; set; }
        public virtual CatTipoContrato CatTipoContrato { get; set; }
        public virtual CatTurno CatTurno { get; set; }
        public virtual TblAreaServicio TblAreaServicio { get; set; }
        public virtual ICollection<TblBienesEquMedico> TblBienesEquMedico { get; set; }
        public virtual ICollection<TblBienesMuebles> TblBienesMuebles { get; set; }
        public virtual ICollection<TblBienesSistemas> TblBienesSistemas { get; set; }
        public virtual ICollection<TblInstrumentalMedico> TblInstrumentalMedico { get; set; }
    }
}
