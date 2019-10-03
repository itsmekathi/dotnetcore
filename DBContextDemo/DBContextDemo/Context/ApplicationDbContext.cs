using DBContextDemo.Models;
using DBContextDemo.Models.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DBContextDemo.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employess { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure default schema
            modelBuilder.ApplyConfiguration(new StudentMapping());
        }
    }
}
