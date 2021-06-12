using System.ComponentModel.DataAnnotations;

namespace CovidX.Models
{
    public class Start
    {
        [Key]
        [Required]
        public int id { get; set; }

        Start() { }
        Start(int id) { this.id = id; }
    }
}
