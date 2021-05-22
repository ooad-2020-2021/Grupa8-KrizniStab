using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class Pacijent : Osoba
    {
        public Pacijent(string ime, string prezime, string jmbg, DateTime datumRodjenja, string telefon, string mail, Spol spol, string brojKartona) 
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
    }
}
