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

        public InventarioMobiliarioController(BusinessInventarioMobiliario objInventarioMobiliario)

        {
            _businessInventarioMobiliario = objInventarioMobiliario;
        }


        [HttpGet("ObtenerBienesMuebles")]
        public IActionResult GetTblBienes()
        {
            var result = _businessInventarioMobiliario.GetTblBienes();
            return Ok(result);
        }
 
    }
}
