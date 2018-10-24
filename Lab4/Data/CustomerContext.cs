using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CustomerContext:DbContext
    {
        public CustomerContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; private set; }
        public DbSet<Customer> Customers { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(customer => customer.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(customer => customer.Address).IsRequired().HasMaxLength(300);
            modelBuilder.Entity<Customer>().Property(customer => customer.PhoneNumber).IsRequired();
            modelBuilder.Entity<Customer>().Property(customer => customer.Email).IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mslocaldb;Database=Products;Trusted_Connection=True;");
        }
    }
}
