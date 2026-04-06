using Microsoft.EntityFrameworkCore;
using W26Week13DatabaseWithAspDotNet.Models;

namespace W26Week13DatabaseWithAspDotNet.Data
{
    public class AppDbContext : DbContext
    {
        // connection string
        // done through constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }


        // define entity sets
        // done by creating DbSet<> properties
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        // data seeding
        // by overriding OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Electronics" },
                new Category { CategoryId = 2, CategoryName = "Clothing" },
                new Category { CategoryId = 3, CategoryName = "Appliances" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Laptop", Price = 1200, CategoryId = 1 },
                new Product { ProductId = 2, Name = "Mobile", Price = 2000, CategoryId = 1 },
                new Product { ProductId = 3, Name = "Jacket", Price = 100, CategoryId = 2 },
                new Product { ProductId = 4, Name = "Fridge", Price = 800, CategoryId = 3 }
            );
        }
    }
}
