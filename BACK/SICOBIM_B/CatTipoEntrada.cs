﻿using SICOBIM_B.Entities;
using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatTipoEntrada : CatalogEntityBase
    {
        public CatTipoEntrada()
        {
            TblBienesEquMedico = new HashSet<TblBienesEquMedico>();
            TblBienesMuebles = new HashSet<TblBienesMuebles>();
            TblBienesSistemas = new HashSet<TblBienesSistemas>();
            TblInstrumentalMedico = new HashSet<TblInstrumentalMedico>();
        }


        public string Tipoentrada { get; set; }


        public virtual ICollection<TblBienesEquMedico> TblBienesEquMedico { get; set; }
        public virtual ICollection<TblBienesMuebles> TblBienesMuebles { get; set; }
        public virtual ICollection<TblBienesSistemas> TblBienesSistemas { get; set; }
        public virtual ICollection<TblInstrumentalMedico> TblInstrumentalMedico { get; set; }
    }
}
