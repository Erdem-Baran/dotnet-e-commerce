using Microsoft.EntityFrameworkCore;

namespace dotnet_e_commerce.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<Product> Products { get; set; }
}
