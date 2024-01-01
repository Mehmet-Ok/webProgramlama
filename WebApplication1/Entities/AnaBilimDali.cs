using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities
{
	public class AnaBilimDali
	{
		[Key]
		public int AnaId { get; set; }

		[Required]
		public string Name { get; set; }
	}
}
