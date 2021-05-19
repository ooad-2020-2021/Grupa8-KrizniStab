using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public enum StatusPacijenta
    {
        [Display(Name = "Zaražen")]
        ZARAZEN,
        [Display(Name = "Oporavljen")]
        OPORAVLJEN,
        [Display(Name = "Preminuo")]
        PREMINUO,
        [Display(Name = "X")]
        X
    }
}
