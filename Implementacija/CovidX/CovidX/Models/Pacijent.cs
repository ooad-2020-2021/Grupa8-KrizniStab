using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class Pacijent : Osoba
    {
        public Pacijent(String ime, String prezime, String jmbg, DateTime datumRodjenja, String telefon, String mail, Spol spol, String brojKartona) : base(ime, prezime, jmbg, datumRodjenja, telefon, mail, spol, brojKartona)
        {
        }
    }
}
