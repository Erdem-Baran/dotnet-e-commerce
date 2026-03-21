using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Controllers;

public class CategoryController : Controller
{
    private readonly DataContext _context;

    public CategoryController(DataContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var categories = _context
            .Kategoriler.Select(k => new CategoryGetModel
            {
                Id = k.Id,
                KategoriAdi = k.KategoriAdi,
                Url = k.Url,
                ProductCount = k.Uruns.Count,
            })
            .ToList();
        return View(categories);
    }
}
