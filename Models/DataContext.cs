using Microsoft.EntityFrameworkCore;

namespace dotnet_e_commerce.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Slider> Sliders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder
            .Entity<Slider>()
            .HasData(
                new List<Slider>
                {
                    new Slider
                    {
                        Id = 1,
                        ImageUrl = "slider-1.jpeg",
                        Title = "Discover the Latest Tech Trends",
                        Description =
                            "Explore our wide range of cutting-edge technology products, from smartwatches to laptops, and stay ahead in the digital world.",
                        IsActive = true,
                        Index = 1,
                    },
                    new Slider
                    {
                        Id = 2,
                        ImageUrl = "slider-2.jpeg",
                        Title = "Upgrade Your Lifestyle with Smart Devices",
                        Description =
                            "Transform your daily routine with our selection of smart devices, designed to enhance convenience and connectivity in your life.",
                        IsActive = true,
                        Index = 2,
                    },
                    new Slider
                    {
                        Id = 3,
                        ImageUrl = "slider-3.jpeg",
                        Title = "Experience Innovation at Your Fingertips",
                        Description =
                            "Discover the future of technology with our innovative products that combine style, functionality, and performance for an unparalleled user experience.",
                        IsActive = true,
                        Index = 3,
                    },
                }
            );
        modelBuilder
            .Entity<Category>()
            .HasData(
                new List<Category>
                {
                    new Category
                    {
                        Id = 1,
                        CategoryName = "Smart Watches",
                        Url = "smart-watches",
                    },
                    new Category
                    {
                        Id = 2,
                        CategoryName = "Laptops",
                        Url = "laptops",
                    },
                    new Category
                    {
                        Id = 3,
                        CategoryName = "Telephone",
                        Url = "telephone",
                    },
                    new Category
                    {
                        Id = 4,
                        CategoryName = "Headphones",
                        Url = "headphones",
                    },
                    new Category
                    {
                        Id = 5,
                        CategoryName = "Electronics",
                        Url = "electronics",
                    },
                    new Category
                    {
                        Id = 6,
                        CategoryName = "computers",
                        Url = "computers",
                    },
                    new Category
                    {
                        Id = 7,
                        CategoryName = "category-1",
                        Url = "category-1",
                    },
                    new Category
                    {
                        Id = 8,
                        CategoryName = "category-2",
                        Url = "category-2",
                    },
                    new Category
                    {
                        Id = 9,
                        CategoryName = "category-3",
                        Url = "category-3",
                    },
                    new Category
                    {
                        Id = 10,
                        CategoryName = "category-4",
                        Url = "category-4",
                    },
                }
            );

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
                        IsActive = true,
                        HomePage = true,
                        Image = "1.jpeg",
                        Description =
                            "Apple Watch 10 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 10 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 2,
                        ProductName = "Apple Watch 11",
                        Price = 899.99,
                        IsActive = false,
                        HomePage = true,
                        Image = "2.jpeg",
                        Description =
                            "Apple Watch 11 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 11 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 3,
                        ProductName = "Apple Watch 12",
                        Price = 349.99,
                        IsActive = true,
                        HomePage = false,
                        Image = "3.jpeg",
                        Description =
                            "Apple Watch 12 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 12 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 4,
                        ProductName = "Apple Watch 13",
                        Price = 1199.99,
                        IsActive = true,
                        HomePage = false,
                        Image = "4.jpeg",
                        Description =
                            "Apple Watch 13 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 13 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                        CategoryId = 5,
                    },
                    new Product
                    {
                        Id = 5,
                        ProductName = "Apple Watch 14",
                        Price = 349.99,
                        IsActive = true,
                        HomePage = true,
                        Image = "5.jpeg",
                        Description =
                            "Apple Watch 14 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 14 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                        CategoryId = 5,
                    },
                    new Product
                    {
                        Id = 6,
                        ProductName = "Apple Watch 15",
                        Price = 349.99,
                        IsActive = false,
                        HomePage = true,
                        Image = "6.jpeg",
                        Description =
                            "Apple Watch 15 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 15 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                        CategoryId = 5,
                    },
                    new Product
                    {
                        Id = 7,
                        ProductName = "Apple Watch 16",
                        Price = 349.99,
                        IsActive = true,
                        HomePage = true,
                        Image = "7.jpeg",
                        Description =
                            "Apple Watch 16 is the latest smartwatch from Apple, featuring a sleek design, advanced healt tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 16 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                        CategoryId = 1,
                    },
                    new Product
                    {
                        Id = 8,
                        ProductName = "Apple Watch 17",
                        Price = 349.99,
                        IsActive = false,
                        HomePage = true,
                        Image = "8.jpeg",
                        Description =
                            "Apple Watch 17 is the latest smartwatch from Apple, featuring a sleek design, advanced health tracking capabilities, and seamless integration with iOS devices. With its powerful performance and innovative features, the Apple Watch 17 is the perfect companion for fitness enthusiasts and tech-savvy individuals alike.",
                        CategoryId = 1,
                    },
                }
            );
    }
}
