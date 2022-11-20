using Employee_Management_System.Models.Employee;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_System.Context
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ZVERZVE-OK6CQT4;Database=Baseofemployees;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
