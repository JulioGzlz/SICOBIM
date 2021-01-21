using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SICOBIM_B.Business;
using SICOBIM_B.Models;

namespace SICOBIM_B.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventarioSistemasController : ControllerBase
    {

        BusinessInventarioSistemas _businessSistemas;
        public InventarioSistemasController(BusinessInventarioSistemas objSistemas)
        {
            _businessSistemas = objSistemas;
        }
        #region Consultas metodo get
        /// <summary>
        /// obtiene los resultados de los numeros de inevtario
        /// </summary>
        /// <returns></returns>

        [HttpGet("ObtenerInventarioSistemas")]
        public IActionResult GetTblInventarioSistemas()
        {
            var result = _businessSistemas.GetSistemas(); 
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorFederalizacion")]
        public IActionResult GetConsultaPorFederalizacion()
        {
            var result = _businessSistemas.GetConsultaFederalizacion();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorCabms")]
        public IActionResult GetConsultaPorCabms()
        {
            var result = _businessSistemas.GetConcultaCabms();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorInventario")]
        public IActionResult GetConsultaPorInventario()
        {
            var result = _businessSistemas.GetConsultaInventario();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorProveedor")]
        public IActionResult GetConsultaPorProveedor()
        {
            var result = _businessSistemas.GetConsulataProveedor();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorFactura")]
        public IActionResult GetConsultaPorFactura()
        {
            var result = _businessSistemas.GetTblBienesPorFactura();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorClaveSaica")]
        public IActionResult GetConsultaPorClaveSaica()
        {
            var result = _businessSistemas.GetConsultaClaveSaica();
            return Ok(result);
        }
        /// <summary>
        /// preguntar a edgar
        /// </summary>
        /// <param name="idBien"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("obtenerfactura/{idBienSistema}")]
        public IActionResult GetFacturasTipoInventario(int idBienSistema)
        {
            var result = _businessSistemas.GetFacturasTipoInventario(idBienSistema);
            return Ok(result);
        }
        [HttpGet("ObtenerBienPorContrato")]
        public IActionResult GetConsultaporcontrato()
        {
            var result = _businessSistemas.GetConsultaContrato();
            return Ok(result);
        }
        [HttpGet("ObtenerBienPorResguardatario")]
        public IActionResult GetConsultaporresguardatario()
        {
            var result = _businessSistemas.GetConsultarResguardatario();
            return Ok(result);
        }
        [HttpGet("ObtenerBienPorEstadoFisico")]
        public IActionResult GetConsultaporestadofisico()
        {
            var result = _businessSistemas.GetConsultaEstadoFisicoBien();
            return Ok(result);
        }
        [HttpGet("ObtenerBienPorGarantia")]
        public IActionResult GetConsultaporgarantia()
        {
            var result = _businessSistemas.GetConsultaporGarantia();
            return Ok(result);
        }
        [HttpGet("ObtenerBienPorPiso")]
        public IActionResult GetConsultaporpiso()
        {
            var result = _businessSistemas.GetConsultaPorPiso();
            return Ok(result);
        }
        [HttpGet("ObtenerBienPorTipoDeEntrada")]
        public IActionResult GetConsultaportipodeentrada()
        {
            var result = _businessSistemas.GetConsultaporTipodeEntrada();
            return Ok(result);
        }
        [HttpGet("ObtenerBienPorPartida")]
        public IActionResult GetConsultaporpartida()
        {
            var result = _businessSistemas.GetConsultaporTipodePartida();
            return Ok(result);
        }
        [HttpGet("ObtenerBienPorServicio")]
        public IActionResult GetConsultaporservicio()
        {
            var result = _businessSistemas.GetConsultaporservicio();
            return Ok(result);
        }
        [HttpGet("ObtenerBienPorArea")]
        public IActionResult GetConsultaporArea()
        {
            var result = _businessSistemas.GetConsultaporArea();
            return Ok(result);
        }
        [HttpGet("ObtenerBienPorCostoUnitario")]
        public IActionResult GetConsultaporcosto()
        {
            var result = _businessSistemas.GetConsultaPorPrecioUnitario();
            return Ok(result);
        }
        #endregion

        #region Entradas por Adquisición
        /// <summary>
        /// Función POST que define la entrada  por Adquisición, anexa todos los objetos que trabajan con esta entrada
        /// </summary>
        /// <param name="modeloInventario"></param>
        /// <returns></returns>
        [HttpPost("EntradaporAdquisicion")]
        public IActionResult RegistroInventarioporadquisicion([FromBody] ModeloInventario modeloInventario)
        {
            if (modeloInventario != null)
            {

                TblBienesSistemas tblBienesSistemas = new TblBienesSistemas();
                TblFacturas tblFacturas = new TblFacturas();
                TblClaveSaica tblClavesaica = new TblClaveSaica();
                TblContratoBien tblContratoBien = new TblContratoBien();
                TblFederalizacion tblFederalizacion = new TblFederalizacion();
                TblInventarios tblInventarios = new TblInventarios();
                TblProveedor tblProveedor = new TblProveedor();
                TblClaveCabms tblClaveCabms = new TblClaveCabms();


                tblFacturas.Factura = modeloInventario.factura;
                tblFacturas.Subtotal = modeloInventario.subtotal;
                tblFacturas.Iva = modeloInventario.iva;
                tblFacturas.CostoTotal = modeloInventario.total;
                tblFacturas.CatTipoDeBienId = 4;
                tblFacturas.FechaAlta = DateTime.Now;
                tblFacturas.Activo = true;
                tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblFacturas = _businessSistemas.GuardarFacturaInventariSistemas(tblFacturas);



                tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                tblClavesaica.CatTipoDeBienId = 4;
                tblClavesaica.Activo = true;
                tblClavesaica.FechaAlta = DateTime.Now;
                tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblClavesaica = _businessSistemas.GuardarTblClaveSaica(tblClavesaica);



                tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                tblContratoBien.CatTipoDeBienId = 4;
                tblContratoBien.FechaAlta = DateTime.Now;
                tblContratoBien.Activo = true;
                tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblContratoBien = _businessSistemas.GuardarTblContratoBien(tblContratoBien);


                tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                tblFederalizacion.CatTipoDeBienId = 4;
                tblFederalizacion.FechaAlta = DateTime.Now;
                tblFederalizacion.Activo = true;
                tblFederalizacion.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblFederalizacion = _businessSistemas.GuardarTblFederalizacion(tblFederalizacion);


                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 4;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInventarios = _businessSistemas.GuardarTblInventarios(tblInventarios);

                tblProveedor.Proveedor = modeloInventario.Proveedor;
                tblProveedor.CatTipoDeBienId = 4;
                tblProveedor.FechaAlta = DateTime.Now;
                tblProveedor.Activo = true;
                tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblProveedor = _businessSistemas.GuardarTblProveedor(tblProveedor);


                tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                tblClaveCabms.CatTipoDeBienId = 4;
                tblClaveCabms.FechaAlta = DateTime.Now;
                tblClaveCabms.Activo = true;
                tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblClaveCabms = _businessSistemas.GuardarTblClaveCabms(tblClaveCabms);





                tblBienesSistemas.IdFederalizacionid = tblFederalizacion.Id;
                tblBienesSistemas.Descripcion = modeloInventario.Descripcion;
                tblBienesSistemas.IdInventarioid = tblInventarios.Id;
                tblBienesSistemas.Marca = modeloInventario.marca;
                tblBienesSistemas.Modelo = modeloInventario.modelo;
                tblBienesSistemas.Serie = modeloInventario.serie;
                tblBienesSistemas.Cantidad = modeloInventario.cantidad;
                tblBienesSistemas.Costounitario = modeloInventario.costounitario;
                tblBienesSistemas.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                tblBienesSistemas.CatTipoEntradaid = 1;
                tblBienesSistemas.Catareaid = modeloInventario.IdArea;
                tblBienesSistemas.Catservicioid = modeloInventario.IdServicio;
                tblBienesSistemas.CatPisosid = modeloInventario.IdPisos;
                tblBienesSistemas.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblBienesSistemas.Observaciones = modeloInventario.observaciones;
                tblBienesSistemas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblBienesSistemas.FechaAlta = DateTime.Now;
                tblBienesSistemas.IdContratoBienid = tblContratoBien.Id;
                tblBienesSistemas.IdProveedorid = tblProveedor.Id;
                tblBienesSistemas.IdFacturasid = tblFacturas.IdFactura;
                tblBienesSistemas.CatGarantiaid = modeloInventario.IdGarantia;
                tblBienesSistemas.IdResguardatariosid = modeloInventario.IdResguardatarios;
                tblBienesSistemas.CatTipoDeBienid = 4;
                tblBienesSistemas.Activo = true;
                tblBienesSistemas.IdClaveCabmsid = tblClaveCabms.Id;
                tblBienesSistemas.IdClaveSaicaid = tblClavesaica.Id;
                _businessSistemas.GuardarTblSistemas(tblBienesSistemas);

            }


            return Ok();
        }

        #endregion

        #region Entradas por Traspaso
        [HttpPost("EntradaporTraspaso")]
        public IActionResult RegistroInventarioportraspaso([FromBody] ModeloInventario modeloInventario)
        {
            if (modeloInventario != null)
            {

                TblBienesSistemas tblBienesSistemas = new TblBienesSistemas();
                TblFacturas tblFacturas = new TblFacturas();
                TblClaveSaica tblClavesaica = new TblClaveSaica();
                TblContratoBien tblContratoBien = new TblContratoBien();
                TblFederalizacion tblFederalizacion = new TblFederalizacion();
                TblInventarios tblInventarios = new TblInventarios();
                TblProveedor tblProveedor = new TblProveedor();
                TblClaveCabms tblClaveCabms = new TblClaveCabms();

                tblFacturas.Factura = modeloInventario.factura;
                tblFacturas.CatTipoDeBienId = 4;
                tblFacturas.FechaAlta = DateTime.Now;
                tblFacturas.Activo = true;
                tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblFacturas = _businessSistemas.GuardarFacturaInventariSistemas(tblFacturas);



                tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                tblClavesaica.CatTipoDeBienId = 4;
                tblClavesaica.Activo = true;
                tblClavesaica.FechaAlta = DateTime.Now;
                tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblClavesaica = _businessSistemas.GuardarTblClaveSaica(tblClavesaica);



                tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                tblContratoBien.CatTipoDeBienId = 4;
                tblContratoBien.FechaAlta = DateTime.Now;
                tblContratoBien.Activo = true;
                tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblContratoBien = _businessSistemas.GuardarTblContratoBien(tblContratoBien);


                tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                tblFederalizacion.CatTipoDeBienId = 4;
                tblFederalizacion.FechaAlta = DateTime.Now;
                tblFederalizacion.Activo = true;
                tblFederalizacion.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblFederalizacion = _businessSistemas.GuardarTblFederalizacion(tblFederalizacion);


                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 4;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInventarios = _businessSistemas.GuardarTblInventarios(tblInventarios);

                tblProveedor.Proveedor = modeloInventario.Proveedor;
                tblProveedor.CatTipoDeBienId = 4;
                tblProveedor.FechaAlta = DateTime.Now;
                tblProveedor.Activo = true;
                tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblProveedor = _businessSistemas.GuardarTblProveedor(tblProveedor);


                tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                tblClaveCabms.CatTipoDeBienId = 4;
                tblClaveCabms.FechaAlta = DateTime.Now;
                tblClaveCabms.Activo = true;
                tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblClaveCabms = _businessSistemas.GuardarTblClaveCabms(tblClaveCabms);

                tblBienesSistemas.IdFederalizacionid = tblFederalizacion.Id;
                tblBienesSistemas.Descripcion = modeloInventario.Descripcion;
                tblBienesSistemas.IdInventarioid = tblInventarios.Id;
                tblBienesSistemas.Marca = modeloInventario.marca;
                tblBienesSistemas.Modelo = modeloInventario.modelo;
                tblBienesSistemas.Serie = modeloInventario.serie;
                tblBienesSistemas.Cantidad = modeloInventario.cantidad;
                tblBienesSistemas.Costounitario = modeloInventario.costounitario;
                tblBienesSistemas.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                tblBienesSistemas.CatTipoEntradaid = 2;
                tblBienesSistemas.CatPisosid = modeloInventario.IdPisos;
                tblBienesSistemas.Catareaid = modeloInventario.IdArea;
                tblBienesSistemas.Catservicioid = modeloInventario.IdServicio;
                tblBienesSistemas.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblBienesSistemas.Observaciones = modeloInventario.observaciones;
                tblBienesSistemas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblBienesSistemas.FechaAlta = DateTime.Now;
                ///Es un dato que puede ir o no
                tblBienesSistemas.IdContratoBienid = tblContratoBien.Id;
                ///Es un dato que puede ir o no
                tblBienesSistemas.IdProveedorid = tblProveedor.Id;
                ///Es un dato que puede ir o no
                tblBienesSistemas.IdFacturasid = tblFacturas.IdFactura;
                tblBienesSistemas.IdResguardatariosid = modeloInventario.IdResguardatarios;
                tblBienesSistemas.CatTipoDeBienid = 4;
                tblBienesSistemas.Activo = true;
                tblBienesSistemas.IdClaveCabmsid = tblClaveCabms.Id;
                tblBienesSistemas.IdClaveSaicaid = tblClavesaica.Id;
                _businessSistemas.GuardarTblSistemas(tblBienesSistemas);



            }


            return Ok();
        }
        #endregion

        #region entrada por donaciòn 


        /// <summary>
        /// este tipo de entrada solo son para registros interno ya que no se encuentran con algun costo por parte de la SEDESA
        /// </summary>
        /// <param name="modeloInventario"></param>
        /// <returns></returns>
        [HttpPost("EntradaporDonacion")]
        public IActionResult RegistroInventariopordonacion([FromBody] ModeloInventario modeloInventario)
        {

            if (modeloInventario != null)
            {

                TblBienesSistemas tblBienesSistemas = new TblBienesSistemas();

                TblInventarios tblInventarios = new TblInventarios();

                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 4;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInventarios = _businessSistemas.GuardarTblInventarios(tblInventarios);





                tblBienesSistemas.Descripcion = modeloInventario.Descripcion;
                ///<summary>
                ///Este tipo de entrada lleva un numero de inventario interno
                ///</summary>
                tblBienesSistemas.IdInventarioid = tblInventarios.Id;
                tblBienesSistemas.Marca = modeloInventario.marca;
                tblBienesSistemas.Modelo = modeloInventario.modelo;
                tblBienesSistemas.Serie = modeloInventario.serie;
                tblBienesSistemas.Cantidad = modeloInventario.cantidad;
                tblBienesSistemas.CatTipoEntradaid = 3;
                tblBienesSistemas.CatPisosid = modeloInventario.IdPisos;
                tblBienesSistemas.Catareaid = modeloInventario.IdArea;
                tblBienesSistemas.Catservicioid = modeloInventario.IdServicio;
                tblBienesSistemas.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblBienesSistemas.Observaciones = modeloInventario.observaciones;
                tblBienesSistemas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblBienesSistemas.FechaAlta = DateTime.Now;
                tblBienesSistemas.IdResguardatariosid = modeloInventario.IdResguardatarios;
                tblBienesSistemas.CatTipoDeBienid = 4;
                tblBienesSistemas.Activo = true;
                _businessSistemas.GuardarTblSistemas(tblBienesSistemas);



            }


            return Ok();
        }
        #endregion

        #region entrada por Reposición 


        /// <summary>
        /// este tipo de entrada solo son para registros Reposición
        /// </summary>
        /// <param name="modeloInventario"></param>
        /// <returns></returns>
        [HttpPost("EntradaporSustitucion")]
        public IActionResult RegistroInventarioporReposicion([FromBody] ModeloInventario modeloInventario)
        {
            if (modeloInventario != null)
            {

                TblBienesSistemas tblBienesSistemas = new TblBienesSistemas();
                TblFacturas tblFacturas = new TblFacturas();
                TblClaveSaica tblClavesaica = new TblClaveSaica();
                TblContratoBien tblContratoBien = new TblContratoBien();
                TblFederalizacion tblFederalizacion = new TblFederalizacion();
                TblInventarios tblInventarios = new TblInventarios();
                TblProveedor tblProveedor = new TblProveedor();
                TblClaveCabms tblClaveCabms = new TblClaveCabms();


                tblFacturas.Factura = modeloInventario.factura;
                tblFacturas.CatTipoDeBienId = 4;
                tblFacturas.FechaAlta = DateTime.Now;
                tblFacturas.Activo = true;
                tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblFacturas = _businessSistemas.GuardarFacturaInventariSistemas(tblFacturas);



                tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                tblClavesaica.CatTipoDeBienId = 4;
                tblClavesaica.Activo = true;
                tblClavesaica.FechaAlta = DateTime.Now;
                tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblClavesaica = _businessSistemas.GuardarTblClaveSaica(tblClavesaica);



                tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                tblContratoBien.CatTipoDeBienId = 4;
                tblContratoBien.FechaAlta = DateTime.Now;
                tblContratoBien.Activo = true;
                tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblContratoBien = _businessSistemas.GuardarTblContratoBien(tblContratoBien);
                tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                tblFederalizacion.CatTipoDeBienId = 4;
                tblFederalizacion.FechaAlta = DateTime.Now;
                tblFederalizacion.Activo = true;
                tblFederalizacion.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblFederalizacion = _businessSistemas.GuardarTblFederalizacion(tblFederalizacion);


                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 4;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInventarios = _businessSistemas.GuardarTblInventarios(tblInventarios);

                tblProveedor.Proveedor = modeloInventario.Proveedor;
                tblProveedor.CatTipoDeBienId = 4;
                tblProveedor.FechaAlta = DateTime.Now;
                tblProveedor.Activo = true;
                tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblProveedor = _businessSistemas.GuardarTblProveedor(tblProveedor);


                tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                tblClaveCabms.CatTipoDeBienId = 4;
                tblClaveCabms.FechaAlta = DateTime.Now;
                tblClaveCabms.Activo = true;
                tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblClaveCabms = _businessSistemas.GuardarTblClaveCabms(tblClaveCabms);

                tblBienesSistemas.IdFederalizacionid = tblFederalizacion.Id;
                tblBienesSistemas.Descripcion = modeloInventario.Descripcion;
                tblBienesSistemas.IdInventarioid = tblInventarios.Id;
                tblBienesSistemas.Marca = modeloInventario.marca;
                tblBienesSistemas.Modelo = modeloInventario.modelo;
                tblBienesSistemas.Serie = modeloInventario.serie;
                tblBienesSistemas.Cantidad = modeloInventario.cantidad;
                tblBienesSistemas.Costounitario = modeloInventario.costounitario;
                tblBienesSistemas.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                tblBienesSistemas.CatTipoEntradaid = 4;
                tblBienesSistemas.CatPisosid = modeloInventario.IdPisos;
                tblBienesSistemas.Catareaid = modeloInventario.IdArea;
                tblBienesSistemas.Catservicioid = modeloInventario.IdServicio;
                tblBienesSistemas.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblBienesSistemas.Observaciones = modeloInventario.observaciones;
                tblBienesSistemas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblBienesSistemas.FechaAlta = DateTime.Now;
                tblBienesSistemas.IdFacturasid = tblFacturas.IdFactura;
                tblBienesSistemas.IdResguardatariosid = modeloInventario.IdResguardatarios;
                tblBienesSistemas.CatTipoDeBienid = 4;
                tblBienesSistemas.Activo = true;
                tblBienesSistemas.IdClaveCabmsid = tblClaveCabms.Id;
                tblBienesSistemas.IdClaveSaicaid = tblClavesaica.Id;
                _businessSistemas.GuardarTblSistemas(tblBienesSistemas);



            }


            return Ok();
        }
        #endregion





    }
}
