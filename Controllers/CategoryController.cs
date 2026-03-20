using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class CategoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}