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
                ///
                ///Por  el momento como ejemplo
                ///
                tblFacturas.IVA = modeloInventario.iva;
                tblFacturas.subtotal = modeloInventario.subtotal;
                //...
                //...
                //Etc..
                //etc..

                tblFacturas.fechaAlta = DateTime.Now;
                tblFacturas.idUsuarioAlta = modeloInventario.idUsuarioAlta;



                tblFacturas = _businessEquipoMedico.GuardarFacturaInventarioEquipoMedico(tblFacturas);
               
                
                
                
                tblBienesEquMedico.catTipoDeBienes.id = 2;



                tblBienesEquMedico.cantidad = modeloInventario.cantidad;
                tblBienesEquMedico.activo = true;
                tblBienesEquMedico.marca = modeloInventario.marca;


                tblBienesEquMedico.IdFacturas.id = tblFacturas.id;
                _inventarioService.GuardarTblBienes(tblBienesEquMedico);

                ///
                //..
                //...
                //..
                tblFacturas.subtotal = modeloInventario.subtotal;
                tblFacturas.IVA = modeloInventario.iva;

                ///Digamos que ya terminaste de mapear todos  los campos de FACTURAS
                ///

           
            }


            return Ok();
        }

    }
}
