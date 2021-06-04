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
        public RezervacijaTestiranja()
        {
        }

        public RezervacijaTestiranja(int idRezervacije, Lokacija lokacija, int testId, int placanjeId, string jmbgPacijenta, int adminId)
        {
            this.idRezervacije = idRezervacije;
            this.lokacija = lokacija;
            this.testId = testId;
            this.placanjeId = placanjeId;
            this.jmbgPacijenta = jmbgPacijenta;
            this.adminId = adminId;
        }
        [Key]
        [Required]
        [DisplayName("ID rezervacije:")]
        public int idRezervacije { get; set; }
        [Required]
        [DisplayName("Lokacija:")]
        [EnumDataType(typeof(Lokacija))]
        public Lokacija lokacija
        {
            get; set;
        }
        [Required]
        [DisplayName("Test:")]
        public int testId
        {
            get; set;
        }
        [Required]
        [DisplayName("Placanje:")]
        public int placanjeId { get; set; }
        [Required]
        [DisplayName("JMBG pacijenta:")]
        public string jmbgPacijenta
        {
            get; set;
        }
        [Required]
        public int adminId
        {
            get; set;
        }
    }
}
