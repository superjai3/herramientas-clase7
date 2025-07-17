using System;
using System.ComponentModel.DataAnnotations;

public class Contacto
{
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Mensaje { get; set; } = string.Empty;

    public DateTime Fecha { get; set; } = DateTime.Now;
}