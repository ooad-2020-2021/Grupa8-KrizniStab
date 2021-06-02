using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
