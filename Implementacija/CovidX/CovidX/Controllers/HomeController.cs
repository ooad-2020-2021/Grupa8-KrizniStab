using CovidX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CovidX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult HomePageView()
        {
            return View();
        }
        public IActionResult PrevencijaView()
        {
            return View();
        }

        public IActionResult EvidencijaSimptomaView()
        {
            return View();
        }
        public IActionResult RegistracijaView()
        {
            return View();
        }
        public IActionResult LoginView()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EvidentirajSimptome(IFormCollection formCollection)
        {
            bool c1 = false;
            bool c2 = false;
            bool c3 = false;
            bool c4 = false;
            bool c5 = false;
            bool c6 = false;
            bool c7 = false;
            bool c8 = false;
            bool c9 = false;

            if (!string.IsNullOrEmpty(formCollection["c1"])) { c1 = true; }
            if (!string.IsNullOrEmpty(formCollection["c2"])) { c2 = true; }
            if (!string.IsNullOrEmpty(formCollection["c3"])) { c3 = true; }
            if (!string.IsNullOrEmpty(formCollection["c4"])) { c4 = true; }
            if (!string.IsNullOrEmpty(formCollection["c5"])) { c5 = true; }
            if (!string.IsNullOrEmpty(formCollection["c6"])) { c6 = true; }
            if (!string.IsNullOrEmpty(formCollection["c7"])) { c7 = true; }
            if (!string.IsNullOrEmpty(formCollection["c8"])) { c8 = true; }
            if (!string.IsNullOrEmpty(formCollection["c9"])) { c9 = true; }



            bool evidencija = IEvidencijaSimptoma.evidentirajSimptome(c1, c2, c3, c4, c5, c6, c7, c8, c9);

            if (evidencija == true)
                return View("SimptomiNotOK");
            else return View("SimptomiOK");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
