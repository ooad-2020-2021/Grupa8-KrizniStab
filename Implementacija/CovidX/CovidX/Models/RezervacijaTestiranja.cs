using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
  
    public class RezervacijaTestiranja
    {
        public RezervacijaTestiranja(string idRezervacije, Lokacija lokacija, Test test, Placanje placanje, string jmbgPacijenta)
        {
            this.idRezervacije = idRezervacije;
            this.lokacija = lokacija;
            this.test = test;
            this.placanje = placanje;
            this.jmbgPacijenta = jmbgPacijenta;
        }
        [Key]
        [Required]
        public String idRezervacije { get; set; }
        [Required]
        public Lokacija lokacija
        {
            get; set;
        }
        [Required]
        public Test test
        {
            get; set;
        }
        [Required]
        public Placanje placanje { get; set; }
        [Required]
        public String jmbgPacijenta
        {
            get; set;
        }
    }
}
