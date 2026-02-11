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
                        Image = "1.jpeg",
                        Description =
                            "Apple Watch 10 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 10 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "Apple Watch 11",
                        Price = 899.99,
                        IsActiv = true,
                        HomePage = true,
                        Image = "2.jpeg",
                        Description =
                            "Apple Watch 11 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 11 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName = "Apple Watch 12",
                        Price = 349.99,
                        IsActiv = true,
                        HomePage = false,
                        Image = "3.jpeg",
                        Description =
                            "Apple Watch 12 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 12 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "Apple Watch 13",
                        Price = 1199.99,
                        IsActiv = true,
                        HomePage = false,
                        Image = "4.jpeg",
                        Description =
                            "Apple Watch 13 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 13 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                    },
                    new Product
                    {
                        Id = 5,
                        ProductName = "Apple Watch 14",
                        Price = 349.99,
                        IsActiv = true,
                        HomePage = true,
                        Image = "5.jpeg",
                        Description =
                            "Apple Watch 14 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 14 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                    },
                    new Product
                    {
                        Id = 6,
                        ProductName = "Apple Watch 15",
                        Price = 349.99,
                        IsActiv = true,
                        HomePage = true,
                        Image = "6.jpeg",
                        Description =
                            "Apple Watch 15 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 15 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                    },
                    new Product
                    {
                        Id = 7,
                        ProductName = "Apple Watch 16",
                        Price = 349.99,
                        IsActiv = true,
                        HomePage = true,
                        Image = "7.jpeg",
                        Description =
                            "Apple Watch 16 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 16 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                    },
                    new Product
                    {
                        Id = 8,
                        ProductName = "Apple Watch 17",
                        Price = 349.99,
                        IsActiv = true,
                        HomePage = true,
                        Image = "8.jpeg",
                        Description =
                            "Apple Watch 17 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 17 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                    },
                }
            );
    }
}
