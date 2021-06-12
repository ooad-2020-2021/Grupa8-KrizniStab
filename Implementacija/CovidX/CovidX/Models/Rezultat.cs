using System.ComponentModel.DataAnnotations;

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

