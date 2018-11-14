using Microsoft.EntityFrameworkCore;

namespace DataLayer 
{
    public sealed class PoisContext : DbContext
    {
        public PoisContext(DbContextOptions<PoisContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Poi> Pois { get; set; }
    }
}
