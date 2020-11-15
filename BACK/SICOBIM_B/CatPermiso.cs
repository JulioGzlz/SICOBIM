using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatPermiso
    {
        public int Id { get; set; }
        public string Permiso { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public int UsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }
    }
}
