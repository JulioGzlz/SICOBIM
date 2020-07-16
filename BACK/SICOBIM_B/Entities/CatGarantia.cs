using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    public class CatGarantia
    {
        public int id { get; set; }

        public String  añosGarantia { get; set; }
        public String descripcion { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

        public ICollection<TblBienes> tblBienes
        {
            get;
            set;
        }
    }
}
