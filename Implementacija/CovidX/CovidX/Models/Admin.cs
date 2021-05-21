using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class Admin
    {
        [DisplayName("Admin")]
        [Required]
        [Key]
       public int adminId
        {
            get; set;
        }
    }
   
}
