using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SICOBIM_B.Business;
using SICOBIM_B.Common;
using SICOBIM_B.Helpers;
using SICOBIM_B.Models;
using SICOBIM_B.Services;

namespace SICOBIM_B.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class InventarioMobiliarioController : ControllerBase
    {

        BusinessInventarioMobiliario _businessInventarioMobiliario;
        RespuestaApi<TblInventarios> objRespuestatblInventarios = new RespuestaApi<TblInventarios>();
        RespuestaApi<TblFederalizacion> objRespuestatblFederalizacion = new RespuestaApi<TblFederalizacion>();
        #region Consultas metodo get
        public InventarioMobiliarioController(BusinessInventarioMobiliario objInventarioMobiliario)

        {
            _businessInventarioMobiliario = objInventarioMobiliario;
        }


        [HttpGet("ObtenerBienesMuebles")]
        public IActionResult GetTblBienes()
        {
            var result = _businessInventarioMobiliario.GetTblBienes();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorFederalizacion")]
        public IActionResult GetConsultaPorFederalizacion()
        {
            var result = _businessInventarioMobiliario.GetConsultaFederalizacion();
            return Ok(result);
        }
        [HttpGet("ObtenerInventarioPorCabms")]
        public IActionResult GettblBienesMueblesCabms()
        {
            var result = _businessInventarioMobiliario.GetConcultaCabms();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorInventario")]
        public IActionResult GetEquipoMedicoPorInventario()
        {
            var result = _businessInventarioMobiliario.GetConsultaInventario();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorProvedor")]
        public IActionResult GetConsulataEquipoMedicoProveedor()
        {
            var result = _businessInventarioMobiliario.GetConsulataProveedor();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorFactura")]
        public IActionResult GetComsultafactura()
        {
            var result = _businessInventarioMobiliario.GetConcultaPorFactura();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorClaveSaica")]
        public IActionResult GetConsultaporsaica()
        {
            var result = _businessInventarioMobiliario.GetConsultaClaveSaica();
            return Ok(result);
        }
        [HttpGet]
        [Route("obtenerfactura/{idBienMobiliario}")]
        public IActionResult GetFacturasTipoInventario(int idBienMobiliario)
        {
            var result = _businessInventarioMobiliario.GetFacturasTipoInventario(idBienMobiliario);
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorContrato")]
        public IActionResult GetConsultaporcontrato()
        {
            var result = _businessInventarioMobiliario.GetConsultaContrato();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorResguardatario")]
        public IActionResult GetConsultaporresguardatario()
        {
            var result = _businessInventarioMobiliario.GetConsultarResguardatario();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorEstadoFisico")]
        public IActionResult GetConsultaporestadofisico()
        {
            var result = _businessInventarioMobiliario.GetConsultaEstadoFisicoBien();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorGarantia")]
        public IActionResult GetConsultaporgarantia()
        {
            var result = _businessInventarioMobiliario.GetConsultaporGarantia();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorPiso")]
        public IActionResult GetConsultaporpiso()
        {
            var result = _businessInventarioMobiliario.GetConsultaPorPiso();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorTipoDeEntrada")]
        public IActionResult GetConsultaportipodeentrada()
        {
            var result = _businessInventarioMobiliario.GetConsultaporTipodeEntrada();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorPartida")]
        public IActionResult GetConsultaporpartida()
        {
            var result = _businessInventarioMobiliario.GetConsultaporTipodePartida();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorServicio")]
        public IActionResult GetConsultaporservicio()
        {
            var result = _businessInventarioMobiliario.GetConsultaporservicio();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorArea")]
        public IActionResult GetConsultaporArea()
        {
            var result = _businessInventarioMobiliario.GetConsultaporArea();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorCostoUnitario")]
        public IActionResult GetConsultaporcosto()
        {
            var result = _businessInventarioMobiliario.GetConsultaPorPrecioUnitario();
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
            {

                TblBienesMuebles tblBienesMuebles = new TblBienesMuebles();
                TblFacturas tblFacturas = new TblFacturas();
                TblClaveSaica tblClavesaica = new TblClaveSaica();
                TblContratoBien tblContratoBien = new TblContratoBien();
                TblFederalizacion tblFederalizacion = new TblFederalizacion();
                TblInventarios tblInventarios = new TblInventarios();
                TblProveedor tblProveedor = new TblProveedor();
                TblClaveCabms tblClaveCabms = new TblClaveCabms();
                try
                {



                    tblFacturas.Factura = modeloInventario.factura;
                    tblFacturas.Subtotal = modeloInventario.subtotal;
                    tblFacturas.Iva = modeloInventario.iva;
                    tblFacturas.CostoTotal = modeloInventario.total;
                    tblFacturas.CatTipoDeBienId = 1;
                    tblFacturas.FechaAlta = DateTime.Now;
                    tblFacturas.Activo = true;
                    tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                    tblFacturas = _businessInventarioMobiliario.GuardarFacturaInventarioMobiliario(tblFacturas);



                    tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                    tblClavesaica.CatTipoDeBienId = 1;
                    tblClavesaica.Activo = true;
                    tblClavesaica.FechaAlta = DateTime.Now;
                    tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                    tblClavesaica = _businessInventarioMobiliario.GuardarTblClaveSaica(tblClavesaica);



                    tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                    tblContratoBien.CatTipoDeBienId = 1;
                    tblContratoBien.FechaAlta = DateTime.Now;
                    tblContratoBien.Activo = true;
                    tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblContratoBien = _businessInventarioMobiliario.GuardarTblContratoBien(tblContratoBien);


                    tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                    tblFederalizacion.CatTipoDeBienId = 1;
                    tblFederalizacion.FechaAlta = DateTime.Now;
                    tblFederalizacion.Activo = true;
                    tblFederalizacion.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    objRespuestatblFederalizacion = _businessInventarioMobiliario.GuardarTblFederalizacion(tblFederalizacion);


                    tblInventarios.NumeroInventario = modeloInventario.Inventario;
                    tblInventarios.CatTipoDeBienId = 1;
                    tblInventarios.FechaAlta = DateTime.Now;
                    tblInventarios.Activo = true;
                    tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    objRespuestatblInventarios = _businessInventarioMobiliario.GuardarTblInventarios(tblInventarios);

                    tblProveedor.Proveedor = modeloInventario.Proveedor;
                    tblProveedor.CatTipoDeBienId = 1;
                    tblProveedor.FechaAlta = DateTime.Now;
                    tblProveedor.Activo = true;
                    tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblProveedor = _businessInventarioMobiliario.GuardarTblProveedor(tblProveedor);


                    tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                    tblClaveCabms.CatTipoDeBienId = 1;
                    tblClaveCabms.FechaAlta = DateTime.Now;
                    tblClaveCabms.Activo = true;
                    tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblClaveCabms = _businessInventarioMobiliario.GuardarTblClaveCabms(tblClaveCabms);





                    tblBienesMuebles.IdFederalizacionid = objRespuestatblFederalizacion.objGenerics.Id;
                    tblBienesMuebles.Descripcion = modeloInventario.Descripcion;
                    tblBienesMuebles.IdInventarioid = objRespuestatblInventarios.objGenerics.Id;
                    tblBienesMuebles.Marca = modeloInventario.marca;
                    tblBienesMuebles.Modelo = modeloInventario.modelo;
                    tblBienesMuebles.Serie = modeloInventario.serie;
                    tblBienesMuebles.Cantidad = modeloInventario.cantidad;
                    tblBienesMuebles.Costounitario = modeloInventario.costounitario;
                    tblBienesMuebles.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                    tblBienesMuebles.CatTipoEntradaid = 1;
                    tblBienesMuebles.Catareaid = modeloInventario.IdArea;
                    tblBienesMuebles.Catservicioid = modeloInventario.IdServicio;
                    tblBienesMuebles.CatPisosid = modeloInventario.IdPisos;
                    tblBienesMuebles.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                    tblBienesMuebles.Observaciones = modeloInventario.observaciones;
                    tblBienesMuebles.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblBienesMuebles.FechaAlta = DateTime.Now;
                    tblBienesMuebles.IdContratoBienid = tblContratoBien.Id;
                    tblBienesMuebles.IdProveedorid = tblProveedor.Id;
                    tblBienesMuebles.IdFacturasid = tblFacturas.IdFactura;
                    tblBienesMuebles.CatGarantiaid = modeloInventario.IdGarantia;
                    tblBienesMuebles.IdResguardatariosid = modeloInventario.IdResguardatarios;
                    tblBienesMuebles.CatTipoDeBienid = 1;
                    tblBienesMuebles.Activo = true;
                    tblBienesMuebles.IdClaveCabmsid = tblClaveCabms.Id;
                    tblBienesMuebles.IdClaveSaicaid = tblClavesaica.Id;

                    if (objRespuestatblInventarios.correcto == false)
                    {
                        return BadRequest(new { message = objRespuestatblInventarios.Mensaje });
                    }
                    else
                    {

                        var result =
                    _businessInventarioMobiliario.GuardarTblBienesMuebles(tblBienesMuebles);
                        return Ok(result);
                    }

                }
                catch (AppException ex)
                {
                    return BadRequest(new { message = ex.Message });
                }
            }

        }

        #endregion

        #region Entradas por Traspaso
        [HttpPost("EntradaporTraspaso")]
        public IActionResult RegistroInventarioportraspaso([FromBody] ModeloInventario modeloInventario)
        {
            {

                TblBienesMuebles tblBienesMuebles = new TblBienesMuebles();
                TblFacturas tblFacturas = new TblFacturas();
                TblClaveSaica tblClavesaica = new TblClaveSaica();
                TblContratoBien tblContratoBien = new TblContratoBien();
                TblFederalizacion tblFederalizacion = new TblFederalizacion();
                TblInventarios tblInventarios = new TblInventarios();
                TblProveedor tblProveedor = new TblProveedor();
                TblClaveCabms tblClaveCabms = new TblClaveCabms();

                try
                {
                    tblFacturas.Factura = modeloInventario.factura;
                    tblFacturas.CatTipoDeBienId = 1;
                    tblFacturas.FechaAlta = DateTime.Now;
                    tblFacturas.Activo = true;
                    tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                    tblFacturas = _businessInventarioMobiliario.GuardarFacturaInventarioMobiliario(tblFacturas);



                    tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                    tblClavesaica.CatTipoDeBienId = 1;
                    tblClavesaica.Activo = true;
                    tblClavesaica.FechaAlta = DateTime.Now;
                    tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                    tblClavesaica = _businessInventarioMobiliario.GuardarTblClaveSaica(tblClavesaica);



                    tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                    tblContratoBien.CatTipoDeBienId = 1;
                    tblContratoBien.FechaAlta = DateTime.Now;
                    tblContratoBien.Activo = true;
                    tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblContratoBien = _businessInventarioMobiliario.GuardarTblContratoBien(tblContratoBien);


                    tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                    tblFederalizacion.CatTipoDeBienId = 1;
                    tblFederalizacion.FechaAlta = DateTime.Now;
                    tblFederalizacion.Activo = true;
                    tblFederalizacion.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    objRespuestatblFederalizacion = _businessInventarioMobiliario.GuardarTblFederalizacion(tblFederalizacion);


                    tblInventarios.NumeroInventario = modeloInventario.Inventario;
                    tblInventarios.CatTipoDeBienId = 1;
                    tblInventarios.FechaAlta = DateTime.Now;
                    tblInventarios.Activo = true;
                    tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    objRespuestatblInventarios = _businessInventarioMobiliario.GuardarTblInventarios(tblInventarios);

                    tblProveedor.Proveedor = modeloInventario.Proveedor;
                    tblProveedor.CatTipoDeBienId = 1;
                    tblProveedor.FechaAlta = DateTime.Now;
                    tblProveedor.Activo = true;
                    tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblProveedor = _businessInventarioMobiliario.GuardarTblProveedor(tblProveedor);


                    tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                    tblClaveCabms.CatTipoDeBienId = 1;
                    tblClaveCabms.FechaAlta = DateTime.Now;
                    tblClaveCabms.Activo = true;
                    tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblClaveCabms = _businessInventarioMobiliario.GuardarTblClaveCabms(tblClaveCabms);

                    tblBienesMuebles.IdFederalizacionid = objRespuestatblFederalizacion.objGenerics.Id;
                    tblBienesMuebles.Descripcion = modeloInventario.Descripcion;
                    tblBienesMuebles.IdInventarioid = objRespuestatblInventarios.objGenerics.Id;
                    tblBienesMuebles.Marca = modeloInventario.marca;
                    tblBienesMuebles.Modelo = modeloInventario.modelo;
                    tblBienesMuebles.Serie = modeloInventario.serie;
                    tblBienesMuebles.Cantidad = modeloInventario.cantidad;
                    tblBienesMuebles.Costounitario = modeloInventario.costounitario;
                    tblBienesMuebles.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                    tblBienesMuebles.CatTipoEntradaid = 2;
                    tblBienesMuebles.CatPisosid = modeloInventario.IdPisos;
                    tblBienesMuebles.Catareaid = modeloInventario.IdArea;
                    tblBienesMuebles.Catservicioid = modeloInventario.IdServicio;
                    tblBienesMuebles.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                    tblBienesMuebles.Observaciones = modeloInventario.observaciones;
                    tblBienesMuebles.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblBienesMuebles.FechaAlta = DateTime.Now;
                    ///Es un dato que puede ir o no
                    tblBienesMuebles.IdContratoBienid = tblContratoBien.Id;
                    ///Es un dato que puede ir o no
                    tblBienesMuebles.IdProveedorid = tblProveedor.Id;
                    ///Es un dato que puede ir o no
                    tblBienesMuebles.IdFacturasid = tblFacturas.IdFactura;
                    tblBienesMuebles.IdResguardatariosid = modeloInventario.IdResguardatarios;
                    tblBienesMuebles.CatTipoDeBienid = 1;
                    tblBienesMuebles.Activo = true;
                    tblBienesMuebles.IdClaveCabmsid = tblClaveCabms.Id;
                    tblBienesMuebles.IdClaveSaicaid = tblClavesaica.Id;
                    if (objRespuestatblInventarios.correcto == false)
                    {
                        return BadRequest(new { message = objRespuestatblInventarios.Mensaje });
                    }
                    else
                    {

                        var result =
                    _businessInventarioMobiliario.GuardarTblBienesMuebles(tblBienesMuebles);
                        return Ok(result);
                    }

                }
                catch (AppException ex)
                {
                    return BadRequest(new { message = ex.Message });
                }
            }

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
            {

                TblBienesMuebles tblBienesMuebles = new TblBienesMuebles();

                TblInventarios tblInventarios = new TblInventarios();
                try
                {

                    tblInventarios.NumeroInventario = modeloInventario.Inventario;
                    tblInventarios.CatTipoDeBienId = 1;
                    tblInventarios.FechaAlta = DateTime.Now;
                    tblInventarios.Activo = true;
                    tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    objRespuestatblInventarios = _businessInventarioMobiliario.GuardarTblInventarios(tblInventarios);





                    tblBienesMuebles.Descripcion = modeloInventario.Descripcion;
                    ///<summary>
                    ///Este tipo de entrada lleva un numero de inventario interno
                    ///</summary>
                    tblBienesMuebles.IdInventarioid = objRespuestatblInventarios.objGenerics.Id;
                    tblBienesMuebles.Marca = modeloInventario.marca;
                    tblBienesMuebles.Modelo = modeloInventario.modelo;
                    tblBienesMuebles.Serie = modeloInventario.serie;
                    tblBienesMuebles.Cantidad = modeloInventario.cantidad;
                    tblBienesMuebles.CatTipoEntradaid = 3;
                    tblBienesMuebles.CatPisosid = modeloInventario.IdPisos;
                    tblBienesMuebles.Catareaid = modeloInventario.IdArea;
                    tblBienesMuebles.Catservicioid = modeloInventario.IdServicio;
                    tblBienesMuebles.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                    tblBienesMuebles.Observaciones = modeloInventario.observaciones;
                    tblBienesMuebles.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblBienesMuebles.FechaAlta = DateTime.Now;
                    tblBienesMuebles.IdResguardatariosid = modeloInventario.IdResguardatarios;
                    tblBienesMuebles.CatTipoDeBienid = 1;
                    tblBienesMuebles.Activo = true;
                    if (objRespuestatblInventarios.correcto == false)
                    {
                        return BadRequest(new { message = objRespuestatblInventarios.Mensaje });
                    }
                    else
                    {

                        var result =
                    _businessInventarioMobiliario.GuardarTblBienesMuebles(tblBienesMuebles);
                        return Ok(result);
                    }

                }
                catch (AppException ex)
                {
                    return BadRequest(new { message = ex.Message });
                }
            }

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
            {

                TblBienesMuebles tblBienesMuebles = new TblBienesMuebles();
                TblFacturas tblFacturas = new TblFacturas();
                TblClaveSaica tblClavesaica = new TblClaveSaica();
                TblContratoBien tblContratoBien = new TblContratoBien();
                TblFederalizacion tblFederalizacion = new TblFederalizacion();
                TblInventarios tblInventarios = new TblInventarios();
                TblProveedor tblProveedor = new TblProveedor();
                TblClaveCabms tblClaveCabms = new TblClaveCabms();

                try
                {


                    tblFacturas.Factura = modeloInventario.factura;
                    tblFacturas.CatTipoDeBienId = 1;
                    tblFacturas.FechaAlta = DateTime.Now;
                    tblFacturas.Activo = true;
                    tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                    tblFacturas = _businessInventarioMobiliario.GuardarFacturaInventarioMobiliario(tblFacturas);



                    tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                    tblClavesaica.CatTipoDeBienId = 1;
                    tblClavesaica.Activo = true;
                    tblClavesaica.FechaAlta = DateTime.Now;
                    tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                    tblClavesaica = _businessInventarioMobiliario.GuardarTblClaveSaica(tblClavesaica);



                    tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                    tblContratoBien.CatTipoDeBienId = 1;
                    tblContratoBien.FechaAlta = DateTime.Now;
                    tblContratoBien.Activo = true;
                    tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblContratoBien = _businessInventarioMobiliario.GuardarTblContratoBien(tblContratoBien);
                    tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                    tblFederalizacion.CatTipoDeBienId = 1;
                    tblFederalizacion.FechaAlta = DateTime.Now;
                    tblFederalizacion.Activo = true;
                    tblFederalizacion.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    objRespuestatblFederalizacion = _businessInventarioMobiliario.GuardarTblFederalizacion(tblFederalizacion);


                    tblInventarios.NumeroInventario = modeloInventario.Inventario;
                    tblInventarios.CatTipoDeBienId = 1;
                    tblInventarios.FechaAlta = DateTime.Now;
                    tblInventarios.Activo = true;
                    tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    objRespuestatblInventarios = _businessInventarioMobiliario.GuardarTblInventarios(tblInventarios);

                    tblProveedor.Proveedor = modeloInventario.Proveedor;
                    tblProveedor.CatTipoDeBienId = 1;
                    tblProveedor.FechaAlta = DateTime.Now;
                    tblProveedor.Activo = true;
                    tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblProveedor = _businessInventarioMobiliario.GuardarTblProveedor(tblProveedor);


                    tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                    tblClaveCabms.CatTipoDeBienId = 1;
                    tblClaveCabms.FechaAlta = DateTime.Now;
                    tblClaveCabms.Activo = true;
                    tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblClaveCabms = _businessInventarioMobiliario.GuardarTblClaveCabms(tblClaveCabms);

                    tblBienesMuebles.IdFederalizacionid = objRespuestatblFederalizacion.objGenerics.Id;
                    tblBienesMuebles.Descripcion = modeloInventario.Descripcion;
                    tblBienesMuebles.IdInventarioid = objRespuestatblInventarios.objGenerics.Id;
                    tblBienesMuebles.Marca = modeloInventario.marca;
                    tblBienesMuebles.Modelo = modeloInventario.modelo;
                    tblBienesMuebles.Serie = modeloInventario.serie;
                    tblBienesMuebles.Cantidad = modeloInventario.cantidad;
                    tblBienesMuebles.Costounitario = modeloInventario.costounitario;
                    tblBienesMuebles.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                    tblBienesMuebles.CatTipoEntradaid = 4;
                    tblBienesMuebles.CatPisosid = modeloInventario.IdPisos;
                    tblBienesMuebles.Catareaid = modeloInventario.IdArea;
                    tblBienesMuebles.Catservicioid = modeloInventario.IdServicio;
                    tblBienesMuebles.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                    tblBienesMuebles.Observaciones = modeloInventario.observaciones;
                    tblBienesMuebles.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                    tblBienesMuebles.FechaAlta = DateTime.Now;
                    tblBienesMuebles.IdFacturasid = tblFacturas.IdFactura;
                    tblBienesMuebles.IdResguardatariosid = modeloInventario.IdResguardatarios;
                    tblBienesMuebles.CatTipoDeBienid = 1;
                    tblBienesMuebles.Activo = true;
                    tblBienesMuebles.IdClaveCabmsid = tblClaveCabms.Id;
                    tblBienesMuebles.IdClaveSaicaid = tblClavesaica.Id;
                    if (objRespuestatblInventarios.correcto == false)
                    {
                        return BadRequest(new { message = objRespuestatblInventarios.Mensaje });
                    }
                    else
                    {

                        var result =
                    _businessInventarioMobiliario.GuardarTblBienesMuebles(tblBienesMuebles);
                        return Ok(result);
                    }

                }
                catch (AppException ex)
                {
                    return BadRequest(new { message = ex.Message });
                }
            }

        }

        #endregion

    }

}
