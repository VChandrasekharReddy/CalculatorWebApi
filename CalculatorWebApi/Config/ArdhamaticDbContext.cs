using Microsoft.EntityFrameworkCore;

namespace CalculatorWebApi.Config
{
    public class ArdhamaticDbContext:DbContext
    {
        public DbSet<model.Entity.Arthamatic> Arthamatic { get; set; }
        public ArdhamaticDbContext(DbContextOptions<ArdhamaticDbContext> options) : base(options)
        {
        }                                                               
    }
}
