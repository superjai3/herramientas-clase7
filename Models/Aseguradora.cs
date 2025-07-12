using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace clase7.Models
{
    public class Aseguradora
    {
        public Guid Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public TipoDocumentoEmpresa Documento { get; set; } // DNI / NIE / CUIT / CIF
        public string Contacto { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string Telefono { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Direccion { get; set; }

        [Required]
        public Guid? PaisId { get; set; } // Identificador del país
        public Pais Pais { get; set; } // Argentina o España

        public ICollection<ProductoSeguro> Productos { get; set; } = new List<ProductoSeguro>();
    }
}
