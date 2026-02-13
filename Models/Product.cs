namespace dotnet_e_commerce.Models;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; } = null!;
    public double Price { get; set; }
    public string Image { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool IsActive { get; set; }
    public bool HomePage { get; set; }
}
