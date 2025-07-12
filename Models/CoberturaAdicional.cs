using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace clase7.Models
{
    public class CoberturaAdicional
    {
        public Guid Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoAdicional { get; set; }

        // Relación con ProductoSeguro
        public Guid ProductoSeguroId { get; set; }          // FK explícita
        public ProductoSeguro ProductoSeguro { get; set; }  // Navegación
    }
}
