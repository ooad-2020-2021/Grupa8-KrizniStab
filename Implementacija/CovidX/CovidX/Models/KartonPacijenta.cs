using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class KartonPacijenta : Karton
    {
        public KartonPacijenta(String brKartona, Boolean kriticna, List<Test> tests, StatusPacijenta statusPacijenta) : base(brKartona, kriticna, tests)

        {
            this.statusPacijenta = statusPacijenta;
        }
        public StatusPacijenta statusPacijenta { get; set; }
    }
}
