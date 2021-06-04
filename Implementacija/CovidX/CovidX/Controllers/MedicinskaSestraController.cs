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
        public IActionResult KartonView(string broj)
        {
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
             
                var sql = "SELECT jmbg, ime, prezime, datumRodjenja, telefon, mail FROM Pacijent WHERE brojKartona = '" + broj +"'";
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
    }

}
