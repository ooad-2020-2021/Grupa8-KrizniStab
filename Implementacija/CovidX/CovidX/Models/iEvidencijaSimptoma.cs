using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    interface IEvidencijaSimptoma
    {
        public bool otezanoDisanjeIliNedostatakDaha { get; set; }
        public bool bolUGrudima { get; set; }
        public bool gubitakGovoraIliPokreta { get; set; }
        public bool povisenaTemperatura { get; set; }
        public bool suhiKasalj { get; set; }
        public bool umor { get; set; }
        public bool glavobolja { get; set; }
        public bool gubitakOkusaIliMirisa { get; set; }
        public bool osipNaKozi { get; set; }
        public void evidentirajSimptome() {}
    }
}
