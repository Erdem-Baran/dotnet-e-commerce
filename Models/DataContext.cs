using Microsoft.EntityFrameworkCore;

namespace dotnet_e_commerce.Models;

public class DataContext : DbContext
{
    public DbSet<Product> Products { get; set; }
}
