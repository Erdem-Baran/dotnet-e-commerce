namespace dotnet_e_commerce.Models;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; } = null!;
    public double Price { get; set; }
    public bool IsActiv { get; set; }
    public bool HomePage { get; set; }
}
