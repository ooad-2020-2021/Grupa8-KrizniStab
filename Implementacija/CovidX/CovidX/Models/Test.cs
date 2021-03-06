using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{

    public class Test
    {
        public Test(int idTesta, DateTime datumTestiranja, VrstaTesta vrstaTesta, NamjenaTesta namjenaTesta, Rezultat rezultat, string kartonId)
        {
            this.idTesta = idTesta;
            this.datumTestiranja = datumTestiranja;
            this.vrstaTesta = vrstaTesta;
            this.namjenaTesta = namjenaTesta;
            this.rezultat = rezultat;
            this.kartonId = kartonId;
        }
        [Key]
        [Required]
        [DisplayName("ID testa:")]
        public int idTesta
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
        public string kartonId { get; set; }

        public DateTime odrediKrajIzolacije(DateTime datumTestiranja)
        {
            return datumTestiranja.AddDays(14);
        }

        public Test() { }
    }
}
