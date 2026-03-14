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

    public IActionResult List(string url, string q)
    {
        var query = _context.Products.Where(i => i.IsActive);
        if (!string.IsNullOrEmpty(url))
        {
            query = query.Where(item => item.Category.Url == url);
        }
        if (!string.IsNullOrEmpty(q))
        {
            query = query.Where(item => item.ProductName.ToLower().Contains(q.ToLower()));
        }
        return View(query.ToList());
    }

    public ActionResult Details(int id)
    {
        var product = _context.Products.FirstOrDefault(item => item.Id == id);

        if (product == null)
        {
            return RedirectToAction("Index", "Home");
        }

        ViewData["SmilarProducts"] = _context
            .Products.Where(i => i.IsActive && i.CategoryId == product.CategoryId && i.Id != id)
            .Take(4)
            .ToList();
        return View(product);
    }
}
