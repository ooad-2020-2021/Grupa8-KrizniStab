using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
  
    public class Test
    {
        public Test(string idTesta, DateTime datumTestiranja, VrstaTesta vrstaTesta, NamjenaTesta namjenaTesta, Rezultat rezultat)
        {
            this.idTesta = idTesta;
            this.datumTestiranja = datumTestiranja;
            this.vrstaTesta = vrstaTesta;
            this.namjenaTesta = namjenaTesta;
            this.rezultat = rezultat;
        }
        [Key]
        [Required]
        public String idTesta
        {
            get; set;
        }
        [Required]
        public DateTime datumTestiranja
        {
            get; set;
        }
        [Required]
        public VrstaTesta vrstaTesta
        {
            get; set;
        }
        [Required]
        public NamjenaTesta namjenaTesta
        {
            get; set;
        }
        [Required]
        public Rezultat rezultat { get; set; }
        public DateTime odrediKrajIzolacije(DateTime datumTestiranja)
        {
            return datumTestiranja.AddDays(14);
        }

    }
}
