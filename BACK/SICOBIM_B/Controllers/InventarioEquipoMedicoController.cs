using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SICOBIM_B.Controllers
{
    public class InventarioEquipoMedicoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
