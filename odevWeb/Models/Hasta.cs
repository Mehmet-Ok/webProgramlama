using System.ComponentModel.DataAnnotations;

namespace odevWeb.Models
{
    public class Hasta
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string ad { get; set; }

        [Required]
        public string soyad { get; set; }
    }
}
