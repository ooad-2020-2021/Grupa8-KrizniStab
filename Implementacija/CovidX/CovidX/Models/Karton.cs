using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{
    public abstract class Karton
    {
        [Required]
        [Key]
        public int kartonId { get; set; }

        [DisplayName("Broj kartona:")]
        [Required]
        public string brojKartona { get; set; }
        [Required]
        [DisplayName("Kritična grupa:")]
        public bool kriticnaGrupa { get; set; }

        public Karton(string brojKartona, bool kriticnaGrupa)
        {
            this.brojKartona = brojKartona;
            this.kriticnaGrupa = kriticnaGrupa;


        }
    }
}
