using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblBienes")]
    public class TblBienes
    {
        public int id { get; set; }
        //FK
        public int numeroInventario { get; set; }
        public string descripcion { get; set; }
        //FK
        public string marca { get; set; }
        //FK
        public string modelo { get; set; }
        public string serie { get; set; }
        //FK
        public int idFactura { get; set; }
        public string claveCambs { get; set; }
        public string claveSaica { get; set; }
        public double IVA { get; set; }
        public double costoTotal { get; set; }
        //FK
        public int idServicio { get; set; }      
        public cat_horario cat_Horario
        {
            get;
            set;
        }
        public int idResguardatario { get; set; }
        public TblResguardatarios tblResguardatarios
        {
            get;
            set;
        }
        //FK
        public int idTipoBien { get; set; }
        public CatTipoDeBienes catTipoDeBienes
        {
            get;
            set;
        }
        //FK
        public int idEstadoFisico { get; set; }
        public CatEstadoDelBien catEstadoDelBien
        {
            get;
            set;
        }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

    }
}
