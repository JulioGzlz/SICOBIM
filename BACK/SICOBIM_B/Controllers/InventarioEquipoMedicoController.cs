using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SICOBIM_B.Business;
using SICOBIM_B.Common;
using SICOBIM_B.Entities;
using SICOBIM_B.Helpers;
using SICOBIM_B.Models;
using SICOBIM_B.Services;

namespace SICOBIM_B.Controllers
{

    /// <summary>
    /// Inventario de equipo medico
    /// Existen 3 tipos de entrada
    // 1 - Adquisición
    // 2 - Traspaso
    // 3 - Donacion
    //  Definir cada uno de los tipos de entrada, existen cada POST por cada tipo de entrada definiendo CADA OBJETO y/o Clase a utilizar
    // esas clases u objetos son definidos por tipo de negocio en cada entrada
    // Cada post se debe SETear el tipo entrada como 1,2,3 y en cada controller el tipo de inventario como 1,2,3,4

    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class InventarioEquipoMedicoController : ControllerBase
    {

        BusinessInventarioEquipoMedico _businessEquipoMedico;
        RespuestaApi<TblInventarios> objRespuestatblInventarios = new RespuestaApi<TblInventarios>();


        public InventarioEquipoMedicoController(BusinessInventarioEquipoMedico objEquipoMedico)
        {
            _businessEquipoMedico = objEquipoMedico;
        

        }
        #region Consultas metodo get

        [HttpGet("ObtenerInventarioEquipoMedico")]
        public IActionResult GetTblBienesEquMedico()
        {
            var result = _businessEquipoMedico.GetEquipoMedico();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorFederalizacion")]
        public IActionResult GetConsultaPorFederalizacion()
        {
            var result = _businessEquipoMedico.GetConsultaFederalizacion();
            return Ok(result);
        }
        [HttpGet("ObtenerInventarioPorCabms")]
        public IActionResult GetTblBienesEquMedicoCabms()
        {
            var result = _businessEquipoMedico.GetConcultaCabms();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorInventario")]
        public IActionResult GetEquipoMedicoPorInventario()
        {
            var result = _businessEquipoMedico.GetConsultaInventario();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorProvedor")]
        public IActionResult GetConsulataEquipoMedicoProveedor()
        {
            var result = _businessEquipoMedico.GetConsulataProveedor();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorFactura")]
        public IActionResult GetComsultafactura()
        {
            var result = _businessEquipoMedico.GetConcultaPorFactura();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorClaveSaica")]
        public IActionResult GetConsultaporsaica()
        {
            var result = _businessEquipoMedico.GetConsultaClaveSaica();
            return Ok(result);
        }
        [HttpGet]
        [Route("obtenerfactura/{idBien}")]
        public IActionResult GetFacturasTipoInventario(int idBien)
        {
            var result = _businessEquipoMedico.GetFacturasTipoInventario(idBien);
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorContrato")]
        public IActionResult GetConsultaporcontrato()
        {
            var result = _businessEquipoMedico.GetConsultaContrato();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorResguardatario")]
        public IActionResult GetConsultaporresguardatario()
        {
            var result = _businessEquipoMedico.GetConsultarResguardatario();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorEstadoFisico")]
        public IActionResult GetConsultaporestadofisico()
        {
            var result = _businessEquipoMedico.GetConsultaEstadoFisicoBien();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorGarantia")]
        public IActionResult GetConsultaporgarantia()
        {
            var result = _businessEquipoMedico.GetConsultaporGarantia();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorPiso")]
        public IActionResult GetConsultaporpiso()
        {
            var result = _businessEquipoMedico.GetConsultaPorPiso();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorTipoDeEntrada")]
        public IActionResult GetConsultaportipodeentrada()
        {
            var result = _businessEquipoMedico.GetConsultaporTipodeEntrada();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorPartida")]
        public IActionResult GetConsultaporpartida()
        {
            var result = _businessEquipoMedico.GetConsultaporTipodePartida();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorServicio")]
        public IActionResult GetConsultaporservicio()
        {
            var result = _businessEquipoMedico.GetConsultaporservicio();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorArea")]
        public IActionResult GetConsultaporArea()
        {
            var result = _businessEquipoMedico.GetConsultaporArea();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorCostoUnitario")]
        public IActionResult GetConsultaporcosto()
        {
            var result = _businessEquipoMedico.GetConsultaPorPrecioUnitario();
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
            TblBienesEquMedico tblBienesEquMedico = new TblBienesEquMedico();
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
                tblFacturas.CatTipoDeBienId = 2;
                tblFacturas.FechaAlta = DateTime.Now;
                tblFacturas.Activo = true;
                tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblFacturas = _businessEquipoMedico.GuardarFacturaInventarioEquipoMedico(tblFacturas);



                tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                tblClavesaica.CatTipoDeBienId = 2;
                tblClavesaica.Activo = true;
                tblClavesaica.FechaAlta = DateTime.Now;
                tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblClavesaica = _businessEquipoMedico.GuardarTblClaveSaica(tblClavesaica);



                tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                tblContratoBien.CatTipoDeBienId = 2;
                tblContratoBien.FechaAlta = DateTime.Now;
                tblContratoBien.Activo = true;
                tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblContratoBien = _businessEquipoMedico.GuardarTblContratoBien(tblContratoBien);


                tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                tblFederalizacion.CatTipoDeBienId = 2;
                tblFederalizacion.FechaAlta = DateTime.Now;
                tblFederalizacion.Activo = true;
                tblFederalizacion.IdUsuarioAlta =  modeloInventario.idUsuarioAlta;
                tblFederalizacion = _businessEquipoMedico.GuardarTblFederalizacion(tblFederalizacion);


                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 2;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                 objRespuestatblInventarios = _businessEquipoMedico.GuardarTblInventarios(tblInventarios);

                tblProveedor.Proveedor = modeloInventario.Proveedor;
                tblProveedor.CatTipoDeBienId = 2;
                tblProveedor.FechaAlta = DateTime.Now;
                tblProveedor.Activo = true;
                tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblProveedor = _businessEquipoMedico.GuardarTblProveedor(tblProveedor);


                tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                tblClaveCabms.CatTipoDeBienId = 2;
                tblClaveCabms.FechaAlta = DateTime.Now;
                tblClaveCabms.Activo = true;
                tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblClaveCabms = _businessEquipoMedico.GuardarTblClaveCabms(tblClaveCabms);





                tblBienesEquMedico.IdFederalizacionid = tblFederalizacion.Id;
                tblBienesEquMedico.Descripcion = modeloInventario.Descripcion;
                tblBienesEquMedico.IdInventarioid = objRespuestatblInventarios.objGenerics.Id;
                tblBienesEquMedico.Marca = modeloInventario.marca;
                tblBienesEquMedico.Modelo = modeloInventario.modelo;
                tblBienesEquMedico.Serie = modeloInventario.serie;
                tblBienesEquMedico.Cantidad = modeloInventario.cantidad;
                tblBienesEquMedico.Costounitario = modeloInventario.costounitario;
                tblBienesEquMedico.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                tblBienesEquMedico.CatTipoEntradaid = 1;
                tblBienesEquMedico.Catareaid = modeloInventario.IdArea;
                tblBienesEquMedico.Catservicioid = modeloInventario.IdServicio;
                tblBienesEquMedico.CatPisosid = modeloInventario.IdPisos;
                tblBienesEquMedico.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblBienesEquMedico.Observaciones = modeloInventario.observaciones;
                tblBienesEquMedico.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblBienesEquMedico.FechaAlta = DateTime.Now;
                tblBienesEquMedico.IdContratoBienid= tblContratoBien.Id;
                tblBienesEquMedico.IdProveedorid= tblProveedor.Id;
                tblBienesEquMedico.IdFacturasid = tblFacturas.IdFactura;
                tblBienesEquMedico.CatGarantiaid = modeloInventario.IdGarantia;
                tblBienesEquMedico.IdResguardatariosid = modeloInventario.IdResguardatarios;
                tblBienesEquMedico.CatTipoDeBienid = 2;
                tblBienesEquMedico.Activo = true;
                tblBienesEquMedico.IdClaveCabmsid = tblClaveCabms.Id;
                tblBienesEquMedico.IdClaveSaicaid = tblClavesaica.Id;


                if (objRespuestatblInventarios.correcto == false)
                {
                    return BadRequest(new { message = objRespuestatblInventarios.Mensaje });
                }
                else
                {

                    var result = _businessEquipoMedico.GuardarTblEquiMedico(tblBienesEquMedico); //Esta función se debe validar 
                    return Ok(result);
                }              
            }

            catch (AppException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        #endregion

        #region Entradas por Traspaso
        [HttpPost("EntradaporTraspaso")]
        public IActionResult RegistroInventarioportraspaso([FromBody] ModeloInventario modeloInventario)
        {
            if (modeloInventario != null)
            {
           
                TblBienesEquMedico tblBienesEquMedico = new TblBienesEquMedico();
                TblFacturas tblFacturas = new TblFacturas();
                TblClaveSaica tblClavesaica = new TblClaveSaica();
                TblContratoBien tblContratoBien = new TblContratoBien();
                TblFederalizacion tblFederalizacion = new TblFederalizacion();
                TblInventarios tblInventarios = new TblInventarios();
                TblProveedor tblProveedor = new TblProveedor();
                TblClaveCabms tblClaveCabms = new TblClaveCabms();

                tblFacturas.Factura = modeloInventario.factura;
                tblFacturas.CatTipoDeBienId = 2;
                tblFacturas.FechaAlta = DateTime.Now;
                tblFacturas.Activo = true;
                tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblFacturas = _businessEquipoMedico.GuardarFacturaInventarioEquipoMedico(tblFacturas);



                tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                tblClavesaica.CatTipoDeBienId = 2;
                tblClavesaica.Activo = true;
                tblClavesaica.FechaAlta = DateTime.Now;
                tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblClavesaica = _businessEquipoMedico.GuardarTblClaveSaica(tblClavesaica);



                tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                tblContratoBien.CatTipoDeBienId = 2;
                tblContratoBien.FechaAlta = DateTime.Now;
                tblContratoBien.Activo = true;
                tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblContratoBien = _businessEquipoMedico.GuardarTblContratoBien(tblContratoBien);


                tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                tblFederalizacion.CatTipoDeBienId = 2;
                tblFederalizacion.FechaAlta = DateTime.Now;
                tblFederalizacion.Activo = true;
                tblFederalizacion.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblFederalizacion = _businessEquipoMedico.GuardarTblFederalizacion(tblFederalizacion);


                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 2;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                objRespuestatblInventarios = _businessEquipoMedico.GuardarTblInventarios(tblInventarios);

                tblProveedor.Proveedor = modeloInventario.Proveedor;
                tblProveedor.CatTipoDeBienId = 2;
                tblProveedor.FechaAlta = DateTime.Now;
                tblProveedor.Activo = true;
                tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblProveedor = _businessEquipoMedico.GuardarTblProveedor(tblProveedor);


                tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                tblClaveCabms.CatTipoDeBienId = 2;
                tblClaveCabms.FechaAlta = DateTime.Now;
                tblClaveCabms.Activo = true;
                tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblClaveCabms = _businessEquipoMedico.GuardarTblClaveCabms(tblClaveCabms);

                tblBienesEquMedico.IdFederalizacionid = tblFederalizacion.Id;
                tblBienesEquMedico.Descripcion = modeloInventario.Descripcion;
                tblBienesEquMedico.IdInventarioid = objRespuestatblInventarios.objGenerics.Id;
                tblBienesEquMedico.Marca = modeloInventario.marca;
                tblBienesEquMedico.Modelo = modeloInventario.modelo;
                tblBienesEquMedico.Serie = modeloInventario.serie;
                tblBienesEquMedico.Cantidad = modeloInventario.cantidad;
                tblBienesEquMedico.Costounitario = modeloInventario.costounitario;
                tblBienesEquMedico.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                tblBienesEquMedico.CatTipoEntradaid = 2;
                tblBienesEquMedico.CatPisosid = modeloInventario.IdPisos;
                tblBienesEquMedico.Catareaid = modeloInventario.IdArea;
                tblBienesEquMedico.Catservicioid = modeloInventario.IdServicio;
                tblBienesEquMedico.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblBienesEquMedico.Observaciones = modeloInventario.observaciones;
                tblBienesEquMedico.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblBienesEquMedico.FechaAlta = DateTime.Now;
                ///Es un dato que puede ir o no
                tblBienesEquMedico.IdContratoBienid = tblContratoBien.Id;
                ///Es un dato que puede ir o no
                tblBienesEquMedico.IdProveedorid = tblProveedor.Id;
                ///Es un dato que puede ir o no
                tblBienesEquMedico.IdFacturasid = tblFacturas.IdFactura;
                tblBienesEquMedico.IdResguardatariosid = modeloInventario.IdResguardatarios;
                                                    tblBienesEquMedico.CatTipoDeBienid = 2;
                tblBienesEquMedico.Activo = true;
                tblBienesEquMedico.IdClaveCabmsid = tblClaveCabms.Id;
                tblBienesEquMedico.IdClaveSaicaid = tblClavesaica.Id;
                _businessEquipoMedico.GuardarTblEquiMedico(tblBienesEquMedico);



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

                TblBienesEquMedico tblBienesEquMedico = new TblBienesEquMedico();

                TblInventarios tblInventarios = new TblInventarios();

                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 2;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                objRespuestatblInventarios = _businessEquipoMedico.GuardarTblInventarios(tblInventarios);





                tblBienesEquMedico.Descripcion = modeloInventario.Descripcion;
                ///<summary>
                ///Este tipo de entrada lleva un numero de inventario interno
                ///</summary>
                tblBienesEquMedico.IdInventarioid = objRespuestatblInventarios.objGenerics.Id;
                tblBienesEquMedico.Marca = modeloInventario.marca;
                tblBienesEquMedico.Modelo = modeloInventario.modelo;
                tblBienesEquMedico.Serie = modeloInventario.serie;
                tblBienesEquMedico.Cantidad = modeloInventario.cantidad;
                tblBienesEquMedico.CatTipoEntradaid = 3;
                tblBienesEquMedico.CatPisosid = modeloInventario.IdPisos;
                tblBienesEquMedico.Catareaid = modeloInventario.IdArea;
                tblBienesEquMedico.Catservicioid = modeloInventario.IdServicio;
                tblBienesEquMedico.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblBienesEquMedico.Observaciones = modeloInventario.observaciones;
                tblBienesEquMedico.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblBienesEquMedico.FechaAlta = DateTime.Now;
                tblBienesEquMedico.IdResguardatariosid = modeloInventario.IdResguardatarios;
                tblBienesEquMedico.CatTipoDeBienid = 2;
                tblBienesEquMedico.Activo = true;
                _businessEquipoMedico.GuardarTblEquiMedico(tblBienesEquMedico);



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

                TblBienesEquMedico tblBienesEquMedico = new TblBienesEquMedico();
                TblFacturas tblFacturas = new TblFacturas();
                TblClaveSaica tblClavesaica = new TblClaveSaica();
                TblContratoBien tblContratoBien = new TblContratoBien();
                TblFederalizacion tblFederalizacion = new TblFederalizacion();
                TblInventarios tblInventarios = new TblInventarios();
                TblProveedor tblProveedor = new TblProveedor();
                TblClaveCabms tblClaveCabms = new TblClaveCabms();


                tblFacturas.Factura = modeloInventario.factura;
                tblFacturas.CatTipoDeBienId = 2;
                tblFacturas.FechaAlta = DateTime.Now;
                tblFacturas.Activo = true;
                tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblFacturas = _businessEquipoMedico.GuardarFacturaInventarioEquipoMedico(tblFacturas);



                tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                tblClavesaica.CatTipoDeBienId = 2;
                tblClavesaica.Activo = true;
                tblClavesaica.FechaAlta = DateTime.Now;
                tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblClavesaica = _businessEquipoMedico.GuardarTblClaveSaica(tblClavesaica);



                tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                tblContratoBien.CatTipoDeBienId = 2;
                tblContratoBien.FechaAlta = DateTime.Now;
                tblContratoBien.Activo = true;
                tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblContratoBien = _businessEquipoMedico.GuardarTblContratoBien(tblContratoBien);
                tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                tblFederalizacion.CatTipoDeBienId = 2;
                tblFederalizacion.FechaAlta = DateTime.Now;
                tblFederalizacion.Activo = true;
                tblFederalizacion.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblFederalizacion = _businessEquipoMedico.GuardarTblFederalizacion(tblFederalizacion);


                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 2;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                objRespuestatblInventarios = _businessEquipoMedico.GuardarTblInventarios(tblInventarios);

                tblProveedor.Proveedor = modeloInventario.Proveedor;
                tblProveedor.CatTipoDeBienId = 2;
                tblProveedor.FechaAlta = DateTime.Now;
                tblProveedor.Activo = true;
                tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblProveedor = _businessEquipoMedico.GuardarTblProveedor(tblProveedor);


                tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                tblClaveCabms.CatTipoDeBienId = 2;
                tblClaveCabms.FechaAlta = DateTime.Now;
                tblClaveCabms.Activo = true;
                tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblClaveCabms = _businessEquipoMedico.GuardarTblClaveCabms(tblClaveCabms);

                tblBienesEquMedico.IdFederalizacionid = tblFederalizacion.Id;
                tblBienesEquMedico.Descripcion = modeloInventario.Descripcion;
                tblBienesEquMedico.IdInventarioid = objRespuestatblInventarios.objGenerics.Id;
                tblBienesEquMedico.Marca = modeloInventario.marca;
                tblBienesEquMedico.Modelo = modeloInventario.modelo;
                tblBienesEquMedico.Serie = modeloInventario.serie;
                tblBienesEquMedico.Cantidad = modeloInventario.cantidad;
                tblBienesEquMedico.Costounitario = modeloInventario.costounitario;
                tblBienesEquMedico.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                tblBienesEquMedico.CatTipoEntradaid = 4;
                tblBienesEquMedico.CatPisosid = modeloInventario.IdPisos;
                tblBienesEquMedico.Catareaid = modeloInventario.IdArea;
                tblBienesEquMedico.Catservicioid = modeloInventario.IdServicio;
                tblBienesEquMedico.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblBienesEquMedico.Observaciones = modeloInventario.observaciones;
                tblBienesEquMedico.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblBienesEquMedico.FechaAlta = DateTime.Now;
                tblBienesEquMedico.IdFacturasid = tblFacturas.IdFactura;
                tblBienesEquMedico.IdResguardatariosid = modeloInventario.IdResguardatarios;
                tblBienesEquMedico.CatTipoDeBienid = 2;
                tblBienesEquMedico.Activo = true;
                tblBienesEquMedico.IdClaveCabmsid = tblClaveCabms.Id;
                tblBienesEquMedico.IdClaveSaicaid = tblClavesaica.Id;
                _businessEquipoMedico.GuardarTblEquiMedico(tblBienesEquMedico);



            }


            return Ok();
        }
        #endregion




    }
}
