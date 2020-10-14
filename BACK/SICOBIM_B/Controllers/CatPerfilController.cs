using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SICOBIM_B.Helpers;
using SICOBIM_B.Services;

namespace SICOBIM_B.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatPerfilController : ControllerBase
    {
        private ICatalogoPerfilesService _catalogoPerfilesService;
 

        public CatPerfilController (ICatalogoPerfilesService obj){
            _catalogoPerfilesService = obj;

        }  

        [HttpGet("getsexo")]
        public IActionResult getSexo()
        {
            var result = _catalogoPerfilesService.GetCatSexo();
            return Ok(result);
        }
        [HttpGet("getestatus")]
        public IActionResult GetEstatus()
        {
            var result = _catalogoPerfilesService.GetCatEstatus();
            return Ok(result);
        }

    }
}