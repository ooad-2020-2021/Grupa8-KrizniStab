using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class UnosRezultata
    {
        public UnosRezultata(string brojKartona, int testId)
        {
            this.brojKartona = brojKartona;
            this.testId = testId;
        }
        [Required]
        [DisplayName("Broj kartona:")]
        public string brojKartona
        {
            get; set;
        }
        [Required]
        [DisplayName("Test:")]
        [Key]
        public int testId
        {
            get; set;
        }
    }
}
