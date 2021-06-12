using System.ComponentModel.DataAnnotations;

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
