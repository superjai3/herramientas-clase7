using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;

namespace Seguroquesi.Models
{
    public class Poliza
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string NumeroPoliza { get; set; } = string.Empty;

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFin { get; set; }

        // Relaciones
        public Guid CotizacionId { get; set; }
        [ForeignKey("CotizacionId")]
        public Cotizacion? Cotizacion { get; set; }

        // Enums
        [Display(Name = "Ramo")]
        public RamoId Tipo { get; set; }

        public MonedaPoliza Moneda { get; set; }
        public Pais Pais { get; set; }
        public CoberturaCoche Cobertura { get; set; }

        // Valores económicos
        public decimal Prima { get; set; }

        // Datos del tomador y póliza
        [Required]
        public string NumeroDocumento { get; set; } = string.Empty;

        [Required]
        public TipoDocumentoPersona TipoDocumentoPersona { get; set; }

        [Required]
        public string NombreTomador { get; set; } = string.Empty;

        [Required]
        public string ApellidoTomador { get; set; } = string.Empty;

        [Required]
        public string Ciudad { get; set; } = string.Empty;

        [Required]
        public string CodigoPostal { get; set; } = string.Empty;

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public Genero Genero { get; set; }

        // Propiedades de navegación adicionales
        public CondicionesPoliza? CondicionesPoliza { get; set; }
        public ICollection<Siniestro> Siniestros { get; set; } = new List<Siniestro>();
        public ICollection<DocumentoAdjunto> DocumentosAdjuntos { get; set; } = new List<DocumentoAdjunto>();
    }
}