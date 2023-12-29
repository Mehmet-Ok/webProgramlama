using System.ComponentModel.DataAnnotations;

namespace odevWeb.Models
{
    public class Randevu
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime randevuTarihi { get; set; }

        [Required]
        public int doktorID { get; set; }

        [Required]
        public bool durum { get; set; }
    }
}
