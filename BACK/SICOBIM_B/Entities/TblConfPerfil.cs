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
        [ForeignKey("idRol")]
        public virtual CatRol CatRol { get; set; }

        [ForeignKey("idPermiso")]
        public bool activo { get; set; }
        public virtual CatPermiso CatPermiso { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }



    }
}

