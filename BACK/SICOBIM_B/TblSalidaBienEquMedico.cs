using System;
using System.Collections.Generic;


namespace SICOBIM_B
{
    public partial class TblSalidaBienEquMedico
    {
       
        public int TblSalidaBienEquMedicoId { get; set; }

        public int TblBienesEquMedicoId { get; set; }

        public int CatTipoSalidaId { get; set; }

        public int CatUnidadDestinoId { get; set; }
        public int CatTipoDeBienId { get; set; }

        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

        public virtual TblBienesEquMedico TblBienesEquMedico { get; set; }


    }
}
