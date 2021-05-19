using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public enum NamjenaTesta
    {
        [Display(Name = "Hitni test")]
        HITNI,
        [Display(Name = "Potrebe prelaska granice")]
        POTREBE_PRELASKA_GRANICE
    }
}
