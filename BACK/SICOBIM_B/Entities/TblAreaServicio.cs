using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    public class TblAreaServicio
    {
        public int id { get; set; }

        public int idarea { get; set; }
        public CatArea catarea
        {
            get;
            set;
        }
        public int idservicio { get; set; }
        public CatServicio catservicio

        {
            get;
            set;
        }
        public String localizacion { get; set; }
        public String descripcion { get; set; }

        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

        public ICollection<TblResguardatarios> tblResguardatarios
        {
            get;
            set;
        }
        public ICollection<TblBienes>  tblBienes
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
