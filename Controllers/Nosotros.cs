using Microsoft.AspNetCore.Mvc;

public class NosotrosController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}