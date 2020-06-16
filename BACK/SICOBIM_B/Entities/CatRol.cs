using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    public class CatRol
    {
        public int id { get; set; }
        public string rol { get; set; }
        public bool activo { get; set; }
        public DateTime fechaAlta { get; set; }
        public int UsuarioAlta { get; set; }

    }
}
