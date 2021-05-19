using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public enum Rezultat
    {
        [Display(Name = "Pozitivan")]
        POZITIVAN,
        [Display(Name = "Negativan")]
        NEGATIVAN
    }
}

