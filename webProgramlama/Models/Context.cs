using Microsoft.EntityFrameworkCore;

namespace webProgramlama.Models
{
    public class Context:DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}
