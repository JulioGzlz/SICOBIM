using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SICOBIM_B.Business;
using SICOBIM_B.Entities;
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
        private IInventarioService _inventarioService;


        public InventarioEquipoMedicoController(BusinessInventarioEquipoMedico objEquipoMedico, IInventarioService inventarioService)
        {
            _businessEquipoMedico = objEquipoMedico;
            _inventarioService = inventarioService;

        }


        [HttpGet("ObtenerInventarioEquipoMedico")]
        public IActionResult GetTblBienesEquMedico()
        {
            var result = _businessEquipoMedico.GetEquipoMedico();
            return Ok(result);
        }
        [HttpGet("ObtenerInventarioPorFederalizacion")]
        public IActionResult GetTblBienesEquMedicoFederalizacion()
        {
            var result = _businessEquipoMedico.GetConsultaFederalizacion();
            return Ok(result);
        }


        /// <summary>
        /// Función POST que define la entrada  por Adquisición, anexa todos los objetos que trabajan con esta entrada
        /// </summary>
        /// <param name="modeloInventario"></param>
        /// <returns></returns>
        [HttpPost("EntradaporAdquisicion")]
        public IActionResult RegistroInventario([FromBody] ModeloInventario modeloInventario)
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
                ///
                ///Por  el momento como ejemplo
                ///



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


                tblInventarios.NumeroInventario = modeloInventario.Inventarios;
                tblInventarios.CatTipoDeBienId = 2;
                tblInventarios.FechaAlta = DateTime.Now;
                tblInventarios.Activo = true;
                tblInventarios.IdUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInventarios = _businessEquipoMedico.GuardarTblInventarios(tblInventarios);

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
                tblBienesEquMedico.IdInventarioid = tblInventarios.Id;
                tblBienesEquMedico.Marca = modeloInventario.marca;
                tblBienesEquMedico.Modelo = modeloInventario.modelo;
                tblBienesEquMedico.Serie = modeloInventario.serie;
                tblBienesEquMedico.IdContratoBienid= tblContratoBien.Id;
                tblBienesEquMedico.IdProveedorid= tblProveedor.Id;
                //tblBienesEquMedico.TblFacturas = tblFacturas.Factura;
                //tblBienesEquMedico.catGarantia.id = modeloInventario.IdGarantia;
                tblBienesEquMedico.CatTipoDeBienesCatTipoDeBienId = 2;
                tblBienesEquMedico.Cantidad = modeloInventario.cantidad;
                tblBienesEquMedico.Activo = true;
                tblBienesEquMedico.IdClaveCabmsid = tblClaveCabms.Id;
                tblBienesEquMedico.IdClaveSaicaid = tblClavesaica.Id;
                _businessEquipoMedico.GuardarTblEquiMedico(tblBienesEquMedico);

                ///
                //..
                //...
                //..
 

                ///Digamos que ya terminaste de mapear todos  los campos de FACTURAS
                ///

           
            }


            return Ok();
        }





    }
}
