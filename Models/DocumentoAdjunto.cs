using System;
using System.ComponentModel.DataAnnotations;

namespace clase7.Models
{
    public class DocumentoAdjunto
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string NombreArchivo { get; set; }

        public byte[] Contenido { get; set; } // Usar solo si almacenás el archivo en la BD

        [Required]
        public string TipoContenido { get; set; }

        public DateTime FechaSubida { get; set; } = DateTime.UtcNow;

        // Documento asociado a una póliza
        [Required]
        public Guid PolizaId { get; set; }
        public Poliza Poliza { get; set; }

        // Documento también puede estar relacionado con un siniestro (opcional)
        public Guid? SiniestroId { get; set; }
        public Siniestro Siniestro { get; set; }
    }
}
