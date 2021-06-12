using System.ComponentModel.DataAnnotations;

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
