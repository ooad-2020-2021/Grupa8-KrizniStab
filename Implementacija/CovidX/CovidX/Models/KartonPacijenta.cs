using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{
    public class KartonPacijenta : Karton
    {
        [DisplayName("Status pacijenta:")]
        [EnumDataType(typeof(StatusPacijenta))]
        [Required]
        public StatusPacijenta statusPacijenta { get; set; }

        public KartonPacijenta(string brojKartona, bool kriticnaGrupa, StatusPacijenta statusPacijenta) : base(brojKartona, kriticnaGrupa)

        {
            this.statusPacijenta = statusPacijenta;
        }


    }
}
