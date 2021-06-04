using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{ 
    public class RezervacijaTestiranjaMed
    {
        public RezervacijaTestiranjaMed()
        {
        }

        public RezervacijaTestiranjaMed(DateTime datumTestiranja, VrstaTesta vrstaTesta, NamjenaTesta namjenaTesta, string jmbgMed, int testId)
        {
            this.datumTestiranja = datumTestiranja;
            this.vrstaTesta = vrstaTesta;
            this.namjenaTesta = namjenaTesta;
            this.jmbgMed = jmbgMed;
            this.testId = testId;
        }
        [Key]
        [Required]
        [DisplayName("ID rezervacije:")]
        public string idRezervacije { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum testiranja:")]
        public DateTime datumTestiranja { get; set; }
        [EnumDataType(typeof(VrstaTesta))]
        [DisplayName("Vrsta testa:")]
        [Required]
        public VrstaTesta vrstaTesta { get; set; }
        [Required]
        [EnumDataType(typeof(NamjenaTesta))]
        [DisplayName("Namjena testa:")]
        public NamjenaTesta namjenaTesta { get; set; }
        [Required]
        [DisplayName("JMBG medicinske sestre:")]
        public string jmbgMed { get; set; }
        [Required]
        [DisplayName("Test:")]
        public int testId { get; set; }
    }
}
