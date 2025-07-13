using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;


namespace Seguroquesi.Models
{
    public class CondicionesPoliza
    {
        [Key, ForeignKey("Poliza")]
        public Guid PolizaId { get; set; } // Es clave primaria y foránea al mismo tiempo.

        public required Poliza Poliza { get; set; }  //Relación 1 a 1 con Póliza.

        public required string Generales { get; set; }
        public required string Particulares { get; set; }
        public required string Especiales { get; set; }
        public required string Exclusiones { get; set; }
        public required string Obligaciones { get; set; }
        public required string Derechos { get; set; }
        public required string Reclamaciones { get; set; }
        public required string Cancelacion { get; set; }
        public required string Renovacion { get; set; }
        public required string Modificacion { get; set; }
        public required string Suspensiones { get; set; }
        public required string Indemnizacion { get; set; }
    }
}
