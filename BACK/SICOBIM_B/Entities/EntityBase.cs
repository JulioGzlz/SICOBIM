using SICOBIM_B.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    public class EntityBase : IEntityBase

    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Activo")]
        [Required]
        [IgnoreDataMember]
        public bool Activo { get; set; }

        [Display(Name = "Fecha de inserción")]
        [DataType(DataType.DateTime)]
        [Required]
        [IgnoreDataMember]
        public DateTime FechaAlta { get; set; }

        [Display(Name = "Usuario de inserción")]
        [Required]
        [IgnoreDataMember]
        public int IdUsuarioAlta { get; set; }

        [Display(Name = "Fecha de actualización")]
        [DataType(DataType.DateTime)]
        [IgnoreDataMember]
        public DateTime? FechaMod { get; set; }

        [Display(Name = "Usuario de actualización")]
        [IgnoreDataMember]
        public int? UsuarioMod { get; set; }





    }
}
