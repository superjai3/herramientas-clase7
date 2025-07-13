using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;

namespace Seguroquesi.Models
{
    public class Aseguradora
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El nombre de la aseguradora es obligatorio.")]
        public required string Nombre { get; set; }

        public TipoDocumentoEmpresa Documento { get; set; } // CUIT, CIF, etc.

        public required string Contacto { get; set; }

        [Required(ErrorMessage = "El email es obligatorio."), EmailAddress]
        public required string Email { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio."), Phone]
        public required string Telefono { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        [Column(TypeName = "varchar(50)")]
        public required string Direccion { get; set; }

        [Required(ErrorMessage = "El país es obligatorio.")]
        public Pais Pais { get; set; } // Enum (Argentina o España)

        // Relación con ProductoSeguro
        public ICollection<ProductoSeguro> Productos { get; set; } = new List<ProductoSeguro>();
    }
}

