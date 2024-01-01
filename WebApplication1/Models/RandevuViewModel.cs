using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
	public class RandevuViewModel
	{
		public int RandevuId { get; set; }
		public string DoktorId { get; set; }
		public string PoliId { get; set; }
		public DateTime RandevuTarih { get; set; }
		public int RandevuDurum { get; set; }
		public string RandevuSaat { get; set; }
	}
}
