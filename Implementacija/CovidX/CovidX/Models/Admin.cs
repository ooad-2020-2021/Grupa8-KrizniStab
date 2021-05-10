using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class Admin
    {
        [NotMapped]
        public List<MedicinskaSestra> medicinskoOsoblje { get; set; }
        [NotMapped]
        public List<RezervacijaTestiranja> listaTermina { get; set; }
    }
   
}
