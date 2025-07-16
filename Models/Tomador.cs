using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;

namespace Seguroquesi.Models
{
    public class Tomador
    {
        [Key]
        public Guid Id { get; set; }

        // Nombre Completo
        [Required]
        public required string PrimerNombre { get; set; }
        public required string SegundoNombre { get; set; }
        [Required]
        public required string PrimerApellido { get; set; }
        public required string SegundoApellido { get; set; }
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto => $"{PrimerNombre} {SegundoNombre} {PrimerApellido} {SegundoApellido}";

        // Información de contacto
        [Required, EmailAddress]
        public required string Email { get; set; }

        [Required, Phone]
        public required string Telefono { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public required string Direccion { get; set; }

        // Ubicación (elije según país)
        public Ciudad? Ciudad { get; set; }
        public CiudadEspana? CiudadEspana { get; set; }
        public Provincia? Provincia { get; set; }
        public ProvinciaEspana? ProvinciaEspana { get; set; }

        [Required]
        public Pais Pais { get; set; }

        [Required]
        public int CodigoPostal { get; set; }

        // Identificación personal
        [Required]
        public TipoDocumentoPersona Documento { get; set; }

        [Required]
        public required string NumeroDocumento { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public Genero Genero { get; set; }

        [Required]
        public Pais Nacionalidad { get; set; }

        public RolUsuario Rol { get; set; } = RolUsuario.Cliente;
        public bool EsEmpresa { get; set; }

        // Relaciones
        public ICollection<Poliza> Polizas { get; set; } = new List<Poliza>();
        public ICollection<Cotizacion> Cotizaciones { get; set; } = new List<Cotizacion>();
        public ICollection<DocumentoAdjunto> DocumentosAdjuntos { get; set; } = new List<DocumentoAdjunto>();
        public ICollection<Siniestro> Siniestros { get; set; } = new List<Siniestro>();
    }
}
