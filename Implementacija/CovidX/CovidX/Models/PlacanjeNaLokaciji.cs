﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class PlacanjeNaLokaciji : Placanje
    {
        public PlacanjeNaLokaciji(DateTime datumUplate, Double iznosUplate, Boolean placanjeIzvrseno) : base(datumUplate, iznosUplate)
        {
            this.placanjeIzvrseno = placanjeIzvrseno;
        }
        [DisplayName("Placanje izvršeno:")]
        [Required]
        public Boolean placanjeIzvrseno { get; set; }

    }
}
