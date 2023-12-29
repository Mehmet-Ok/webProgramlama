using System.ComponentModel.DataAnnotations;

namespace odevWeb.Models
{
    public class KayitliRandevu
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int randevuID { get; set; }

        [Required]
        public int hastaID { get; set; }
    }
}
