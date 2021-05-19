using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public enum VrstaTesta
    {
        [Display(Name = "PCR")]
        PCR,
        [Display(Name = "Serološki")]
        SEROLOSKI,
        [Display(Name = "Brzi antigenski")]
        BRZI_ANTIGENSKI
    }
}
