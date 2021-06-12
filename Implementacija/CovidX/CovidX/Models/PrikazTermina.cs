namespace CovidX.Models
{
    public class PrikazTermina
    {
        private string ime, prezime, email, broj;
        private Potvrdjen potvrdjen;
        private VrstaTesta vrsta;


        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Broj { get => broj; set => broj = value; }
        public VrstaTesta Vrsta { get => vrsta; set => vrsta = value; }
        public Potvrdjen Potvrdjen { get => potvrdjen; set => potvrdjen = value; }
    }
}
