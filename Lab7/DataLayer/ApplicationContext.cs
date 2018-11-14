using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public sealed class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Poi> Pois { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Server=localhost;Database=Laborator7;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<City>()
                .Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<City>().HasMany<Poi>();
        }

    }
}
