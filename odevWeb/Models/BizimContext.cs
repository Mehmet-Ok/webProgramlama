using Microsoft.EntityFrameworkCore;

namespace odevWeb.Models
{
    public class BizimContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-F24VUMT\\SQLEXPRESS01;Database=hastaneOtomasyon; integrated security=true;");
        }

        public DbSet<Doktor> doktors { get; set; }
        public DbSet<AnaBilimDali> anaBilimDalis { get; set; }
        public DbSet<Hasta> hastas { get; set; }
        public DbSet<KayitliRandevu> kayitliRandevus { get; set; }
        public DbSet<Poliklinik> polikliniks { get; set; }
        public DbSet<Randevu> randevus { get; set; }


    }
}
