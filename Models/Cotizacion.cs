namespace clase7.Models;

public class Cotizacion
{
    public Guid Id { get; set; }
    public DateTime FechaSolicitud { get; set; }

    public Guid TomadorId { get; set; }
    public Tomador Tomador { get; set; }

    public Guid ProductoSeguroId { get; set; }
    public ProductoSeguro ProductoSeguro { get; set; }

    public decimal MontoEstimado { get; set; }
    public EstadoCotizacion Estado { get; set; } // Pendiente, Aceptada, Rechazada

    public Poliza? Poliza { get; set; }  // Navegación inversa

}
