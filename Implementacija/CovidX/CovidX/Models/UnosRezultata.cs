using System;
using System.Collections.Generic;
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
        public String brojKartona
        {
            get; set;
        }
        [Required]
        public Test test
        {
            get; set;
        }
    }
}
