using CovidX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

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
        public IActionResult Plati(IFormCollection formCollection)
        {
            string brojKartice = formCollection["brojKartice"];
            Random random = new Random();
            int placanjeId = random.Next(2000) * 2;
            DateTime datumUplate = DateTime.Today;
            string datumIsteka = formCollection["datumIsteka"];
            int mjesec = Int32.Parse(datumIsteka.Substring(0, 2));
            int godina = Int32.Parse("20" + datumIsteka.Substring(3, 2));
            DateTime istek = new DateTime(godina, mjesec, 1);
            KarticnoPlacanje karticno = new KarticnoPlacanje(placanjeId, datumUplate, 45, brojKartice, istek);

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var datumU = "'" + karticno.datumUplate.Year + "-" + karticno.datumUplate.Month + "-" + karticno.datumUplate.Day + "'";
                var datumI = "'" + karticno.datumIsteka.Year + "-" + karticno.datumIsteka.Month + "-" + karticno.datumIsteka.Day + "'";
                var sql = "SET IDENTITY_INSERT[dbo].[Karticno placanje] ON INSERT INTO [dbo].[Karticno placanje](placanjeId, datumUplate, iznosUplate, brojKartice, datumIsteka) VALUES(" +
                    karticno.placanjeId + "," + datumU + "," + karticno.iznosUplate + "," + karticno.brojKartice + ","
                    + datumI + ")";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

            }
            return RedirectToAction("MapaView", "Pacijent");
        }

    }

}