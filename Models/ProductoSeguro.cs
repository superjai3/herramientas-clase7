using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace clase7.Models
{
    public class ProductoSeguro
    {
        public Guid ProductoSeguroId { get; set; }

        [Required]
        public string Nombre { get; set; } // Seguro de Vida, Auto, Salud, RC, etc.

        public string Descripcion { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrimaBase { get; set; } // Precio base

        public RamoId RamoId { get; set; } // Identificador del ramo

        public string Cobertura { get; set; }

        public Guid AseguradoraId { get; set; }
        public Aseguradora Aseguradora { get; set; }

        // Relación Uno a Muchos con CoberturaAdicionalCoche
        public ICollection<CoberturaAdicionalCoche> CoberturaAdicionalCoche { get; set; } = new List<CoberturaAdicionalCoche>();

    }
}
