using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{
    public class Pacijent : IdentityUser
    {
        [Required]
        [DisplayName("Ime:")]
        public string ime
        {
            get; set;
        }
        [Required]
        [DisplayName("Prezime:")]
        public string prezime
        {
            get; set;
        }
        [Key]
        [Required]
        [DisplayName("JMBG:")]
        public string jmbg
        {
            get; set;
        }
        [Required]
        [DisplayName("Datum rođenja:")]
        [DataType(DataType.Date)]
        public DateTime datumRodjenja
        {
            get; set;
        }
        [DisplayName("Telefon:")]
        public string telefon { get; set; }

        [DisplayName("Mail:")]
        [Required]
        public string mail
        {
            get; set;
        }
        [DisplayName("Spol:")]
        [EnumDataType(typeof(Spol))]
        public Spol spol { get; set; }
        [DisplayName("Broj kartona:")]
        [Required]
        public string brojKartona { get; set; }


    }
}
