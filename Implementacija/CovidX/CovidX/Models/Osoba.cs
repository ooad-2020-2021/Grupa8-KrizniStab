using System;
using System.Collections.Generic;
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
        public String ime
        {
            get; set;
        }
        [Required]
        public String prezime
        {
            get; set;
        }
        [Key]
        [Required]
        public String jmbg
        {
            get; set;
        }
        [Required]
        public DateTime datumRodjenja
        {
            get; set;
        }
         public String telefon { get; set; }
        public String mail
        {
            get; set;
        }
        public Spol spol { get; set; }
        [Required]
        public String brojKartona { get; set; }
    }
}
