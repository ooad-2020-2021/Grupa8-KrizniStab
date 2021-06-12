using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{
    public class KartonOsoblja : Karton
    {

        [DisplayName("Status osoblja:")]
        [EnumDataType(typeof(StatusOsoblja))]
        [Required]
        public StatusOsoblja statusOsoblja { get; set; }

        public KartonOsoblja(string brojKartona, bool kriticnaGrupa, StatusOsoblja statusOsoblja) : base(brojKartona, kriticnaGrupa)

        {
            this.statusOsoblja = statusOsoblja;
        }
    }

}
