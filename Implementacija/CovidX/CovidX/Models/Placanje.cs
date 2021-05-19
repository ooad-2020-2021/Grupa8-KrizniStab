using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{
    public abstract class Placanje
    {
        protected Placanje(DateTime datumUplate, double iznosUplate)
        {
            this.datumUplate = datumUplate;
            this.iznosUplate = iznosUplate;
        }
        [DataType(DataType.Date)]
        [DisplayName("Datum uplate:")]
        [Required]
        public DateTime datumUplate { get; set; }
        [Required]
        [DisplayName("Iznos uplate:")]
        public Double iznosUplate { get; set; }
    }
}
