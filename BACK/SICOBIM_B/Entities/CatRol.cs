﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    public class CatRol
    {
        public int id { get; set; }
        public string rol { get; set; }
        public String descripcion { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int idusuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

    }
}
