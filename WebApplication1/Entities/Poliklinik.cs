using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
	public class Poliklinik
	{
		[Key]
		public int PoliId { get; set; }

		[Required]
		public string Name { get; set; }

		[ForeignKey("AnaId")]
		public int AnaId { get; set; }

	}
}
