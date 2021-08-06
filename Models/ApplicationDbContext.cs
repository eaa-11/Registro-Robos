using Microsoft.EntityFrameworkCore;

namespace Prueba.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public virtual DbSet<Robo> Robos { get; set; }
    }
}
