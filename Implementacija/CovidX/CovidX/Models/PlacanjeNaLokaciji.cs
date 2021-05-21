using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class PlacanjeNaLokaciji : Placanje
    {
        public PlacanjeNaLokaciji(int placanjeId, DateTime datumUplate, double iznosUplate, bool placanjeIzvrseno) : base(placanjeId, datumUplate, iznosUplate)
        {
            this.placanjeIzvrseno = placanjeIzvrseno;
        }
        [DisplayName("Placanje izvršeno:")]
        [Required]
        public bool placanjeIzvrseno { get; set; }

    }
}
