using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Broj kartice:")]
        [RegularExpression(@"[0-9]*", ErrorMessage = "Broj kartice se može sastojati samo od brojeva!")]
        public String brojKartice { get; set; }
        [Required]
        [DisplayName("Datum isteka:")]
        [DataType(DataType.Date)]
        public DateTime datumIsteka { get; set; }
    }
}
