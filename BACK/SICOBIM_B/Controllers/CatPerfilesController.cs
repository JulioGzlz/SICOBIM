using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SICOBIM_B.Helpers;
using SICOBIM_B.Services;

namespace SICOBIM_B.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatPerfilesController : ControllerBase
    {
        private ICatalogoPerfiles catalogoPerfiles;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;


        public CatPerfilesController(ICatalogoPerfiles catPerfilService, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _mapper = mapper;
            _appSettings = appSettings.Value;

        }



        [HttpGet("/getsexo")]


        public IActionResult GetSexo()
        {

            var result = catalogoPerfiles.GetCatSexo();

            return Ok(result);

        }














    }
}
