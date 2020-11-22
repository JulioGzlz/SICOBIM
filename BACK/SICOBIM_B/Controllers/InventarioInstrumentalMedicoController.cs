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
    public class InventarioInstrumentalMedicoController : ControllerBase
    {

        BusinessInventarioInstrumentalMedico _businessInstrumeental;
        public InventarioInstrumentalMedicoController(BusinessInventarioInstrumentalMedico objInstrumental)
        {
            _businessInstrumeental = objInstrumental;
        }


        [HttpGet("ObtenerInventarioInstrumental")]
        public IActionResult GetTblInstrumentalMedico()
        {
            var result = _businessInstrumeental.GetInstrumental();
            return Ok(result);
        }
        [HttpGet]
        [Route("obtenerfactura/{idBien}")]
        public IActionResult GetFacturasTipoInventario(int idBien)
        {
            var result = _businessInstrumeental.GetFacturasTipoInventario(idBien);
            return Ok(result);
        }

    }
}
