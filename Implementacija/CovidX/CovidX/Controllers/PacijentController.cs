using CovidX.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Controllers
{
    public class PacijentController : Controller
    {
        private readonly IConfiguration _configuration;
        public PacijentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult MapaView()
        {
            return View();
        }
    
        public IActionResult PacijentView()
        {
            return View();
        }
        public IActionResult RezervacijaTestiranjaView()
        {
            return View();
        }
        private Pacijent GetPacijent(string UserName)
        {
            Pacijent pacijent = new Pacijent();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var sql = "SELECT jmbg, ime, prezime, datumRodjenja, telefon, mail FROM Pacijent WHERE UserName =" + UserName;
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    string jmbg = (string)reader["jmbg"];
                    string ime = reader["ime"].ToString();
                    string prezime = reader["prezime"].ToString();
                    DateTime datumRodjenja = (DateTime)reader["datumRodjenja"];
                    string mail = reader["mail"].ToString();
                    string telefon = reader["telefon"].ToString();

                     pacijent = new Pacijent(ime, prezime, jmbg, datumRodjenja, telefon, mail, Spol.ZENSKI, null);
                }
            }
            return pacijent;
        }
    }
   //postavi info o pacijentu based on login user name i postavi tamo na elemente viewa, isto za karton i med sestra, i testove...

}
