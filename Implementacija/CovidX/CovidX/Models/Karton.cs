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
        [Key]
        [DisplayName("Broj kartona:")]
        public String brojKartona { get; set; }
        [Required]
        [DisplayName("Kritična grupa:")]
        public Boolean kriticnaGrupa { get; set; }
        [NotMapped]
        [DisplayName("Testovi:")]
        public List<Test> testovi { get; set; }
        public Karton(String brKartona, Boolean kriticna, List<Test> tests = null)
        {
            brojKartona = brKartona;
            kriticnaGrupa = kriticna;
            if(tests != null)
            {
                testovi = tests;
            }
        }
    }
}
