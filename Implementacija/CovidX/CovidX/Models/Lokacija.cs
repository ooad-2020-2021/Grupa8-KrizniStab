using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public enum Lokacija
    {
        [Display(Name = "Novo Sarajevo")]
        NovoSarajevo,
        [Display(Name = "Ilidža")]
        Ilidža,
        [Display(Name = "Stari Grad")]
        StariGrad
    }
}
