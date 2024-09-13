using Microsoft.EntityFrameworkCore;
using StudentManagment.Models;

namespace StudentManagment.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Entrollment { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Entrollment> Entrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Entrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Entrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Entrollments)
                .HasForeignKey(e => e.CourseId);
        }
    }

}

