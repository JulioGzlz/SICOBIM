using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("CatArea")]

    public class CatArea : CatalogEntityBase
    {
        public String descripcion { get; set; }
    
        public virtual ICollection<TblAreaServicio> tblAreaServicios
        {
            get;
            set;
        }

    }
}
