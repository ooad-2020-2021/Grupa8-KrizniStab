using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public enum StatusOsoblja
    {
        [Display(Name = "Dostupan")]
        DOSTUPAN,
        [Display(Name = "Nedostupan")]
        NEDOSTUPAN
    }
}
