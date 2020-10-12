﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("CatEstatus")]
    public class CatEstatus
    {
        public int id { get; set; }
        public string estatus { get; set; }
        public String descripcion { get; set; }
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
        public ICollection<User> users
        {
            get;
            set;
        }
    }
}
