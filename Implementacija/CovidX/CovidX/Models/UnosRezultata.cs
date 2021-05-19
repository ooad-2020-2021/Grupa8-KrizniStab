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
        public UnosRezultata(string brojKartona, Test test)
        {
            this.brojKartona = brojKartona;
            this.test = test;
        }
        [Required]
        [DisplayName("Broj kartona:")]
        public String brojKartona
        {
            get; set;
        }
        [Required]
        [DisplayName("Test:")]
        public Test test
        {
            get; set;
        }
    }
}
