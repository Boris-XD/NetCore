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

        public DbSet<Course> Courses { get; set; }

        public DbSet<Price> Price { get; set; }

        public DbSet<Commentary> Comments { get; set; }
    }
}