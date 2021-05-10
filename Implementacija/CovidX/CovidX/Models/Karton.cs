using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public abstract class Karton
    {
        [Key]
        public String brojKartona { get; set; }
        [Required]
        public Boolean kriticnaGrupa { get; set; }
        [NotMapped]
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
