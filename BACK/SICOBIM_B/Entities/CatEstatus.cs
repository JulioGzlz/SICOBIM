﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    public class CatEstatus
    {
        public int id { get; set; }
        public string estatus { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }


        public ICollection<TblResguardatarios> tblResguardatarios
        {
            get;
            set;
        }
    }
}