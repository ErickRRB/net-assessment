using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Core.Entities;

namespace EmployeeManagement.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Add DI to receive the options (connection string) of the database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the relationship between Employee and Department
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany()
                .HasForeignKey(e => e.DepartmentId);
        }
    }
}