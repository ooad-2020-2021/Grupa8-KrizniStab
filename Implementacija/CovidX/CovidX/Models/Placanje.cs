using System;
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
        [Required]
        public DateTime datumUplate { get; set; }
        [Required]
        public Double iznosUplate { get; set; }
    }
}
