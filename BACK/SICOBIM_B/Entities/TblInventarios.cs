﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblInventarios")]
    public class TblInventarios
    {
        public int id { get; set; }
        public string NumeroInventario { get; set; }

        public string Descripcion { get; set; }

        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }
    }
}