using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{
    public enum Spol
    {
        [Display(Name = "Muski")]
        MUSKI,
        [Display(Name = "Zenski")]
        ZENSKI
    }
}
