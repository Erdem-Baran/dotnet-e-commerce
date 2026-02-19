using System.Diagnostics;
using dotnet_e_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_e_commerce.Controllers;

public class HomeController : Controller
{
    private readonly DataContext _context;

    public HomeController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        var products = _context.Products.Where(item => item.IsActive && item.HomePage).ToList();
        ViewData["Categories"] = _context.Categories.ToList();
        return View(products);
    }
}
