using Microsoft.AspNetCore.Mvc;

public class ProductosController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}