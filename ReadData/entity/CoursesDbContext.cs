using System.Security.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ReadData.entity
{
    public class CoursesDbContext : DbContext
    {
        private const string connectionString = @"Data Source=.; Initial Catalog=CoursesOnline;Integrated Security=true;TrustServerCertificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseInstructor>().HasKey(ci => new { ci.CourseId, ci.InstructorId});
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<Commentary> Commentaries { get; set; }
        public DbSet<CourseInstructor> CourseInstructor { get; set; }
        public DbSet<Instructor> Instructor { get; set; } 
    }
}