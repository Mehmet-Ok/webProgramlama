using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Entities
{
    public class DatabaseContext : DbContext 
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

		public DbSet<User> Users { get; set; }
		public DbSet<AnaBilimDali> AnaBilimDalis { get; set; }
		public DbSet<Poliklinik> Polikliniks { get; set; }
		
		public DbSet<Doktor> Doktors { get; set; }
		public DbSet<Randevu> Randevus { get; set; }
		public DbSet<KayitliRandevu> KayitliRandevus { get; set; }



    }
}
