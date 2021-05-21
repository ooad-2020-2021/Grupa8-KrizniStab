using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
  
    public class Test
    {
        public Test(string idTesta, DateTime datumTestiranja, VrstaTesta vrstaTesta, NamjenaTesta namjenaTesta, Rezultat rezultat)
        {
            this.idTesta = idTesta;
            this.datumTestiranja = datumTestiranja;
            this.vrstaTesta = vrstaTesta;
            this.namjenaTesta = namjenaTesta;
            this.rezultat = rezultat;
        }
        [Key]
        [Required]
        [DisplayName("ID testa:")]
        public string idTesta
        {
            get; set;
        }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Datum testiranja:")]
        public DateTime datumTestiranja
        {
            get; set;
        }
        [Required]
        [DisplayName("Vrsta testa:")]
        [EnumDataType(typeof(VrstaTesta))]
        public VrstaTesta vrstaTesta
        {
            get; set;
        }
        [Required]
        [DisplayName("Namjena testa:")]
        [EnumDataType(typeof(NamjenaTesta))]
        public NamjenaTesta namjenaTesta
        {
            get; set;
        }
        [Required]
        [DisplayName("Rezultat testa:")]
        [EnumDataType(typeof(Rezultat))]
        public Rezultat rezultat { get; set; }
        [Required]
        [DisplayName("Broj kartona:")]
        public string brojKartona { get; set; }

        public DateTime odrediKrajIzolacije(DateTime datumTestiranja)
        {
            return datumTestiranja.AddDays(14);
        }


    }
}
