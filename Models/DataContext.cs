using Microsoft.EntityFrameworkCore;

namespace dotnet_e_commerce.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
            .Entity<Product>()
            .HasData(
                new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        ProductName = "Apple Watch 10",
                        Price = 499.99,
                        IsActiv = true,
                        HomePage = true,
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "Apple Watch 11",
                        Price = 899.99,
                        IsActiv = true,
                        HomePage = true,
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName = "Apple Watch 12",
                        Price = 349.99,
                        IsActiv = true,
                        HomePage = false,
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "Apple Watch 13",
                        Price = 1199.99,
                        IsActiv = true,
                        HomePage = false,
                    },
                    new Product
                    {
                        Id = 5,
                        ProductName = "Apple Watch 14",
                        Price = 349.99,
                        IsActiv = true,
                        HomePage = true,
                    },
                }
            );
    }
}
