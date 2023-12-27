using Microsoft.EntityFrameworkCore;

namespace webProgramlama.Models
{
    public class Context:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-F24VUMT\\SQLEXPRESS01;database=hastaneOtomasyon; integrated security=true;");


        }

        public DbSet<AnaBilimDali> AnaBilimDalis { get; set; }
        public DbSet<Doktor> Doktors { get; set; }
        public DbSet<Hasta> Hastas { get; set; }
        public DbSet<KayitliRandevu> KayitliRandevus { get; set; }
        public DbSet<Poliklinik> Polikliniks { get; set; }
        public DbSet<Randevu> Randevus { get; set; }

    }
}
