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
    public class InventarioInstrumentalMedicoController : ControllerBase
    {

        BusinessInventarioInstrumentalMedico _businessInstrumeental;
        public InventarioInstrumentalMedicoController(BusinessInventarioInstrumentalMedico objInstrumental)
        {
            _businessInstrumeental = objInstrumental;
        }
        #region Consultas metodo get

        [HttpGet("ObtenerInventarioInstrumental")]
        public IActionResult GetTblInstrumentalMedico()
        {
            var result = _businessInstrumeental.GetInstrumental();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorFederalizacion")]
        public IActionResult GetConsultaPorFederalizacion()
        {
            var result = _businessInstrumeental.GetConsultaFederalizacion();
            return Ok(result);
        }
        [HttpGet("ObtenerInventarioPorCabms")]
        public IActionResult GettblInstrumentalMedicoCabms()
        {
            var result = _businessInstrumeental.GetConcultaCabms();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorInventario")]
        public IActionResult GetEquipoMedicoPorInventario()
        {
            var result = _businessInstrumeental.GetConsultaInventario();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorProvedor")]
        public IActionResult GetConsulataEquipoMedicoProveedor()
        {
            var result = _businessInstrumeental.GetConsulataProveedor();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorFactura")]
        public IActionResult GetComsultafactura()
        {
            var result = _businessInstrumeental.GetConcultaPorFactura();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorClaveSaica")]
        public IActionResult GetConsultaporsaica()
        {
            var result = _businessInstrumeental.GetConsultaClaveSaica();
            return Ok(result);
        }
        [HttpGet]
        [Route("obtenerfactura/{idBieninstrumental}")]
        public IActionResult GetFacturasTipoInventario(int idBieninstrumental)
        {
            var result = _businessInstrumeental.GetFacturasTipoInventario(idBieninstrumental);
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorContrato")]
        public IActionResult GetConsultaporcontrato()
        {
            var result = _businessInstrumeental.GetConsultaContrato();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorResguardatario")]
        public IActionResult GetConsultaporresguardatario()
        {
            var result = _businessInstrumeental.GetConsultarResguardatario();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorEstadoFisico")]
        public IActionResult GetConsultaporestadofisico()
        {
            var result = _businessInstrumeental.GetConsultaEstadoFisicoBien();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorGarantia")]
        public IActionResult GetConsultaporgarantia()
        {
            var result = _businessInstrumeental.GetConsultaporGarantia();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorPiso")]
        public IActionResult GetConsultaporpiso()
        {
            var result = _businessInstrumeental.GetConsultaPorPiso();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorTipoDeEntrada")]
        public IActionResult GetConsultaportipodeentrada()
        {
            var result = _businessInstrumeental.GetConsultaporTipodeEntrada();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorPartida")]
        public IActionResult GetConsultaporpartida()
        {
            var result = _businessInstrumeental.GetConsultaporTipodePartida();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorServicio")]
        public IActionResult GetConsultaporservicio()
        {
            var result = _businessInstrumeental.GetConsultaporservicio();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorArea")]
        public IActionResult GetConsultaporArea()
        {
            var result = _businessInstrumeental.GetConsultaporArea();
            return Ok(result);
        }
        [HttpGet("ObtenerEquipoMedicoPorCostoUnitario")]
        public IActionResult GetConsultaporcosto()
        {
            var result = _businessInstrumeental.GetConsultaPorPrecioUnitario();
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

                TblInstrumentalMedico tblInstrumentalMedico = new TblInstrumentalMedico();
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
                tblFacturas.CatTipoDeBienId = 3;
                tblFacturas.FechaAlta = DateTime.Now;
                tblFacturas.Activo = true;
                tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblFacturas = _businessInstrumeental.GuardarFacturaInventarioEquipoMedico(tblFacturas);



                tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                tblClavesaica.CatTipoDeBienId = 3;
                tblClavesaica.Activo = true;
                tblClavesaica.FechaAlta = DateTime.Now;
                tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblClavesaica = _businessInstrumeental.GuardarTblClaveSaica(tblClavesaica);



                tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                tblContratoBien.CatTipoDeBienId = 3;
                tblContratoBien.FechaAlta = DateTime.Now;
                tblContratoBien.Activo = true;
                tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblContratoBien = _businessInstrumeental.GuardarTblContratoBien(tblContratoBien);


                tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                tblFederalizacion.CatTipoDeBienId = 3;
                tblFederalizacion.FechaAlta = DateTime.Now;
                tblFederalizacion.Activo = true;
                tblFederalizacion.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblFederalizacion = _businessInstrumeental.GuardarTblFederalizacion(tblFederalizacion);


                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 3;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInventarios = _businessInstrumeental.GuardarTblInventarios(tblInventarios);

                tblProveedor.Proveedor = modeloInventario.Proveedor;
                tblProveedor.CatTipoDeBienId = 3;
                tblProveedor.FechaAlta = DateTime.Now;
                tblProveedor.Activo = true;
                tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblProveedor = _businessInstrumeental.GuardarTblProveedor(tblProveedor);


                tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                tblClaveCabms.CatTipoDeBienId = 3;
                tblClaveCabms.FechaAlta = DateTime.Now;
                tblClaveCabms.Activo = true;
                tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblClaveCabms = _businessInstrumeental.GuardarTblClaveCabms(tblClaveCabms);





                tblInstrumentalMedico.IdFederalizacionid = tblFederalizacion.Id;
                tblInstrumentalMedico.Descripcion = modeloInventario.Descripcion;
                tblInstrumentalMedico.IdInventarioid = tblInventarios.Id;
                tblInstrumentalMedico.Marca = modeloInventario.marca;
                tblInstrumentalMedico.Modelo = modeloInventario.modelo;
                tblInstrumentalMedico.Serie = modeloInventario.serie;
                tblInstrumentalMedico.Cantidad = modeloInventario.cantidad;
                tblInstrumentalMedico.Costounitario = modeloInventario.costounitario;
                tblInstrumentalMedico.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                tblInstrumentalMedico.CatTipoEntradaid = 1;
                tblInstrumentalMedico.Catareaid = modeloInventario.IdArea;
                tblInstrumentalMedico.Catservicioid = modeloInventario.IdServicio;
                tblInstrumentalMedico.CatPisosid = modeloInventario.IdPisos;
                tblInstrumentalMedico.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblInstrumentalMedico.Observaciones = modeloInventario.observaciones;
                tblInstrumentalMedico.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInstrumentalMedico.FechaAlta = DateTime.Now;
                tblInstrumentalMedico.IdContratoBienid = tblContratoBien.Id;
                tblInstrumentalMedico.IdProveedorid = tblProveedor.Id;
                tblInstrumentalMedico.IdFacturasid = tblFacturas.IdFactura;
                tblInstrumentalMedico.CatGarantiaid = modeloInventario.IdGarantia;
                tblInstrumentalMedico.IdResguardatariosid = modeloInventario.IdResguardatarios;
                tblInstrumentalMedico.CatTipoDeBienid = 3;
                tblInstrumentalMedico.Activo = true;
                tblInstrumentalMedico.IdClaveCabmsid = tblClaveCabms.Id;
                tblInstrumentalMedico.IdClaveSaicaid = tblClavesaica.Id;
                _businessInstrumeental.GuardarTblInstrumentalMedico(tblInstrumentalMedico);

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

                TblInstrumentalMedico tblInstrumentalMedico = new TblInstrumentalMedico();
                TblFacturas tblFacturas = new TblFacturas();
                TblClaveSaica tblClavesaica = new TblClaveSaica();
                TblContratoBien tblContratoBien = new TblContratoBien();
                TblFederalizacion tblFederalizacion = new TblFederalizacion();
                TblInventarios tblInventarios = new TblInventarios();
                TblProveedor tblProveedor = new TblProveedor();
                TblClaveCabms tblClaveCabms = new TblClaveCabms();

                tblFacturas.Factura = modeloInventario.factura;
                tblFacturas.CatTipoDeBienId = 3;
                tblFacturas.FechaAlta = DateTime.Now;
                tblFacturas.Activo = true;
                tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblFacturas = _businessInstrumeental.GuardarFacturaInventarioEquipoMedico(tblFacturas);



                tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                tblClavesaica.CatTipoDeBienId = 3;
                tblClavesaica.Activo = true;
                tblClavesaica.FechaAlta = DateTime.Now;
                tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblClavesaica = _businessInstrumeental.GuardarTblClaveSaica(tblClavesaica);



                tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                tblContratoBien.CatTipoDeBienId = 3;
                tblContratoBien.FechaAlta = DateTime.Now;
                tblContratoBien.Activo = true;
                tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblContratoBien = _businessInstrumeental.GuardarTblContratoBien(tblContratoBien);


                tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                tblFederalizacion.CatTipoDeBienId = 3;
                tblFederalizacion.FechaAlta = DateTime.Now;
                tblFederalizacion.Activo = true;
                tblFederalizacion.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblFederalizacion = _businessInstrumeental.GuardarTblFederalizacion(tblFederalizacion);


                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 3;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInventarios = _businessInstrumeental.GuardarTblInventarios(tblInventarios);

                tblProveedor.Proveedor = modeloInventario.Proveedor;
                tblProveedor.CatTipoDeBienId = 3;
                tblProveedor.FechaAlta = DateTime.Now;
                tblProveedor.Activo = true;
                tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblProveedor = _businessInstrumeental.GuardarTblProveedor(tblProveedor);


                tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                tblClaveCabms.CatTipoDeBienId = 3;
                tblClaveCabms.FechaAlta = DateTime.Now;
                tblClaveCabms.Activo = true;
                tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblClaveCabms = _businessInstrumeental.GuardarTblClaveCabms(tblClaveCabms);

                tblInstrumentalMedico.IdFederalizacionid = tblFederalizacion.Id;
                tblInstrumentalMedico.Descripcion = modeloInventario.Descripcion;
                tblInstrumentalMedico.IdInventarioid = tblInventarios.Id;
                tblInstrumentalMedico.Marca = modeloInventario.marca;
                tblInstrumentalMedico.Modelo = modeloInventario.modelo;
                tblInstrumentalMedico.Serie = modeloInventario.serie;
                tblInstrumentalMedico.Cantidad = modeloInventario.cantidad;
                tblInstrumentalMedico.Costounitario = modeloInventario.costounitario;
                tblInstrumentalMedico.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                tblInstrumentalMedico.CatTipoEntradaid = 2;
                tblInstrumentalMedico.CatPisosid = modeloInventario.IdPisos;
                tblInstrumentalMedico.Catareaid = modeloInventario.IdArea;
                tblInstrumentalMedico.Catservicioid = modeloInventario.IdServicio;
                tblInstrumentalMedico.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblInstrumentalMedico.Observaciones = modeloInventario.observaciones;
                tblInstrumentalMedico.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInstrumentalMedico.FechaAlta = DateTime.Now;
                ///Es un dato que puede ir o no
                tblInstrumentalMedico.IdContratoBienid = tblContratoBien.Id;
                ///Es un dato que puede ir o no
                tblInstrumentalMedico.IdProveedorid = tblProveedor.Id;
                ///Es un dato que puede ir o no
                tblInstrumentalMedico.IdFacturasid = tblFacturas.IdFactura;
                tblInstrumentalMedico.IdResguardatariosid = modeloInventario.IdResguardatarios;
                tblInstrumentalMedico.CatTipoDeBienid = 3;
                tblInstrumentalMedico.Activo = true;
                tblInstrumentalMedico.IdClaveCabmsid = tblClaveCabms.Id;
                tblInstrumentalMedico.IdClaveSaicaid = tblClavesaica.Id;
                _businessInstrumeental.GuardarTblInstrumentalMedico(tblInstrumentalMedico);



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

                TblInstrumentalMedico tblInstrumentalMedico = new TblInstrumentalMedico();

                TblInventarios tblInventarios = new TblInventarios();

                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 3;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInventarios = _businessInstrumeental.GuardarTblInventarios(tblInventarios);





                tblInstrumentalMedico.Descripcion = modeloInventario.Descripcion;
                ///<summary>
                ///Este tipo de entrada lleva un numero de inventario interno
                ///</summary>
                tblInstrumentalMedico.IdInventarioid = tblInventarios.Id;
                tblInstrumentalMedico.Marca = modeloInventario.marca;
                tblInstrumentalMedico.Modelo = modeloInventario.modelo;
                tblInstrumentalMedico.Serie = modeloInventario.serie;
                tblInstrumentalMedico.Cantidad = modeloInventario.cantidad;
                tblInstrumentalMedico.CatTipoEntradaid = 3;
                tblInstrumentalMedico.CatPisosid = modeloInventario.IdPisos;
                tblInstrumentalMedico.Catareaid = modeloInventario.IdArea;
                tblInstrumentalMedico.Catservicioid = modeloInventario.IdServicio;
                tblInstrumentalMedico.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblInstrumentalMedico.Observaciones = modeloInventario.observaciones;
                tblInstrumentalMedico.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInstrumentalMedico.FechaAlta = DateTime.Now;
                tblInstrumentalMedico.IdResguardatariosid = modeloInventario.IdResguardatarios;
                tblInstrumentalMedico.CatTipoDeBienid = 3;
                tblInstrumentalMedico.Activo = true;
                _businessInstrumeental.GuardarTblInstrumentalMedico(tblInstrumentalMedico);



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
            

                TblInstrumentalMedico tblInstrumentalMedico = new TblInstrumentalMedico();
                TblFacturas tblFacturas = new TblFacturas();
                TblClaveSaica tblClavesaica = new TblClaveSaica();
                TblContratoBien tblContratoBien = new TblContratoBien();
                TblFederalizacion tblFederalizacion = new TblFederalizacion();
                TblInventarios tblInventarios = new TblInventarios();
                TblProveedor tblProveedor = new TblProveedor();
                TblClaveCabms tblClaveCabms = new TblClaveCabms();


                tblFacturas.Factura = modeloInventario.factura;
                tblFacturas.CatTipoDeBienId = 3;
                tblFacturas.FechaAlta = DateTime.Now;
                tblFacturas.Activo = true;
                tblFacturas.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblFacturas = _businessInstrumeental.GuardarFacturaInventarioEquipoMedico(tblFacturas);



                tblClavesaica.Clavesaica = modeloInventario.ClaveSaica;
                tblClavesaica.CatTipoDeBienId = 2;
                tblClavesaica.Activo = true;
                tblClavesaica.FechaAlta = DateTime.Now;
                tblClavesaica.IdUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblClavesaica = _businessInstrumeental.GuardarTblClaveSaica(tblClavesaica);



                tblContratoBien.Contratobien = modeloInventario.ContratoBien;
                tblContratoBien.CatTipoDeBienId = 3;
                tblContratoBien.FechaAlta = DateTime.Now;
                tblContratoBien.Activo = true;
                tblContratoBien.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblContratoBien = _businessInstrumeental.GuardarTblContratoBien(tblContratoBien);
                tblFederalizacion.Federalizacion = modeloInventario.Federalizacion;
                tblFederalizacion.CatTipoDeBienId = 3;
                tblFederalizacion.FechaAlta = DateTime.Now;
                tblFederalizacion.Activo = true;
                tblFederalizacion.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblFederalizacion = _businessInstrumeental.GuardarTblFederalizacion(tblFederalizacion);


                tblInventarios.NumeroInventario = modeloInventario.Inventario;
                tblInventarios.CatTipoDeBienId = 3;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInventarios = _businessInstrumeental.GuardarTblInventarios(tblInventarios);

                tblProveedor.Proveedor = modeloInventario.Proveedor;
                tblProveedor.CatTipoDeBienId = 3;
                tblProveedor.FechaAlta = DateTime.Now;
                tblProveedor.Activo = true;
                tblProveedor.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblProveedor = _businessInstrumeental.GuardarTblProveedor(tblProveedor);


                tblClaveCabms.Clavecambs = modeloInventario.ClaveCabms;
                tblClaveCabms.CatTipoDeBienId = 3;
                tblClaveCabms.FechaAlta = DateTime.Now;
                tblClaveCabms.Activo = true;
                tblClaveCabms.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblClaveCabms = _businessInstrumeental.GuardarTblClaveCabms(tblClaveCabms);

                tblInstrumentalMedico.IdFederalizacionid = tblFederalizacion.Id;
                tblInstrumentalMedico.Descripcion = modeloInventario.Descripcion;
                tblInstrumentalMedico.IdInventarioid = tblInventarios.Id;
                tblInstrumentalMedico.Marca = modeloInventario.marca;
                tblInstrumentalMedico.Modelo = modeloInventario.modelo;
                tblInstrumentalMedico.Serie = modeloInventario.serie;
                tblInstrumentalMedico.Cantidad = modeloInventario.cantidad;
                tblInstrumentalMedico.Costounitario = modeloInventario.costounitario;
                tblInstrumentalMedico.CatTipoPartidaid = modeloInventario.IdTipoPartida;
                tblInstrumentalMedico.CatTipoEntradaid = 4;
                tblInstrumentalMedico.CatPisosid = modeloInventario.IdPisos;
                tblInstrumentalMedico.Catareaid = modeloInventario.IdArea;
                tblInstrumentalMedico.Catservicioid = modeloInventario.IdServicio;
                tblInstrumentalMedico.CatEstadoDelBienid = modeloInventario.IdEstadodelBien;
                tblInstrumentalMedico.Observaciones = modeloInventario.observaciones;
                tblInstrumentalMedico.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInstrumentalMedico.FechaAlta = DateTime.Now;
                tblInstrumentalMedico.IdFacturasid = tblFacturas.IdFactura;
                tblInstrumentalMedico.IdResguardatariosid = modeloInventario.IdResguardatarios;
                tblInstrumentalMedico.CatTipoDeBienid = 3;
                tblInstrumentalMedico.Activo = true;
                tblInstrumentalMedico.IdClaveCabmsid = tblClaveCabms.Id;
                tblInstrumentalMedico.IdClaveSaicaid = tblClavesaica.Id;
                var result =_businessInstrumeental.GuardarTblInstrumentalMedico(tblInstrumentalMedico);



            


            return Ok(result);
        }
        #endregion




    }
}
