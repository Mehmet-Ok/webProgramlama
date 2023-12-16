using System.ComponentModel.DataAnnotations;

namespace webProgramlama.Models
{
    public class AnaBilimDali
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string ad { get; set; }
    }
}
