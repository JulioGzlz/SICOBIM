using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("CatUnidadDestino")]
    public class CatUnidadDestino
    {
        public CatUnidadDestino()
        {

            TblSalidasBien = new HashSet<TblSalidasBien>();

        }
        [Key]
        public int CatUnidadDestinoId { get; set; }
        public string destino { get; set; }
        public String descripcion { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int idusuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }


        public virtual ICollection<TblSalidasBien> TblSalidasBien
        {
            get;
            set;
        }
   
    }
}
