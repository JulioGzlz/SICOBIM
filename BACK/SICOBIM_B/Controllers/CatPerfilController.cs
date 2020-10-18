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
        private ICatalogoPerfilesService _catalogoPerfilesService;


        public CatPerfilController(ICatalogoPerfilesService obj, BusinessPerfiles objPerfiles) {
            _catalogoPerfilesService = obj;
            _businessPerfiles = objPerfiles;

        }

        [HttpGet("GetCatSexo")]
        public IActionResult GetCatSexo()
        {
            var result = _catalogoPerfilesService.GetCatSexo();
            return Ok(result);
        }
        [HttpGet("GetCatEstatus")]
        public IActionResult GetCatEstatus()
        {
            var result = _businessPerfiles.GetEstatus();
            return Ok(result);
        }
        [HttpGet("GetCatArea")]
        public IActionResult GetCatArea()
        {
            var result = _catalogoPerfilesService.GetCatArea();
            return Ok(result);
        }

       
        [HttpGet("GetCatPermiso")]
        public IActionResult GetCatPermiso()
        {
            var result = _catalogoPerfilesService.GetCatPermiso();
            return Ok(result);
        }

        [HttpGet("GetCatRol")]
        public IActionResult GetCatRol()
        {
            var result = _catalogoPerfilesService.GetCatRol();
            return Ok(result);
        }
        [HttpGet("GetCatServicio")]
        public IActionResult GetCatServicio()
        {
            var result = _catalogoPerfilesService.GetCatServicio();
            return Ok(result);
        }
        [HttpGet("GetCatTipoContrato")]
        public IActionResult GetCatTipoContrato()
        {
            var result = _catalogoPerfilesService.GetCatTipoContrato();
            return Ok(result);
        }


 
        [HttpGet("GetCatTurno")]
        public IActionResult GetCatTurno()
        {
            var result = _catalogoPerfilesService.GetCatTurno();
            return Ok(result);
        }


        [HttpGet("GetTblAreaServicio")]
        public IActionResult GetTblAreaServicio()
        {
            var result = _catalogoPerfilesService.GetTblAreaServicio();
            return Ok(result);
        }



    }
}