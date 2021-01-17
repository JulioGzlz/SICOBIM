﻿using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatRol
    {
        public CatRol()
        {
            CtrlUsuarios = new HashSet<CtrlUsuarios>();
        }

        public int Id { get; set; }
        public string Rol { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public int IdusuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<CtrlUsuarios> CtrlUsuarios { get; set; }
    }
}