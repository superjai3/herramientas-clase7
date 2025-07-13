using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;

namespace Seguroquesi.Models
{
    public class ProductoSeguro
    {
        [Key]
        public Guid ProductoSeguroId { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(100)]
        public required string Nombre { get; set; }

        [StringLength(500)]
        public required string Descripcion { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "La prima base debe ser mayor o igual a 0.")]
        public decimal PrimaBase { get; set; }

        [Required(ErrorMessage = "El ramo del seguro es obligatorio.")]
        public RamoId RamoId { get; set; }

        public required string CoberturaCoche { get; set; }

        [Required]
        public Guid AseguradoraId { get; set; }
        public required Aseguradora Aseguradora { get; set; }

        public ICollection<CoberturaAdicionalCoche> CoberturasAdicionalesCoche { get; set; } = new List<CoberturaAdicionalCoche>();
    }
}
