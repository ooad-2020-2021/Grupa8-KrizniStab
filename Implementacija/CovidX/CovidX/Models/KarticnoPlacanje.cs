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
       

        public KarticnoPlacanje(int placanjeId, DateTime datumUplate, Double iznosUplate, string brojKartice, DateTime datumIsteka) : base(placanjeId, datumUplate, iznosUplate)
        {
            this.brojKartice = brojKartice;
            this.datumIsteka = datumIsteka;
        }
        [Required]
        [DisplayName("Broj kartice:")]
        [RegularExpression(@"[0-9]*", ErrorMessage = "Broj kartice se može sastojati samo od brojeva!")]
        public string brojKartice { get; set; }
        [Required]
        [DisplayName("Datum isteka:")]
        [DataType(DataType.Date)]
        public DateTime datumIsteka { get; set; }
    }
}
