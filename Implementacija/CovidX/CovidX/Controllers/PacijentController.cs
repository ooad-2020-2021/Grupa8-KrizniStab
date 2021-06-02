using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Controllers
{
    public class PacijentController : Controller
    {
        public IActionResult MapaView()
        {
            return View();
        }
        public IActionResult PacijentView()
        {
            return View();
        }
    }
}
