﻿using System;
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



        [HttpPost("RegistroInventario")]
        public IActionResult RegistroInventario([FromBody] ModeloInventario modeloInventario)
        {
            if (modeloInventario != null)
            {

                TblBienesEquMedico tblBienesEquMedico = new TblBienesEquMedico();
                TblFacturas tblFacturas = new TblFacturas();
                TblClaveSaica tblClaveSaica = new TblClaveSaica();
                TblContratoBien tblContratoBien = new TblContratoBien();
                TblFederalizacion tblFederalizacion = new TblFederalizacion();
                TblInventarios tblInventarios = new TblInventarios();
                TblProveedor tblProveedor = new TblProveedor();
                TblClaveCabms tblClaveCabms = new TblClaveCabms();
                ///
                ///Por  el momento como ejemplo
                ///



                tblFacturas.factura = modeloInventario.factura;
                tblFacturas.subtotal = modeloInventario.subtotal;
                tblFacturas.IVA = modeloInventario.iva;
                tblFacturas.costoTotal = modeloInventario.total;
                tblFacturas.CatTipoDeBien.id = 2;
                tblFacturas.fechaAlta = DateTime.Now;
                tblFacturas.activo = true;
                tblFacturas.idUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblFacturas = _businessEquipoMedico.GuardarFacturaInventarioEquipoMedico(tblFacturas);



                tblClaveSaica.clavesaica = modeloInventario.ClaveSaica;
                tblClaveSaica.CatTipoDeBien.id = 2;
                tblClaveSaica.activo = true;
                tblClaveSaica.fechaAlta = DateTime.Now;
                tblClaveSaica.idUsuarioAlta = modeloInventario.idUsuarioAlta;

                tblClaveSaica = _businessEquipoMedico.GuardarTblClaveSaica(tblClaveSaica);



                tblContratoBien.contratobien = modeloInventario.ContratoBien;
                tblContratoBien.CatTipoDeBien.id = 2;
                tblContratoBien.fechaAlta = DateTime.Now;
                tblContratoBien.activo = true;
                tblContratoBien.idUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblContratoBien = _businessEquipoMedico.GuardarTblContratoBien(tblContratoBien);


                tblFederalizacion.federalizacion = modeloInventario.Federalizacion;
                tblFederalizacion.CatTipoDeBien.id = 2;
                tblFederalizacion.fechaAlta = DateTime.Now;
                tblFederalizacion.activo = true;
                tblFederalizacion.idUsuarioAlta =  modeloInventario.idUsuarioAlta;
                tblFederalizacion = _businessEquipoMedico.GuardarTblFederalizacion(tblFederalizacion);


                tblInventarios.NumeroInventario = modeloInventario.Inventarios;
                tblInventarios.CatTipoDeBien.id = 2;
                tblInventarios.fechaAlta = DateTime.Now;
                tblInventarios.activo = true;
                tblInventarios.idUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblInventarios = _businessEquipoMedico.GuardarTblInventarios(tblInventarios);

                tblProveedor.proveedor = modeloInventario.Proveedor;
                tblProveedor.CatTipoDeBien.id = 2;
                tblProveedor.fechaAlta = DateTime.Now;
                tblProveedor.activo = true;
                tblProveedor.idUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblProveedor = _businessEquipoMedico.GuardarTblProveedor(tblProveedor);


                tblClaveCabms.clavecambs = modeloInventario.ClaveCabms;
                tblClaveCabms.CatTipoDeBien.id = 2;
                tblClaveCabms.fechaAlta = DateTime.Now;
                tblClaveCabms.activo = true;
                tblClaveCabms.idUsuarioAlta = modeloInventario.idUsuarioAlta;
                tblClaveCabms = _businessEquipoMedico.GuardarTblClaveCabms(tblClaveCabms);





                tblBienesEquMedico.IdFederalizacion.id = tblFederalizacion.id;
                tblBienesEquMedico.IdInventario.id = tblInventarios.id;
                tblBienesEquMedico.marca = modeloInventario.marca;
                tblBienesEquMedico.modelo = modeloInventario.modelo;
                tblBienesEquMedico.serie = modeloInventario.serie;
                tblBienesEquMedico.IdContratoBien.id = tblContratoBien.id;
                tblBienesEquMedico.IdProveedor.id = tblProveedor.id;
                tblBienesEquMedico.IdFacturas.id = tblFacturas.id;
                tblBienesEquMedico.catGarantia.id = modeloInventario.IdGarantia;
                tblBienesEquMedico.catTipoDeBienes.id = 2;
                tblBienesEquMedico.cantidad = modeloInventario.cantidad;
                tblBienesEquMedico.activo = true;
    

                tblBienesEquMedico.IdClaveSaica.id = tblClaveSaica.id;
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
