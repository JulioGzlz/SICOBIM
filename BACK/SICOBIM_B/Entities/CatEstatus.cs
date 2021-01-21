using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("CatEstatus")]
    public class CatEstatus
    {
        [Key]
        public int CatEstatusId { get; set; }
        public string estatus { get; set; }
        public string descripcion { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }


        public virtual ICollection<TblResguardatarios> tblResguardatarios
        {
            get;
            set;
        }
        public virtual ICollection<User> users
        {
            get;
            set;
        }
    }
}
