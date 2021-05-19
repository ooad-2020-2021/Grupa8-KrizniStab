using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class Admin
    {
        [NotMapped]
        [DisplayName("Medicinsko osoblje:")]
        public List<MedicinskaSestra> medicinskoOsoblje { get; set; }
        [NotMapped]
        [DisplayName("Lista termina:")]
        public List<RezervacijaTestiranja> listaTermina { get; set; }
    }
   
}
