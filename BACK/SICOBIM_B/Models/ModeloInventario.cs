using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Models
{
    public class ModeloInventario
    {
        public int catTipoBien { get; set; }

        public string descripcion { get; set; }
        public int MyProperty { get; set; }

        public int id { get; set; }


        public int idFederalizacion { get; set; }

        public int IdInventario { get; set; }




        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        /// <summary>
        /// es la cantidad fisica de bienes   1 bien = n pzs
        /// </summary>
        public int cantidad { get; set; }

        public int IdContratoBien { get; set; }


        public int IdProveedor { get; set; }

        public string factura { get; set; }


        public double subtotal { get; set; }
        public double iva { get; set; }
        public decimal total { get; set; }

        /// <summary>
        /// Id  catalogo garantia
        /// </summary>
        public int idGarantia { get; set; }
        public string IdcatTipoPartida { get; set; }
        public string IdClaveCabms { get; set; }
        public string IdClaveSaica { get; set; }
        public int IdTipoEntrada { get; set; }
        public int catTipoEntrada { get; set; }
        /// <summary>
        /// Es el resultado de la busqueda en cascada del area
        /// </summary>
        public int IdAreaServicio { get; set; }
        public int catPisos { get; set; }
        /// <summary>
        /// campo no obligatorio
        /// </summary>
        public int IdResguardatarios
        {
            get;
            set;
        }
        //FK

        public int catTipoDeBienes
        {
            get;
            set;
        }
        //FK

        public int catEstadoDelBien
        {
            get;
            set;
        }

        public String observaciones { get; set; }
        public int idUsuarioAlta { get; set; }
      

    }
}
