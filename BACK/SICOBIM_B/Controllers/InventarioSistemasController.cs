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
        [HttpGet("ObtenerBienesPorFederalizacion")]
        public IActionResult GetConsultaPorFederalizacion()
        {
            var result = _businessSistemas.GetConsultaFederalizacion();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorCabms")]
        public IActionResult GetConsultaPorCabms()
        {
            var result = _businessSistemas.GetConcultaCabms();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorInventario")]
        public IActionResult GetConsultaPorInventario()
        {
            var result = _businessSistemas.GetConsultaInventario();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorProveedor")]
        public IActionResult GetConsultaPorProveedor()
        {
            var result = _businessSistemas.GetConsulataProveedor();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorFactura")]
        public IActionResult GetConsultaPorFactura()
        {
            var result = _businessSistemas.GetTblBienesPorFactura();
            return Ok(result);
        }
        [HttpGet("ObtenerBienesPorClaveSaica")]
        public IActionResult GetConsultaPorClaveSaica()
        {
            var result = _businessSistemas.GetConsultaClaveSaica();
            return Ok(result);
        }
        [HttpGet]
        [Route("obtenerfactura/{idBienSistema}")]
        public IActionResult GetFacturasTipoInventario(int idBienSistema)
        {
            var result = _businessSistemas.GetFacturasTipoInventario(idBienSistema);
            return Ok(result);
        }

      

    }
}
