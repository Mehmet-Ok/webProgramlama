using System.ComponentModel.DataAnnotations;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class RandevuUserViewModel
    {
        
        public int RandevuId { get; set; }
        public int DoktorId { get; set; }
        public int PoliId { get; set; }
        public DateTime RandevuTarih { get; set; }
        public int RandevuDurum { get; set; }
        public string RandevuSaat { get; set; }
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string UserName { get; set; }

     
    }
}
