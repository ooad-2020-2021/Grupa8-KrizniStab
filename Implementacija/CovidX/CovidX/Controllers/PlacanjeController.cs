using CovidX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Controllers
{
    public class PlacanjeController : Controller
    {
        private readonly IConfiguration _configuration;


        public PlacanjeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        public IActionResult Plati()
        {
          //  string brojKartice = Request.Form["brojKartice"];
            Random random = new Random();
            int placanjeId = random.Next(2000) *2;
            DateTime datumUplate = DateTime.Today;
            DateTime datumIsteka = DateTime.Today.AddDays(2358);
            KarticnoPlacanje karticno = new KarticnoPlacanje(placanjeId, datumUplate, 45, "5465454", datumIsteka);
           
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {

                var sql = "INSERT INTO [dbo].[Karticno placanje] VALUES(" +
                    karticno.placanjeId + "," + karticno.datumUplate + "," + karticno.iznosUplate + "," + karticno.brojKartice + ","
                    + karticno.datumIsteka + ")";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

            }
            return View("MapaView");
        }
        public IActionResult MapaView()
        {
            return View();
        }
    }

}