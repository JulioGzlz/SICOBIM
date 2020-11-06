using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Models
{
    public class ModeloInventario
    {
        /// <summary>
        /// IdFederalizacion tabla TblFederalizacion
        /// </summary>
        public string Federalizacion { get; set; }
        /// <summary>
        /// IdInventario tabla TblInventarios
        /// </summary>
        public string Inventarios { get; set; }
        /// <summary>
        /// marca, modelo y serie parte de la Tbls por tipo de inventario
        /// </summary>
        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        /// <summary>
        /// es la cantidad fisica de bienes   1 bien = n pzs
        /// </summary>
        public int cantidad { get; set; }
        /// <summary>
        /// IdContratoBien tabla TblContratoBien
        /// </summary>
        public string ContratoBien { get; set; }
        /// <summary>
        /// IdProveedor tabla TblProveedores
        /// </summary>
        public string Proveedor { get; set; }
        /// <summary>
        /// factura, subtotal,iva,total datos que son parte de  tabla TblFacturas
        /// </summary>
        public string factura { get; set; }
        public double subtotal { get; set; }
        public double iva { get; set; }
        public double total { get; set; }
        /// <summary>
        /// IdGarantia  catalogo garantia
        /// </summary>
        public int IdGarantia { get; set; }

        /// <summary>
        /// IdTipoPartida Catalogo CatTipoPartida
        /// </summary>
        public int IdTipoPartida { get; set; }

        /// <summary>
        /// IdClaveCabms tabla TblClaveCabms
        /// </summary>
        public string ClaveCabms { get; set; }

        /// <summary>
        /// IdClaveSaica tabla TblClaveSaica
        /// </summary>
        public string ClaveSaica { get; set; }
        /// <summary>
        /// IdTipoEntrada Catalogo CatTipodeentrada
        /// </summary>
        public int IdTipoEntrada { get; set; }

        /// <summary>
        /// Es el resultado de la busqueda en cascada del area
        /// </summary>
        public int IdAreaServicio { get; set; }
        /// <summary>
        /// IdPisos Catalogo CatPisos
        /// </summary>
        public int IdPisos { get; set; }
        /// <summary>
        /// campo no obligatorio Tbl resguardatorios
        /// </summary>
        public int IdResguardatarios {get; set; }
        /// <summary>
        /// IdTipoDeBien Catalogo tipo de bien 
        /// </summary>
        public int IdTipoDeBien { get; set; }
        /// <summary>
        /// IdEstadodelBien Catalogo campo no obligatorio
        /// </summary>
        public int IdEstadodelBien { get; set; }
        /// <summary>
        /// observaciones campo no obligatorio
        /// </summary>
        public String observaciones { get; set; }
        /// <summary>
        /// Campo que se manadara por front 
        /// </summary>
        public int idUsuarioAlta { get; set; }





    }
}
