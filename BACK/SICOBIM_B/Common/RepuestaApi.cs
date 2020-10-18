using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Common
{
    public class RepuestaApi <T>
    {
        public bool correcto { get; set; }
        public string Mensaje { get; set; }
        public IEnumerable<T> ObjetoRespuesta { get; set; }


    }
}
