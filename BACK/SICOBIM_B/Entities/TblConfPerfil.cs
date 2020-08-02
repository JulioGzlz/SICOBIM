using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblConfPerfil")]
    public class TblConfPerfil
    {

        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }
        [NotMapped]
        [ForeignKey("idRol")]
        public virtual CatRol CatRol { get; set; }

        [ForeignKey("idPermiso")]
        public virtual CatPermiso CatPermiso { get; set; }
    }
}

