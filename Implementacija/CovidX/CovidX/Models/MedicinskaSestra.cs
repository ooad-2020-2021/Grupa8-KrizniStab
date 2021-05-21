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
        public MedicinskaSestra(string ime, string prezime, string jmbg, DateTime datumRodjenja, string telefon, string mail, Spol spol, String brojKartona, DateTime datumZadnjegTestiranja, Lokacija lokacija, int adminId) : base(ime,  prezime,  jmbg,  datumRodjenja,  telefon,  mail,  spol,  brojKartona)
        {
            this.datumZadnjegTestiranja = datumZadnjegTestiranja;
            this.lokacija = lokacija;
            this.adminId = adminId;
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
        public int adminId
        {
            get; set;
        }

     }
}
