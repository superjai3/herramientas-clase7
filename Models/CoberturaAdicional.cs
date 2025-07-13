using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;


namespace Seguroquesi.Models
{
    public class CoberturaAdicional
    {
        public Guid Id { get; set; }

        [Required]
        public required string Nombre { get; set; }

        public required string Descripcion { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoAdicional { get; set; }

        // Relación con ProductoSeguro
        public Guid ProductoSeguroId { get; set; }          // FK explícita
        public required ProductoSeguro ProductoSeguro { get; set; }  // Navegación
    }
}
