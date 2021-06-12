using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class PrikazTermina
    {
        private string ime, prezime, email, broj;
        private bool potvrdjen;
        VrstaTesta vrsta;

        public bool Potvrdjen { get => potvrdjen; set => potvrdjen = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Broj { get => broj; set => broj = value; }
        public VrstaTesta Vrsta { get => vrsta; set => vrsta = value; }
    }
}
