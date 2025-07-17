using Microsoft.AspNetCore.Mvc;
using Seguroquesi.ViewModels;
using Seguroquesi.Data;
using Seguroquesi.Models;

public class ContactoController : Controller
{
    private readonly AppDbContext _context;

    public ContactoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Enviar([FromBody] ContactoViewModel model)
    {
        if (!ModelState.IsValid)
            return BadRequest("Datos inválidos");

        var contacto = new Contacto
        {
            Nombre = model.Nombre,
            Email = model.Email,
            Mensaje = model.Mensaje
        };

        _context.Contactos.Add(contacto);
        _context.SaveChanges();

        return Ok("¡Gracias por contactarnos! Te responderemos pronto.");
    }

    [HttpGet]
    public IActionResult Mensajes()
    {
        var mensajes = _context.Contactos
            .OrderByDescending(c => c.Fecha)
            .ToList();

        return View(mensajes);
    }
}