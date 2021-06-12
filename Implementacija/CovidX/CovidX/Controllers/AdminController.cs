using CovidX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CovidX.Controllers
{
    public class AdminController : Controller
    {
        private readonly IConfiguration _configuration;
        Admin admin = new Admin();

        List<MedicinskaSestra> medicinskoOsoblje = new List<MedicinskaSestra>();
        List<RezervacijaTestiranja> listaTermina = new List<RezervacijaTestiranja>();
        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult UnosMedicinskogOsoblja()
        {
            return View();
        }
        public IActionResult Termini()
        {
            return View();
        }
        public IActionResult AdminView()
        {

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var sql = "SELECT jmbg,datumRodjenja,telefon,UserName, ime, prezime,mail,datumZadnjegTestiranja,statusOsoblja " +
                    "FROM [dbo].[Medicinska sestra],[dbo].[Karton osoblja] " +
                    "WHERE [dbo].[Medicinska sestra].brojKartona = [dbo].[Karton osoblja].brojKartona ";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MedicinskaSestra medSestra = new MedicinskaSestra();
                    medSestra.jmbg = (string)reader["jmbg"];
                    medSestra.ime = reader["ime"].ToString();
                    medSestra.prezime = reader["prezime"].ToString();
                    medSestra.datumRodjenja = (DateTime)reader["datumRodjenja"];
                    medSestra.mail = reader["mail"].ToString();
                    medSestra.telefon = reader["telefon"].ToString();
                    medSestra.datumZadnjegTestiranja = (DateTime)reader["datumZadnjegTestiranja"];
                    medSestra.UserName = (string)reader["UserName"];

                    if (reader["statusOsoblja"].ToString().Equals("1"))
                    {
                        medSestra.Status = StatusOsoblja.DOSTUPAN;
                    }
                    else
                    {
                        medSestra.Status = StatusOsoblja.NEDOSTUPAN;
                    }
                    medicinskoOsoblje.Add(medSestra);
                }
            }
            return View(medicinskoOsoblje);
        }

        [HttpPost]
        public IActionResult UnesiMedOsoblje(IFormCollection formCollection)
        {

            string ime = Request.Form["ime"];
            string prezime = Request.Form["prezime"];
            string jmbg = Request.Form["jmbg"];
            string mail = Request.Form["mail"];
            string lokacija1 = Request.Form["lokacija"];
            string UserName = Request.Form["UserName"];
            string password = Request.Form["Password"];
            string datumRodjenja = Request.Form["datumRodjenja"];
            string spol1 = Request.Form["spol"];
            string telefon = Request.Form["telefon"];
            Spol spol = new Spol();

            if (spol1 == "Muski")
            {
                spol = Spol.MUSKI;
            }
            else if (spol1 == "Zenski")
            {
                spol = Spol.ZENSKI;
            }
            Lokacija lokacija = new Lokacija();
            if (lokacija1 == "Novo Sarajevo")
            {
                lokacija = Lokacija.NovoSarajevo;
            }

            else if (lokacija1 == "Ilidža") { lokacija = Lokacija.Ilidža; }

            else if (lokacija1 == "Stari Grad") { lokacija = Lokacija.StariGrad; }

            MedicinskaSestra med = new MedicinskaSestra(ime, prezime, jmbg,)
            Test test = new Test();
            int vrsta = 0;
            if (vrstaTesta == "PCR")
                vrsta = 0;
            else if (vrstaTesta == "Serološki")
                vrsta = 1;
            else vrsta = 2;

            int namjena = 0;
            if (namjenaTesta == "Hitni")
                namjena = 0;
            else namjena = 1;
            test.datumTestiranja = DateTime.Today.AddDays(-2);
            Random ran = new Random();
            test.idTesta = ran.Next(1356) * 2;

            int rezult = 0;
            if (test.idTesta % 2 == 0) rezult = 0;
            else rezult = 1;

            test.kartonId = "H-1";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string date = "'" + test.datumTestiranja.Year + "-" + test.datumTestiranja.Month + "-" + test.datumTestiranja.Day + "'";
                var sql = "INSERT INTO  Test Values(" + test.idTesta + "," + date + "," + vrsta + "," +
                      namjena + "," + rezult + "," + "'" + test.kartonId + "')";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader);
                }

            }
            return View();
        }

        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            var medSestra = medicinskoOsoblje.Where(m => m.jmbg == id.ToString()).FirstOrDefault();
            return View(medSestra);
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
