using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class MedicinskaSestra : Osoba
    {
        public MedicinskaSestra(String ime, String prezime, String jmbg, DateTime datumRodjenja, String telefon, String mail, Spol spol, String brojKartona, DateTime datumZadnjegTestiranja, Lokacija lokacija) : base(ime,  prezime,  jmbg,  datumRodjenja,  telefon,  mail,  spol,  brojKartona)
        {
            this.datumZadnjegTestiranja = datumZadnjegTestiranja;
            this.lokacija = lokacija;
        }
        [DataType(DataType.Date)]
        [DisplayName("Datum zadnjeg testiranja:")]
        public DateTime datumZadnjegTestiranja
        {
            get; set;
        }
        [Required]
        [DisplayName("Lokacija:")]
        [EnumDataType(typeof(Lokacija))]
        public Lokacija lokacija
        {
            get; set;
        }

     }
}
