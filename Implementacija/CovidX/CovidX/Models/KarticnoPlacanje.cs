using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class KarticnoPlacanje : Placanje
    {
        public KarticnoPlacanje(DateTime datumUplate, Double iznosUplate, String brojKartice, DateTime datumIsteka) : base(datumUplate, iznosUplate)
        {
            this.brojKartice = brojKartice;
            this.datumIsteka = datumIsteka;
        }
        [Required]
        public String brojKartice { get; set; }
        [Required]
        public DateTime datumIsteka { get; set; }
    }
}
