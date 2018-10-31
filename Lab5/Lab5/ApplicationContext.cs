using Microsoft.EntityFrameworkCore;

namespace Lab5
{
    public class ApplicationContext:DbContext
    {

        public DbSet<City> Cities{ get; private set; }

        public DbSet<Poi> Pois { get; private set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Dotnet;Trusted_Connection=True;");
            }
        }

    }
}
