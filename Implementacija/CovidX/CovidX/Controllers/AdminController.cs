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
                    medSestra.datumZadnjegTestiranja =(DateTime) reader["datumZadnjegTestiranja"];
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
            return View(medSestra   );
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
