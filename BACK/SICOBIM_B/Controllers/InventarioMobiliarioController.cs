using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SICOBIM_B.Business;
using SICOBIM_B.Services;

namespace SICOBIM_B.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class InventarioMobiliarioController : ControllerBase
    {

        BusinessInventarioMobiliario _businessInventarioMobiliario;
        private IInventarioService _inventarioService;

        public InventarioMobiliarioController(IInventarioService objMobilirio, BusinessInventarioMobiliario objInventarioMobiliario)

        {
            _inventarioService = objMobilirio;
            _businessInventarioMobiliario = objInventarioMobiliario;
        }


        [HttpGet("GetTblBienes")]
        public IActionResult GetTblBienes()
        {
            var result = _inventarioService.GetTblBienes();
            return Ok(result);
        }
        [HttpGet("GetCatEstadoDelBien")]
        public IActionResult GetCatEstadoDelBien()
        {
            var result = _inventarioService.GetCatEstadoDelBien();
            return Ok(result);
        }
        [HttpGet("GetCatGarantia")]
        public IActionResult GetCatGarantia()
        {
            var result = _inventarioService.GetCatGarantia();
            return Ok(result);
        }
        [HttpGet("GetCatPisos")]
        public IActionResult GetCatPisos()
        {
            var result = _inventarioService.GetCatPisos();
            return Ok(result);
        }
        [HttpGet("GetCatTipoEntrada")]
        public IActionResult GetCatTipoEntrada()
        {
            var result = _inventarioService.GetCatTipoEntrada();
            return Ok(result);
        }
        [HttpGet("GetCatTipoPartida")]
        public IActionResult GetCatTipoPartida()
        {
            var result = _inventarioService.GetCatTipoPartida();
            return Ok(result);
        }
        [HttpGet("GetCatTipoDeBien")]
        public IActionResult GetCatTipoDeBien()
        {
            var result = _inventarioService.GetCatTipoDeBien();
            return Ok(result);
        }
        [HttpGet("GetCatTipoSalida")]
        public IActionResult GetCatTipoSalida()
        {
            var result = _inventarioService.GetCatTipoSalida();
            return Ok(result);
        }
        [HttpGet("GetCatUnidadDestino")]
        public IActionResult GetCatUnidadDestino()
        {
            var result = _inventarioService.GetCatUnidadDestino();
            return Ok(result);
        }




















    }
}
