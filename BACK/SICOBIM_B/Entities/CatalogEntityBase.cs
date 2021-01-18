using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    public class CatalogEntityBase: EntityBase
    {

        [Display(Name = "Descripción")]
        [MaxLength(100)]
        [Required]
        public string Descripcion { get; set; }

        [Display(Name = "Activo")]
        [Required]
        public bool Activo { get; set; }


    }
}
