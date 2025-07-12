namespace clase7.Models;

public class Poliza
{
    public Guid Id { get; set; }    // Identificador único de la póliza
    public string NumeroPoliza { get; set; }    // Número de la póliza, único por aseguradora
    public DateTime FechaInicio { get; set; }   // Fecha de inicio de la póliza
    public DateTime FechaFin { get; set; }  // Fecha de fin de la póliza

    public Guid TomadorId { get; set; } // Identificador del Tomador al que pertenece la póliza
    public Tomador Tomador { get; set; }    // Tomador al que pertenece la póliza

    //Relaciones
    public Guid CotizacionId { get; set; }  // Clave foránea
    [ForeignKey("CotizacionId")]
    public Cotizacion Cotizacion { get; set; }

    public Guid ProductoSeguroId { get; set; }  // Identificador del producto de seguro asociado a la póliza
    public ProductoSeguro ProductoSeguro { get; set; }  // Producto de seguro asociado a la póliza

    public RamoId Tipo { get; set; } // Auto, Vida, Hogar, etc.
    public EstadoPoliza Estado { get; set; } // Activa, Vencida, Cancelada
    public MonedaPoliza Moneda { get; set; } // ARS, USD, etc.
    public string Pais { get; set; }

    public decimal MontoTotal { get; set; } // Monto total de la póliza
    public decimal Prima { get; set; }  // Prima de la póliza
    public decimal MontoEstimado { get; set; }  // Monto estimado de la póliza
    public decimal MontoPagado { get; set; }    // Monto pagado hasta la fecha
    public decimal MontoPendiente { get; set; } // Monto pendiente de pago
    public decimal MontoRestante { get; set; }  // Monto restante de la póliza

    public Cobertura Cobertura { get; set; } // Cobertura del seguro, por ejemplo: Todo Riesgo, Responsabilidad Civil, etc.

    public string Descripcion { get; set; } // Descripción de la póliza
    public string Observaciones { get; set; } // Observaciones de la póliza

    public DateTime FechaVencimiento { get; set; } // Fecha de vencimiento de la póliza
    public DateTime FechaUltimoPago { get; set; } // Fecha del último pago realizado
    public DateTime FechaCreacion { get; set; } // Fecha de creación de la póliza
    public DateTime FechaModificacion { get; set; } // Fecha de última modificación de la póliza

    public CondicionesPoliza CondicionesPoliza { get; set; } // Condiciones de la póliza, incluyendo generales, particulares, exclusiones, etc.
    public ICollection<Siniestro> Siniestros { get; set; } = new List<Siniestro>(); // Cada póliza puede tener múltiples siniestros
    public ICollection<DocumentoAdjunto> DocumentosAdjuntos { get; set; } = new List<DocumentoAdjunto>();   // Documentos adjuntos a la póliza
}
