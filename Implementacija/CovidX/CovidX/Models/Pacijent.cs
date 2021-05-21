using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class Pacijent : Osoba
    {
        public Pacijent(string ime, string prezime, string jmbg, DateTime datumRodjenja, string telefon, string mail, Spol spol, string brojKartona) : base(ime, prezime, jmbg, datumRodjenja, telefon, mail, spol, brojKartona)
        {
        }
    }
}
