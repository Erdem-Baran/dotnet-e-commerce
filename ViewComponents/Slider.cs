using dotnet_e_commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_e_commerce.ViewComponents;

public class Slider : ViewComponent
{
    private readonly DataContext _context;

    public Slider(DataContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        return View(_context.Sliders.ToList());
    }
}