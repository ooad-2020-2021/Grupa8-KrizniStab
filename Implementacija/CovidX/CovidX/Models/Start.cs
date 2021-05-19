using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CovidX.Models
{
    public class Start
    {
        [Key]
        [Required]
        public int id { get; set; }

        Start() { }
        Start(int id) { this.id = id;  }
    }
}
