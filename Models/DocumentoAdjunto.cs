using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;


namespace Seguroquesi.Models
{
    public class DocumentoAdjunto
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public required string NombreArchivo { get; set; }

        public required byte[] Contenido { get; set; } // Usar solo si almacenás el archivo en la BD

        [Required]
        public required string TipoContenido { get; set; }

        public DateTime FechaSubida { get; set; } = DateTime.UtcNow;

        // Documento asociado a una póliza
        [Required]
        public Guid PolizaId { get; set; }
        public required Poliza Poliza { get; set; }

        // Documento también puede estar relacionado con un siniestro (opcional)
        public Guid? SiniestroId { get; set; }
        public required Siniestro Siniestro { get; set; }
    }
}
