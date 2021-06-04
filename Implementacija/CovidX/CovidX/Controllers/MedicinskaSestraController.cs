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
        private string broj = "";
        public MedicinskaSestraController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult UnosRezultataTesta()
        {
            return View();
        }
        public IActionResult RezervacijaTestiranjaMed()
        {
            return View();
        }
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

        public IActionResult KartoniPacijenata()
        {

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                //brojKartona, kriticnaGrupa, statusPacijenta
                var sql = "SELECT * FROM [dbo].[Karton pacijenta]";
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
        public IActionResult KartonView(string brojK)
         
        {
            broj = brojK;
            KartonPacijenta karton = new KartonPacijenta("", false, StatusPacijenta.OPORAVLJEN);
            Pacijent pacijent = new Pacijent();
            foreach (var k in kartoniPacijenata)
            {
                if (k.brojKartona == broj)
                {
                    karton = k;
                    break;
                }
            }
            //Trazimo pacijenta

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {

                var sql = "SELECT jmbg, ime, prezime, datumRodjenja, telefon, mail FROM Pacijent WHERE brojKartona = '" + broj + "'";
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
                    pacijent.brojKartona = broj;

                }
            }
            ViewBag.ime = pacijent.ime;
            ViewBag.jmbg = pacijent.jmbg;
            ViewBag.prezime = pacijent.prezime;
            ViewBag.datumRodjenja = pacijent.datumRodjenja;
            ViewBag.mail = pacijent.mail;
            ViewBag.kriticnaGrupa = karton.kriticnaGrupa;
            ViewBag.status = karton.statusPacijenta;
            ViewBag.brojKartona = broj;
            List<Test> testovi = new List<Test>();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var sql = "SELECT * FROM Test WHERE brojKartona = '" + broj + "'";
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                Test test = new Test();
                while (reader.Read())
                {
                    string datumTestiranja = reader["datumTestiranja"].ToString();
                    string vrsta = reader["vrstaTesta"].ToString();
                    string namjena = reader["namjenaTesta"].ToString();
                    string rezultat = reader["rezultat"].ToString();
                    //2021-05-25
                    string godina = datumTestiranja.Substring(0, 4);
                    string mjesec = datumTestiranja.Substring(5, 2);
                    string dan = datumTestiranja.Substring(8, 2);
                    if (dan[0] == '0') dan = dan[1].ToString();

                    DateTime datumT = DateTime.Today;

                    VrstaTesta vrstaTesta = VrstaTesta.BRZI_ANTIGENSKI;
                    if (vrsta == "0") vrstaTesta = VrstaTesta.PCR;
                    else if (vrsta == "1") vrstaTesta = VrstaTesta.SEROLOSKI;

                    NamjenaTesta namjenaTesta = NamjenaTesta.POTREBE_PRELASKA_GRANICE;
                    if (namjena == "0") namjenaTesta = NamjenaTesta.HITNI;

                    Rezultat rez = Rezultat.POZITIVAN;
                    if (rezultat == "2") rez = Rezultat.NEGATIVAN;

                    test = new Test(0, datumT, vrstaTesta, namjenaTesta, rez, broj);
                    testovi.Add(test);
                }
            }
            return View(testovi);
        }
        [HttpPost]
        public IActionResult UnesiTest(IFormCollection formCollection)
        {

            string id = Request.Form["id"];
            string datumTestiranja = Request.Form["datumTestiranja"];

            string vrstaTesta = Request.Form["vrstaTesta"].ToString();
            string namjenaTesta = Request.Form["namjena"].ToString();
            string rezultat = Request.Form["rezultat"];
            broj = Request.Form["idKartona"].ToString();
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
                while(reader.Read())
                {
                    Console.WriteLine(reader);
                }

            }
            return View();
        }
        [HttpPost]
        public IActionResult RezervisiTermin(IFormCollection formCollection)
        {
            string vrstaTesta = Request.Form["vrsta"];
            string namjenaTesta = Request.Form["namjena"];
            string lokacija = Request.Form["lokacija"];
          

            RezervacijaTestiranjaMed rezervacija = new RezervacijaTestiranjaMed();
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

            
            test.datumTestiranja = DateTime.Today.AddDays(1);
            MedicinskaSestra medSestra = new MedicinskaSestra();
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var sql = "SELECT jmbg, ime, prezime, datumRodjenja, telefon, mail, brojKartona FROM [dbo].[Medicinska sestra] WHERE ime = '" + User.Identity.Name + "'";
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
                    medSestra.brojKartona = reader["brojKartona"].ToString();
                }
            }
            test.kartonId = medSestra.brojKartona;

            Random random = new Random();
            int testId = random.Next(2000) * 3;
            test.idTesta = testId;
            rezervacija.testId = test.idTesta;
            int rezult = 0;
            if (testId % 2 == 0) rezult = 0;
            else rezult = 1;
            rezervacija.datumTestiranja = DateTime.Today;


            rezervacija.jmbgMed = medSestra.jmbg;

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                string date = "'" + test.datumTestiranja.Year + "-" + test.datumTestiranja.Month + "-" + test.datumTestiranja.Day + "'";
                string datumT = "'" + rezervacija.datumTestiranja.Year + "-" + rezervacija.datumTestiranja.Month + "-" + rezervacija.datumTestiranja.Day + "'";
                var sql1 = "INSERT INTO  Test Values(" + test.idTesta + "," + date + "," + vrsta + "," +
                    namjena + "," + rezult + "," + "'" + test.kartonId + "')";
                var sql2 = "Insert INTO [dbo].[Rezervacija testiranja za medicinsko osoblje] Values(" +
                   datumT + ","  + vrsta + "," + namjena + "," + rezervacija.jmbgMed + ")";
                connection.Open();
                using SqlCommand command1 = new SqlCommand(sql1, connection);
                using SqlDataReader reader1 = command1.ExecuteReader();
                connection.Close();
                connection.Open();
                using SqlCommand command2 = new SqlCommand(sql2, connection);
                using SqlDataReader reader2 = command2.ExecuteReader();

            }
            return View("MedicinskaSestraView") ;
        }
    }

}
