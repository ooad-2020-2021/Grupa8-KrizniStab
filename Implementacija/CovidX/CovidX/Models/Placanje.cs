using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{
    public abstract class Placanje
    {
        protected Placanje(int placanjeId, DateTime datumUplate, double iznosUplate)
        {
            this.placanjeId = placanjeId;
            this.datumUplate = datumUplate;
            this.iznosUplate = iznosUplate;
        }
        [DisplayName("ID plaćanja:")]
        [Required]
        [Key]
        public int placanjeId
        {
            get; set;
        }
        [DataType(DataType.Date)]
        [DisplayName("Datum uplate:")]
        [Required]
        public DateTime datumUplate { get; set; }
        [Required]
        [DisplayName("Iznos uplate:")]
        public double iznosUplate { get; set; }
    }
}
