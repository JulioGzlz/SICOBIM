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

        [HttpGet("obtenerSexo")]
        public IActionResult GetCatSexo()
        {
            var result = _businessPerfiles.GetCatSexo();
            return Ok(result);
        }
        [HttpGet("obtenerEstatus")]
        public IActionResult GetCatEstatus()
        {
            var result = _businessPerfiles.GetEstatus();
            return Ok(result);
        }
        [HttpGet("obtenerAreas")]
        public IActionResult GetCatArea()
        {
            var result = _businessPerfiles.getCatArea();
            return Ok(result);
        }
        [HttpGet("obtenerEstadosBien")]
        public IActionResult GetCatEstadoDelBien()
        {
            var result = _businessPerfiles.getEstadoBien();
            return Ok(result);
        }
        [HttpGet("obtenerGarantias")]
        public IActionResult GetCatGarantia()
        {
            var result = _businessPerfiles.getCatGarantia();
            return Ok(result);
        }
        [HttpGet("obtenerPermisos")]
        public IActionResult GetCatPermiso()
        {
            var result = _businessPerfiles.getCatPermiso();
            return Ok(result);
        }
        [HttpGet("obtenerPisos")]
        public IActionResult GetCatPisos()
        {
            var result = _businessPerfiles.getCatPisos();
            return Ok(result);
        }

        [HttpGet("obtenerServicios")]
        public IActionResult GetCatServicio()
        {
            var result = _businessPerfiles.getServicios();
            return Ok(result);
        }


        [HttpGet("obtenerContratos")]
        public IActionResult GetCatTipoContrato()
        {
            var result = _businessPerfiles.getCatPisos();
            return Ok(result);
        }
        [HttpGet("obtenerTipoBien")]
        public IActionResult GetCatTipoDeBien()
        {
            var result = _businessPerfiles.getTipoBienes();
            return Ok(result);
        }
        [HttpGet("obtenerTipoEntrada")]
        public IActionResult GetCatTipoEntrada()
        {
            var result = _businessPerfiles.getTipoEntrada();
            return Ok(result);
        }
        [HttpGet("obtenerPartidas")]
        public IActionResult GetCatTipoPartida()
        {
            var result = _businessPerfiles.getTipoPartidad();
            return Ok(result);
        }
        [HttpGet("obtenerTurnos")]
        public IActionResult GetCatTurno()
        {
            var result = _businessPerfiles.getCatTurnos();
            return Ok(result);
        }
        [HttpGet("obtenerDestinos")]
        public IActionResult GetCatUnidadDestino()
        {
            var result = _businessPerfiles.getUnidadDestino();
            return Ok(result);
        }
        [HttpGet("obtenerTipoSalidas")]
        public IActionResult GetCatTipoSalida()
        {
            var result = _businessPerfiles.getTipoSalida();
            return Ok(result);
        }
        [HttpGet("obtenerRoles")]
        public IActionResult GetRoles()
        {
            var result = _businessPerfiles.getRoles();
            return Ok(result);
        }

    }
    
}