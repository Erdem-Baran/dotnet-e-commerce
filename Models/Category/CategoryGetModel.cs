namespace dotnet_store.Models;

public class CategoryGetModel
{
    public int Id { get; set; }
    public string KategoriAdi { get; set; } = null!;
    public string Url { get; set; } = null!;
    public int ProductCount { get; set; }
}
