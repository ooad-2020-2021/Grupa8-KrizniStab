using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{
    public class MedicinskaSestra : Osoba
    {
        private StatusOsoblja status;
        private string userName;
        private string password;
        public MedicinskaSestra()
        {
        }

        public MedicinskaSestra(string ime, string prezime, string jmbg, DateTime datumRodjenja, string telefon, string mail, Spol spol, String brojKartona, DateTime datumZadnjegTestiranja, Lokacija lokacija, int adminId)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.telefon = telefon;
            this.mail = mail;
            this.spol = spol;
            this.brojKartona = brojKartona;
            this.datumZadnjegTestiranja = datumZadnjegTestiranja;
            this.lokacija = lokacija;
            this.adminId = adminId;
        }
        [DataType(DataType.Date)]
        [DisplayName("Datum zadnjeg testiranja:")]
        public DateTime datumZadnjegTestiranja
        {
            get; set;
        }
        [Required]
        [DisplayName("Lokacija:")]
        [EnumDataType(typeof(Lokacija))]
        public Lokacija lokacija
        {
            get; set;
        }
        [Required]
        public int adminId
        {
            get; set;
        }
        public StatusOsoblja Status { get => status; set => status = value; }
        public string UserName { get => userName; set => userName = value; }

        [PasswordPropertyText]
        public string Password { get => password; set => password = value; }
    }
}
