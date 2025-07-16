using System;
using System.ComponentModel.DataAnnotations;
using Seguroquesi.Enums;

namespace Seguroquesi.Models
{
    public class Cotizacion
    {
        public Guid Id { get; set; }

        [Required]
        public string NumeroCotizacion { get; set; } = string.Empty; // Correlativo

        [Required]
        public DateTime FechaCreacion { get; set; } // Fecha de creación de la cotización

        [Required]
        public string NombreTomador { get; set; } = string.Empty;

        [Required]
        public string ApellidoTomador { get; set; } = string.Empty;

        [Required]
        public TipoDocumentoPersona TipoDocumentoPersona { get; set; }

        // Si quieres mantener los campos originales, puedes dejarlos como opcionales:
        public Guid? ProductoSeguroId { get; set; }
        public ProductoSeguro? ProductoSeguro { get; set; }

        public decimal? MontoEstimado { get; set; }
        public EstadoPoliza? Estado { get; set; }

        public Poliza? Poliza { get; set; }  // Navegación inversa
    }
}