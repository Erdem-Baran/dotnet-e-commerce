using dotnet_e_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_e_commerce.Controllers;

public class ProductController : Controller
{
    private readonly DataContext _context;

    public ProductController(DataContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult List(string url)
    {
        var products = _context
            .Products.Where(item => item.IsActive && item.Category.Url == url)
            .ToList();
        return View(products);
    }

    public ActionResult Details(int id)
    {
        var product = _context.Products.FirstOrDefault(item => item.Id == id);
        return View(product);
    }
}
