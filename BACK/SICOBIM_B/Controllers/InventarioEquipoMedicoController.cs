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
    public class InventarioEquipoMedicoController : ControllerBase
    {

        BusinessInventarioEquipoMedico _businessEquipoMedico;
        public InventarioEquipoMedicoController(BusinessInventarioEquipoMedico objEquipoMedico)
        {
            _businessEquipoMedico = objEquipoMedico;
        }


        [HttpGet("ObtenerInventarioEquipoMedico")]
        public IActionResult GetTblBienesEquMedico()
        {
            var result = _businessEquipoMedico.GetEquipoMedico();
            return Ok(result);
        }
    }
}
