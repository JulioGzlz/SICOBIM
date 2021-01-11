using Microsoft.AspNetCore.Mvc;
using SICOBIM_B.Business;


namespace SICOBIM_B.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenericoInventariosController : ControllerBase
        {

            BusinessGenericoInventarios _businessGenericoInventarios;



            public GenericoInventariosController(BusinessGenericoInventarios objInventarios)
            {
                _businessGenericoInventarios = objInventarios;


            }

            //[HttpGet]
            //[Route("obtenerInventarios/{IdBien}")]
            //public IActionResult GetNumerosDeInventariosTipoInventario(int IdBien)
            //{
            //    var result = _businessGenericoInventarios.GetNumerosDeInventariosTipoInventario(IdBien);
            //    return Ok(result);
            //}







    }
}

