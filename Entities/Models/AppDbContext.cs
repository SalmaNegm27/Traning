namespace Traning
{
    using Domain.Models;
   
    using Microsoft.EntityFrameworkCore;
   

    public class AppDbContext : DbContext

    {


        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Student> students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }


    }
        
    }

