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

        [DisplayName("Status osoblja:")]
        [EnumDataType(typeof(StatusOsoblja))]
       
        public StatusOsoblja statusOsoblja { get; set; }

        public KartonOsoblja(string brojKartona, bool kriticnaGrupa, StatusOsoblja statusOsoblja) : base(brojKartona, kriticnaGrupa)

        {
            this.statusOsoblja = statusOsoblja;
        }
    }

}
