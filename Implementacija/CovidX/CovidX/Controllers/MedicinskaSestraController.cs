using CovidX.Models;
using Microsoft.AspNetCore.Authorization;
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
    public class MedicinskaSestraController : Controller
    {
        private readonly IConfiguration _configuration;
        MedicinskaSestra medSestra = new MedicinskaSestra();
        List<KartonPacijenta> kartoniPacijenata = new List<KartonPacijenta>();
        public MedicinskaSestraController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult KartonView()
        {
            return View();
        }
        public IActionResult UnosRezultataTesta()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MedicinskaSestraView()
        {
            medSestra = GetMed();
            ViewBag.ime = medSestra.ime;
            ViewBag.jmbg = medSestra.jmbg;
            ViewBag.prezime = medSestra.prezime;
            ViewBag.datumRodjenja = medSestra.datumRodjenja;
            ViewBag.mail = medSestra.mail;
            ViewBag.telefon = medSestra.telefon;
            return View();
          
        }
        private MedicinskaSestra GetMed()
        {

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var sql = "SELECT jmbg, ime, prezime, datumRodjenja, telefon, mail FROM [dbo].[Medicinska sestra] WHERE ime = '" + User.Identity.Name + "'";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    medSestra.jmbg = (string)reader["jmbg"];
                    medSestra.ime = reader["ime"].ToString();
                    medSestra.prezime = reader["prezime"].ToString();
                    medSestra.datumRodjenja = (DateTime)reader["datumRodjenja"];
                    medSestra.mail = reader["mail"].ToString();
                    medSestra.telefon = reader["telefon"].ToString();
                    
                }
            }
            return medSestra;
        }

          private IActionResult KartoniPacijenata()
        {

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                //brojKartona, kriticnaGrupa, statusPacijenta
                var sql = "SELECT * FROM [dbo].[Karton pacijenata]";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string brojKartona = reader["brojKartona"].ToString();
                    string kriticnaGrupa = reader["kriticnaGrupa"].ToString();
                    string statusPacijenta = reader["statusPacijenta"].ToString();

                    bool kriticna = false;
                    if (kriticnaGrupa == "1") kriticna = true;
                    else kriticna = false;

                    StatusPacijenta status;
                    if (statusPacijenta == "0") status = StatusPacijenta.X;
                    else if (statusPacijenta == "1") status = StatusPacijenta.OPORAVLJEN;
                    else if (statusPacijenta == "2") status = StatusPacijenta.ZARAZEN;
                    else status = StatusPacijenta.PREMINUO;
                    KartonPacijenta karton = new KartonPacijenta(brojKartona, kriticna, status);

                    kartoniPacijenata.Add(karton);

                }
            }
            return View(kartoniPacijenata);
        }
    }

}
