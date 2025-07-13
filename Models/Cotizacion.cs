using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;


namespace Seguroquesi.Models
{

    public class Cotizacion
    {
        public Guid Id { get; set; }
        public DateTime FechaSolicitud { get; set; }

        public Guid TomadorId { get; set; }
        public required Tomador Tomador { get; set; }

        public Guid ProductoSeguroId { get; set; }
        public required ProductoSeguro ProductoSeguro { get; set; }

        public decimal MontoEstimado { get; set; }
        public EstadoCotizacion Estado { get; set; } // Pendiente, Aceptada, Rechazada

        public Poliza? Poliza { get; set; }  // Navegación inversa

    }
}