using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{
    public class Admin : IdentityUser
    {
        [DisplayName("Admin")]
        [Required]
        [Key]
        public int id
        {
            get; set;
        }
        public string email
        {
            get; set;
        }
        public string password
        {
            get; set;
        }
    }

}
