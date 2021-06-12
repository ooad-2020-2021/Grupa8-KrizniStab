using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{
    public class UnosRezultata
    {
        public UnosRezultata(int unosId, int kartonId, int testId, string jmbgMed)
        {
            this.unosId = unosId;
            this.kartonId = kartonId;
            this.testId = testId;
            this.jmbgMed = jmbgMed;
        }
        [Required]
        [Key]
        public int unosId
        {
            get; set;
        }
        [Required]
        [DisplayName("Broj kartona:")]
        public int kartonId
        {
            get; set;
        }
        [Required]
        [DisplayName("Test:")]
        public int testId
        {
            get; set;
        }

        //podaci o sestri koja unosi rezultat
        [Required]
        [DisplayName("Medicinska sestra: ")]
        public string jmbgMed
        {
            get; set;
        }
    }
}
