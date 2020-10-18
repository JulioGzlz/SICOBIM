using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SICOBIM_B.Business;
using SICOBIM_B.Helpers;
using SICOBIM_B.Services;

namespace SICOBIM_B.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatPerfilController : ControllerBase
    {
        BusinessPerfiles _businessPerfiles;

        public CatPerfilController(BusinessPerfiles objPerfiles) 
        {
            _businessPerfiles = objPerfiles;
        }

        [HttpGet("GetCatSexo")]
        public IActionResult GetCatSexo()
        {
            var result = _businessPerfiles.GetCatSexo();
            return Ok(result);
        }
        [HttpGet("GetCatEstatus")]
        public IActionResult GetCatEstatus()
        {
            var result = _businessPerfiles.GetEstatus();
            return Ok(result);
        }
        //[HttpGet("GetCatArea")]
        //public IActionResult GetCatArea()
        //{
        //    var result = _catalogoPerfilesService.GetCatArea();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatEstadoDelBien")]
        //public IActionResult GetCatEstadoDelBien()
        //{
        //    var result = _catalogoPerfilesService.GetCatEstadoDelBien();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatGarantia")]
        //public IActionResult GetCatGarantia()
        //{
        //    var result = _catalogoPerfilesService.GetCatGarantia();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatPermiso")]
        //public IActionResult GetCatPermiso()
        //{
        //    var result = _catalogoPerfilesService.GetCatPermiso();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatPisos")]
        //public IActionResult GetCatPisos()
        //{
        //    var result = _catalogoPerfilesService.GetCatPisos();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatRol")]
        //public IActionResult GetCatRol()
        //{
        //    var result = _catalogoPerfilesService.GetCatRol();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatServicio")]
        //public IActionResult GetCatServicio()
        //{
        //    var result = _catalogoPerfilesService.GetCatServicio();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatTipoContrato")]
        //public IActionResult GetCatTipoContrato()
        //{
        //    var result = _catalogoPerfilesService.GetCatTipoContrato();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatTipoDeBien")]
        //public IActionResult GetCatTipoDeBien()
        //{
        //    var result = _catalogoPerfilesService.GetCatTipoDeBien();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatTipoEntrada")]
        //public IActionResult GetCatTipoEntrada()
        //{
        //    var result = _catalogoPerfilesService.GetCatTipoEntrada();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatTipoPartida")]
        //public IActionResult GetCatTipoPartida()
        //{
        //    var result = _catalogoPerfilesService.GetCatTipoPartida();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatTurno")]
        //public IActionResult GetCatTurno()
        //{
        //    var result = _catalogoPerfilesService.GetCatTurno();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatUnidadDestino")]
        //public IActionResult GetCatUnidadDestino()
        //{
        //    var result = _catalogoPerfilesService.GetCatUnidadDestino();
        //    return Ok(result);
        //}
        //[HttpGet("GetCatTipoSalida")]
        //public IActionResult GetCatTipoSalida()
        //{
        //    var result = _catalogoPerfilesService.GetCatTipoSalida();
        //    return Ok(result);
        //}
        //[HttpGet("GetTblAreaServicio")]
        //public IActionResult GetTblAreaServicio()
        //{
        //    var result = _catalogoPerfilesService.GetTblAreaServicio();
        //    return Ok(result);
        //}
        //[HttpGet("GetTblBienes")]
        //public IActionResult GetTblBienes()
        //{
        //    var result = _catalogoPerfilesService.GetCatTipoSalida();
        //    return Ok(result);
        //}


    }
    
}