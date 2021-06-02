using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Controllers
{
    public class PlacanjeController : Controller
    {
        public IActionResult OnlinePlacanjeView()
        {
            return View();
        }
    }
}
