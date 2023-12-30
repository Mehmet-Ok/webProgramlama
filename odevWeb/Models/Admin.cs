using System.ComponentModel.DataAnnotations;

namespace odevWeb.Models
{
    public class Admin
    {
        [Key]
        [Required]
        public int ID {  get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
