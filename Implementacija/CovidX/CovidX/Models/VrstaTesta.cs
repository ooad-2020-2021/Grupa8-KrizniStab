using System.ComponentModel.DataAnnotations;

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
