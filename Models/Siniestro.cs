using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;


namespace Seguroquesi.Models
{

    public class Siniestro
    {
        public Guid Id { get; set; } // Identificador único del siniestro
        public Guid PolizaId { get; set; } // Cada siniestro pertenece a una sola póliza, y guarda la clave foránea PolizaId.
        public required Poliza Poliza { get; set; } // cada siniestro pertenece a una sola póliza, y guarda la clave foránea PolizaId.

        public DateTime FechaSiniestro { get; set; }
        public required string Descripcion { get; set; }
        public required string Estado { get; set; } // En Revisión, Aprobado, Rechazado
        public required string Observaciones { get; set; }
    }
}