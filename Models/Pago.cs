namespace clase7.Models;

public class Pago
{
    public Guid Id { get; set; }
    public Guid PolizaId { get; set; }
    public Poliza Poliza { get; set; }

    public DateTime FechaPago { get; set; } = DateTime.UtcNow;

    [Range (typeof(decimal), "0.01", "999999999999999999.99")]
    public decimal MontoPagado { get; set; }
    public MetodoPago MetodoPago { get; set; } // Transferencia, tarjeta, etc.
}
