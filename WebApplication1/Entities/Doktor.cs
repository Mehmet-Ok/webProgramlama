using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
	public class Doktor
	{
		[Key]
		public int DoktorId { get; set; }

		[Required]
		public string DoktorName { get; set; }

		public string PoliName { get; set; }

	}
}
