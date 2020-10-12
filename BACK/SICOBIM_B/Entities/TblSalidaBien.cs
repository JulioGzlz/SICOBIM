using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblSalidaBien")]
    public class TblSalidaBien
    {
        public int id { get; set; }
        public int idbien { get; set; }
        public TblBienes tblbienes
        {
            set;
            get;
        }


        public int idtiposalida { get; set; }
        public CatTipoSalida catTipoSalida
        {
            set;
            get;
        }
        public int idunidaddestino { get; set; }
        public CatUnidadDestino catUnidadDestino
        {
            set;
            get;
        }



        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

      
    }
}
