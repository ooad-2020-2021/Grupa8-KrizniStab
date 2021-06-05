using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
