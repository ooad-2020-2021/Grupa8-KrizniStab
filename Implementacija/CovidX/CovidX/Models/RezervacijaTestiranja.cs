using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("ID rezervacije:")]
        public String idRezervacije { get; set; }
        [Required]
        [DisplayName("Lokacija:")]
        [EnumDataType(typeof(Lokacija))]
        public Lokacija lokacija
        {
            get; set;
        }
        [Required]
        [DisplayName("Test:")]
        public Test test
        {
            get; set;
        }
        [Required]
        [DisplayName("Placanje:")]
        public Placanje placanje { get; set; }
        [Required]
        [DisplayName("JMBG pacijenta:")]
        public String jmbgPacijenta
        {
            get; set;
        }
    }
}
