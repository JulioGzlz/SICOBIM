using Microsoft.AspNetCore.Mvc;
using SICOBIM_B.Business;
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
















    }
}
