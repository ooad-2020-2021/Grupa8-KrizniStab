using System.ComponentModel.DataAnnotations;

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
