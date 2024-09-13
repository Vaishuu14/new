using EmployeeManagment.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Models
{
    public class AppDBContext : DbContext
    {
        
        public AppDBContext(DbContextOptions options) : base(options)
        {


        }


        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    ID = 1,
                    Name = "Vaishnavi",
                    Email = "vaishnavi@123gmail.com",
                    Phone = "123456789"
                },
                new Employee()
                {
                    ID = 2,
                    Name = "Shitole",
                    Email = "shitole@123gmail.com",
                    Phone = "987654321"
                }

                );
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee()
        //        {
        //            ID = 1,
        //            Name
        //        }
        //        );
        //}

    }
}
