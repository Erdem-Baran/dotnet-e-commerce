using dotnet_e_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_e_commerce.ViewComponents;

public class Navbar : ViewComponent
{
    private readonly DataContext _context;
    public Navbar(DataContext context)
    {
        _context = context;
    }
    public IViewComponentResult Invoke()
    {
        return View(_context.Categories.ToList());
    }
}