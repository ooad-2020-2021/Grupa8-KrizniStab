using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class KartonOsoblja : Karton
    {
        public KartonOsoblja(String brKartona, Boolean kriticna, List<Test> tests, StatusOsoblja statusOsoblja) : base(brKartona, kriticna, tests)

        {
            this.statusOsoblja = statusOsoblja;
        }

        [DisplayName("Status osoblja:")]
        [EnumDataType(typeof(StatusOsoblja))]
        public StatusOsoblja statusOsoblja { get; set; }
    }

}
