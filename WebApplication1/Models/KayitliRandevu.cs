using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class KayitliRandevu
    {
        [Key]
        public int KayitliRandevuId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int RandevuId { get; set; }
    }
}
