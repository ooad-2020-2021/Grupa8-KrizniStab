using System;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{ 
    public class RezervacijaTestiranjaMed
    {
        public RezervacijaTestiranjaMed(DateTime datumTestiranja, VrstaTesta vrstaTesta, NamjenaTesta namjenaTesta, string jmbgMed, Test test)
        {
            this.datumTestiranja = datumTestiranja;
            this.vrstaTesta = vrstaTesta;
            this.namjenaTesta = namjenaTesta;
            this.jmbgMed = jmbgMed;
            this.test = test;
        }
        [Required]
        public DateTime datumTestiranja { get; set; }
        [Required]
        public VrstaTesta vrstaTesta { get; set; }
        [Required]
        public NamjenaTesta namjenaTesta { get; set; }
        [Required]
        public String jmbgMed { get; set; }
        [Required]
        public Test test { get; set; }
    }
}
