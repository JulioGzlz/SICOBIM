using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SICOBIM_B
{

    public partial class TblSalidas
    {
        public int Id { get; set; }
        public int? CatTipoSalidaid { get; set; }
        public int? CatUnidadDestinoid { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public int UsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }
      
        public int? CatTipoDeBienId { get; set; }
        public int IdBien { get; set; }

        public virtual CatTipoDeBien CatTipoDeBien { get; set; }
        public virtual CatTipoSalida CatTipoSalida { get; set; }
        public virtual CatUnidadDestino CatUnidadDestino { get; set; }


        //public virtual TblBienesMuebles Idbienes { get; set; }
        //public virtual TblBienesEquMedico TblBienesEquMedico { get; set; }
        //public virtual TblBienesSistemas TblBienesSistemas { get; set; }
        //public virtual TblInstrumentalMedico TblInstrumentalMedico { get; set; }
    }
}
