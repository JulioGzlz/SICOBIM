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
        public int numerofederalizacion { get; set; } 
        public int numeroInventario { get; set; }
        public TblInventarios tblInventarios
        {
            get;
            set;
        }
      

        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        public  int cantidad { get; set; }
        public string contrato { get; set; }//duda normalizar 
        public string proveedor { get; set; }
        //FK
        public int idFactura { get; set; }//duda
        public TblFacturas tblFacturas
        {
            get;
            set;
        }
        public int idAñosGarantia { get; set; }
        public CatGarantia catGarantia
        {
            get;
            set;
        }
        public int idtipopartida { get; set; }
        public CatTipoPartida catTipoPartida
        {
            get;
            set;
        }
        public string claveCambs { get; set; }
        public string claveSaica { get; set; }
        public double IVA { get; set; }
        public double subtotal { get; set; }
        public double costoTotal { get; set; }
        public int identrada { get; set; }
        public CatTipoEntrada catTipoEntrada
        {
            get;
            set;
        }
        public int idunidaddestino { get; set; }
        public CatUnidadDestino catUnidadDestino
        {
            get;
            set;
        }


        public int idServicio { get; set; }
        public TblAreaServicio tblAreaServicio
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
        public CatTipoDeBien catTipoDeBienes
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

        public String observaciones { get; set; }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

        public ICollection<TblSalidaBien> tblSalidaBien
        {
            get;
            set;
        }

    }
}

