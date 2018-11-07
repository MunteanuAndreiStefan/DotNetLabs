using Microsoft.EntityFrameworkCore;

namespace Lab6.Data
{
    public sealed class CityContext : DbContext
    {
        public CityContext(DbContextOptions<CityContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<City> Cities { get; set; }
    }
}
