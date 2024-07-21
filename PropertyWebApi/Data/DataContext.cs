using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Property> Properties {get; set;}

        public DbSet<PropertyType> PropertyTypes {get; set;}

        public DbSet<FurnishingType> FurnishingTypes {get; set;}

    }

    public class YourDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=hspa;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new DataContext(optionsBuilder.Options);
        }
    }
}