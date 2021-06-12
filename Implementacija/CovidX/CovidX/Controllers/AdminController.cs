using CovidX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                    medSestra.UserName = reader["ime"].ToString();

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
            string brojKartona = Request.Form["brojKartona"];
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

            MedicinskaSestra med = new MedicinskaSestra(ime, prezime, jmbg, DateTime.Today, telefon, mail, spol, brojKartona, DateTime.Today.AddDays(-10), lokacija, 1);
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string dateRodjenja = med.datumRodjenja.Year + "-" + med.datumRodjenja.Month + "-" + med.datumRodjenja.Day;
                string dateZadnjegTestiranja = med.datumRodjenja.Year + "-" + med.datumRodjenja.Month + "-" + med.datumRodjenja.Day;
                var sql = "INSERT INTO [dbo].[Medicinska sestra] (jmbg,ime,prezime,datumRodjenja,telefon,mail,spol,brojKartona,datumZadnjegTestiranja,lokacija,adminId) Values('"
                + med.jmbg + "','" + med.ime + "','" + med.prezime + "','" + dateRodjenja + "','" + med.telefon + "','" + med.mail + "','" + "0" + "','" + med.brojKartona
                + "','" + dateZadnjegTestiranja + "','" + "0" + "','" + med.adminId + "')";
                var karton = "INSERT INTO [dbo].[Karton osoblja](brojKartona, kriticnaGrupa, statusOsoblja) VALUES('" + med.brojKartona + "'," + 0 + "," + 0 + ")";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                connection.Close();
                connection.Open();
                using SqlCommand command2 = new SqlCommand(karton, connection);
                using SqlDataReader reader2 = command2.ExecuteReader();

            }
            medicinskoOsoblje.Add(med);
            return RedirectToAction("AdminView", "Admin");
        }

        // GET: AdminController
        public ActionResult Index()
        {
            return View();
        }
        /*
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
        }*/
    }
}