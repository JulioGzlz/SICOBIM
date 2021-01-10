using Microsoft.AspNetCore.Mvc;
using SICOBIM_B.Business;
using SICOBIM_B.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResguardatarioController : Microsoft.AspNetCore.Mvc.ControllerBase
    {

        BusinessResguardatario _businessResguardatario;
        public ResguardatarioController(BusinessResguardatario objResguardatario)
        {
            _businessResguardatario = objResguardatario;
        }
        #region Consultas metodo get
        [HttpGet("ObtenerResguardatarios")]
        public IActionResult GetTblResguardatarios()
        {
            var result = _businessResguardatario.GetResguardatario();
            return Ok(result);
        }
        [HttpGet("ObtenerNombredeResguardatarios")]
        public IActionResult GetTblNombreResguardatarios()
        {
            var result = _businessResguardatario.GetConsultaPorNombre();
            return Ok(result);
        }

        [HttpGet("ObtenerPrimerApellido")]
        public IActionResult GetTblPrimerApellidoResguardatarios()
        {
            var result = _businessResguardatario.GetConsultaPorPrimerApellido();
            return Ok(result);
        }

        [HttpGet("ObtenerSegundoApellido")]
        public IActionResult GetTblSegundoApellidoResguardatarios()
        {
            var result = _businessResguardatario.GetConsultaPorSegundoApellido();
            return Ok(result);
        }

        [HttpGet("ObtenerPorServicio")]
        public IActionResult GetResguardatarioPorServicio()
        {
            var result = _businessResguardatario.GetConsultaPorServicio();
            return Ok(result);
        }

        [HttpGet("ObtenerPorArea")]
        public IActionResult GetResguardatarioPorArea()
        {
            var result = _businessResguardatario.GetConsultaPorArea();
            return Ok(result);
        }

        [HttpGet("ObtenerPorTurno")]
        public IActionResult GetResguardatarioPorTuro()
        {
            var result = _businessResguardatario.GetConsultaPorTurno();
            return Ok(result);
        }

        [HttpGet("ObtenerPorEstatus")]
        public IActionResult GetResguardatariosPorEstatus()
        {
            var result = _businessResguardatario.GetConsultaPorEstatus();
            return Ok(result);
        }

        [HttpGet("ObtenerPorTipoDeContrato")]
        public IActionResult GetResguardatarioPorContrato()
        {
            var result = _businessResguardatario.GetConsultaPorContrato();
            return Ok(result);
        }
        [HttpGet("ObtenerResguardatariosActivos")]
        public IActionResult GetResguardatarioActivo()
        {
            var result = _businessResguardatario.GetConsultaPorActivo();
            return Ok(result);
        }
        [HttpGet("ObtenerPorRFC")]
        public IActionResult GetResguardatarioPorRFC()
        {
            var result = _businessResguardatario.GetConsultaPorRFC();
            return Ok(result);
        }
        [HttpGet("ObtenerPorCargo")]
        public IActionResult GetResguardatarioPorCargo()
        {
            var result = _businessResguardatario.GetConsultaPorCargo();
            return Ok(result);
        }
        [HttpGet("ObtenerPorNumeroDeEmpleado")]
        public IActionResult GetResguardatarioPorNumeroDeEmpleado()
        {
            var result = _businessResguardatario.GetConsultaPorSexo();
            return Ok(result);
        }
        [HttpGet("ObtenerPorNumeroDePlaza")]
        public IActionResult GetResguardatarioPorNumeroDePlaza()
        {
            var result = _businessResguardatario.GetConsultaPorNumeroDePlaza();
            return Ok(result);
        }


        #endregion



        #region metodo post registro de reguardatarios
        [HttpPost("RegistroDeResguardatarios")]
        public IActionResult RegistroDeResguardatarios([FromBody] ModeloResguardatario modeloResguardatario)
        {
            if (modeloResguardatario != null)
            {
                TblResguardatarios tblResguardatarios = new TblResguardatarios();

                tblResguardatarios.Nombre = modeloResguardatario.Nombre;
                tblResguardatarios.ApellidoUno = modeloResguardatario.ApellidoUno;
                tblResguardatarios.ApellidoDos = modeloResguardatario.ApellidoDos;
                tblResguardatarios.Catareaid = modeloResguardatario.Catareaid;
                tblResguardatarios.CatServicioid = modeloResguardatario.CatServicioid;
                tblResguardatarios.CatTurnoid = modeloResguardatario.CatTurnoid;
                tblResguardatarios.CatEstatusid = modeloResguardatario.CatEstatusid;
                tblResguardatarios.CatTipoContratoid = modeloResguardatario.CatTipoContratoid;
                tblResguardatarios.IdUsuarioAlta = modeloResguardatario.IdUsuarioAlta;
                tblResguardatarios.Activo = true;
                tblResguardatarios.FechaAlta = DateTime.Now;
                tblResguardatarios.Rfc = modeloResguardatario.RFC;
                tblResguardatarios.Cargo = modeloResguardatario.Cargo;
                tblResguardatarios.CatSexoid = modeloResguardatario.CatSexoid;
                tblResguardatarios.Numeroempleado = modeloResguardatario.Numeroempleado;
                tblResguardatarios.Plaza = modeloResguardatario.Plaza;

                tblResguardatarios = _businessResguardatario.GuardarTblResguardatarios(tblResguardatarios);



            }
            return Ok();
        }





            #endregion|










        
    }
}
