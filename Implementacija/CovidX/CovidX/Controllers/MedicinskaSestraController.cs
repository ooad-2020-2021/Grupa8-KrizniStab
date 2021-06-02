using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Controllers
{
    public class MedicinskaSestraController : Controller
    {
        public IActionResult KartonView()
        {
            return View();
        }
        public IActionResult UnosRezultataTesta()
        {
            return View();
        }
        public IActionResult MedicinskaSestraView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DodajTest(IFormCollection formCollection)
        {
            return View("UnosRezultataTesta");
        }
        [HttpPost]
        public IActionResult VratiNaKarton(IFormCollection formCollection)
        {
            if (!string.IsNullOrEmpty(formCollection["id"]))
            {
                Console.WriteLine(formCollection["id"]);
            }

             return View("UnosRezultataTesta");
        }
        
    }

}
