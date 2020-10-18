using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SICOBIM_B.Business;

namespace SICOBIM_B.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventarioSistemasController : ControllerBase
    {

        BusinessInventarioSistemas _businessSistemas;
        public InventarioSistemasController(BusinessInventarioSistemas objSistemas)
        {
            _businessSistemas = objSistemas;
        }


        [HttpGet("ObtenerInventarioSistemas")]
        public IActionResult GetTblInventarioSistemas()
        {
            var result = _businessSistemas.GetSistemas(); 
            return Ok(result);
        }

    }
}
