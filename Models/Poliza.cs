using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;

namespace Seguroquesi.Models
{
    public class Poliza
    {
        public Guid Id { get; set; }
        public required string NumeroPoliza { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Guid TomadorId { get; set; }
        public required Tomador Tomador { get; set; }

        public Guid CotizacionId { get; set; }
        [ForeignKey("CotizacionId")]
        public required Cotizacion Cotizacion { get; set; }

        public Guid ProductoSeguroId { get; set; }
        public required ProductoSeguro ProductoSeguro { get; set; }

        public RamoId Tipo { get; set; }
        public EstadoPoliza Estado { get; set; }
        public MonedaPoliza Moneda { get; set; }

        public Pais Pais { get; set; } // Si quieres que sea enum
        // public string Pais { get; set; } // O como string libre

        public decimal MontoTotal { get; set; }
        public decimal Prima { get; set; }
        public decimal MontoEstimado { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal MontoPendiente { get; set; }
        public decimal MontoRestante { get; set; }


        public CoberturaCoche Cobertura { get; set; }
        public required string Descripcion { get; set; }
        public required string Observaciones { get; set; }

        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaUltimoPago { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public CondicionesPoliza? CondicionesPoliza { get; set; }

        public ICollection<Siniestro> Siniestros { get; set; } = new List<Siniestro>();
        public ICollection<DocumentoAdjunto> DocumentosAdjuntos { get; set; } = new List<DocumentoAdjunto>();
    }
}
