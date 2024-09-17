using Microsoft.EntityFrameworkCore;

namespace EMS1.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Employee>()
                .HasKey(e => e.ID);

    }
}

