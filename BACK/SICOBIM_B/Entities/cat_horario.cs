using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    public class cat_horario
    {
        public int id { get; set; }
        public string horario { get; set; }
        public int usuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }


        public ICollection<User> users
        {
            get;
            set;
        }
    }
}
