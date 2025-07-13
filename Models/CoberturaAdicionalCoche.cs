using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;

namespace Seguroquesi.Models
{
    public class CoberturaAdicionalCoche
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public CoberturaAdicionalCocheTipo TipoCobertura { get; set; }

        // Relación con ProductoSeguro
        [Required]
        public Guid ProductoSeguroId { get; set; }
        public ProductoSeguro? ProductoSeguro { get; set; }
    }
}
