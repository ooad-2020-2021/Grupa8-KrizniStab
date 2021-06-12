using System.ComponentModel.DataAnnotations;

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
