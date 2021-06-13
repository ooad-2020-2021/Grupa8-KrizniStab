using CovidX.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;

namespace CovidX.Controllers
{

    public class PacijentController : Controller
    {
        private readonly IConfiguration _configuration;
        Pacijent pacijent = new Pacijent();


        public PacijentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        public IActionResult MapaView()
        {
            return View();
        }


        public IActionResult RezervacijaTestiranjaView()
        {
            return View();
        }
        public IActionResult OnlinePlacanjeView()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PacijentView()
        {
            pacijent = GetPacijent();
            ViewBag.ime = pacijent.ime;
            ViewBag.jmbg = pacijent.jmbg;
            ViewBag.prezime = pacijent.prezime;
            ViewBag.datumRodjenja = pacijent.datumRodjenja;
            ViewBag.mail = pacijent.mail;
            ViewBag.telefon = pacijent.telefon;

            DateTime datumTestiranja = new DateTime();
            int rezultat = 0;
            //coundown izolacija
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var sql = "SELECT datumTestiranja, rezultat FROM Test WHERE brojKartona = '" + User.Identity.Name.Substring(0, 1) + "-1'";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rezultat = Int32.Parse(reader["rezultat"].ToString());
                    datumTestiranja = DateTime.Parse(reader["datumTestiranja"].ToString());


                }
            }
            DateTime krajizolacije = new DateTime();
            Test test = new Test();
            krajizolacije = test.odrediKrajIzolacije(datumTestiranja);
            double kraj = (krajizolacije - DateTime.Today).TotalDays;
            if (kraj < 0) ViewBag.dana = 0;
            else
                ViewBag.dana = kraj;

            return View();
        }
        private Pacijent GetPacijent()
        {

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var sql = "SELECT jmbg, ime, prezime, datumRodjenja, telefon, mail, brojKartona FROM Pacijent WHERE ime = '" + User.Identity.Name + "'";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    pacijent.jmbg = (string)reader["jmbg"];
                    pacijent.ime = reader["ime"].ToString();
                    pacijent.prezime = reader["prezime"].ToString();
                    pacijent.datumRodjenja = (DateTime)reader["datumRodjenja"];
                    pacijent.mail = reader["mail"].ToString();
                    pacijent.telefon = reader["telefon"].ToString();
                    pacijent.brojKartona = reader["brojKartona"].ToString();
                }
            }
            return pacijent;
        }

        [HttpPost]
        public IActionResult RezervisiTermin(IFormCollection formCollection)
        {

            string vrstaTesta = formCollection["vrsta"].ToString();
            string namjenaTesta = formCollection["namjena"].ToString();
            string lokacija = formCollection["lokacija"].ToString();
            string placanje = formCollection["nacin"].ToString();

            DateTime datum = DateTime.Parse(formCollection["datum"].ToString());
            string vrijeme = formCollection["vrijeme"].ToString();

            RezervacijaTestiranja rezervacija = new RezervacijaTestiranja();
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

            int lok = 0;
            if (lokacija == "Novo Sarajevo")
                lok = 0;
            else if (lokacija == "Ilidža")
                lok = 1;
            else lok = 2;

            test.datumTestiranja = datum;
            pacijent = GetPacijent();
            test.kartonId = pacijent.brojKartona;

            Random random = new Random();
            int testId = random.Next(2000) * 3;
            test.idTesta = testId;
            rezervacija.testId = test.idTesta;
            int rezult = 0;


            int pay = 0;
            if (placanje == "Internet")
                pay = testId + 0;
            else pay = testId + 1;

            rezervacija.jmbgPacijenta = pacijent.jmbg;
            rezervacija.adminId = 1;

            rezervacija.idRezervacije = testId + test.idTesta * 3;


            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string date = "'" + test.datumTestiranja.Year + "-" + test.datumTestiranja.Month + "-" + test.datumTestiranja.Day + "'";
                var sql1 = "INSERT INTO  Test Values(" + test.idTesta + "," + date + "," + vrsta + "," +
                    namjena + "," + rezult + "," + "'" + test.kartonId + "')";
                var sql2 = "Insert into [dbo].[Rezervacija testiranja] Values(" + rezervacija.idRezervacije + "," + lok + "," +
                    rezervacija.testId + "," + pay + "," + rezervacija.jmbgPacijenta + "," + rezervacija.adminId +
                    ")";
                connection.Open();
                using SqlCommand command1 = new SqlCommand(sql1, connection);
                using SqlDataReader reader1 = command1.ExecuteReader();
                connection.Close();
                connection.Open();
                using SqlCommand command2 = new SqlCommand(sql2, connection);
                using SqlDataReader reader2 = command2.ExecuteReader();

            }
            if (placanje == "Internet") return View("OnlinePlacanjeView");
            else return View("MapaView");
        }

    }
}