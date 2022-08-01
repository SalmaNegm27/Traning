namespace Traning
{
    using Microsoft.EntityFrameworkCore;
    using Traning.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
