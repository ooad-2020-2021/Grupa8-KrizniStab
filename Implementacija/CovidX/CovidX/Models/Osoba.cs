using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class Osoba
    {
        public Osoba(String ime, String prezime, String jmbg, DateTime datumRodjenja, String telefon, String mail, Spol spol, String brojKartona)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.telefon = telefon;
            this.mail = mail;
            this.spol = spol;
            this.brojKartona = brojKartona;
        }
        [Required]
        [DisplayName("Ime:")]
        public String ime
        {
            get; set;
        }
        [Required]
        [DisplayName("Prezime:")]
        public String prezime
        {
            get; set;
        }
        [Key]
        [Required]
        [DisplayName("JMBG:")]
        public String jmbg
        {
            get; set;
        }
        [Required]
        [DisplayName("Datum rođenja:")]
        [DataType(DataType.Date)]
        public DateTime datumRodjenja
        {
            get; set;
        }
        [DisplayName("Telefon:")]
        public String telefon { get; set; }

        [DisplayName("Mail:")]
        [Required]
        public String mail
        {
            get; set;
        }
        [DisplayName("Spol:")]
        [EnumDataType(typeof(Spol))]
        public Spol spol { get; set; }
        [DisplayName("Broj kartona:")]
        [Required]
        public String brojKartona { get; set; }
    }
}
