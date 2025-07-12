namespace clase7.Models;

public class Siniestro
{
    public Guid Id { get; set; } // Identificador único del siniestro
    public Guid PolizaId { get; set; } // Cada siniestro pertenece a una sola póliza, y guarda la clave foránea PolizaId.
    public Poliza Poliza { get; set; } // cada siniestro pertenece a una sola póliza, y guarda la clave foránea PolizaId.

    public DateTime FechaSiniestro { get; set; }
    public string Descripcion { get; set; }
    public string Estado { get; set; } // En Revisión, Aprobado, Rechazado
    public string Observaciones { get; set; }
}
