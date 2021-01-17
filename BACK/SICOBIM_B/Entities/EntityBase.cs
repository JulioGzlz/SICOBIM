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
        public long Id { get; set; }

        [Display(Name = "Visible")]
        [Required]
        [IgnoreDataMember]
        public bool Visible { get; set; }

        [Display(Name = "Fecha de inserción")]
        [DataType(DataType.DateTime)]
        [Required]
        [IgnoreDataMember]
        public DateTime InsertDate { get; set; }

        [Display(Name = "Usuario de inserción")]
        [Required]
        [IgnoreDataMember]
        public int InsertUserId { get; set; }

        [Display(Name = "Fecha de actualización")]
        [DataType(DataType.DateTime)]
        [IgnoreDataMember]
        public DateTime? UpdateDate { get; set; }

        [Display(Name = "Usuario de actualización")]
        [IgnoreDataMember]
        public int? UpdateUserId { get; set; }

        [NotMapped]
        [IgnoreDataMember]
        public bool IsNew
        {
            get
            {
                return Id.Equals(0);
            }
        }



    }
}
