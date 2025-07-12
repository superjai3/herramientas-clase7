using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace clase7.Models
{
    public class Tomador
    {
        [Key]
        public Guid Id { get; set; }

        // Nombres y apellidos
        [Required]
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        // Información de contacto
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string Telefono { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        // Domicilio
        public string Direccion { get; set; }

        // Identificadores de ubicación
        [Required]
        public Guid? CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }

        [Required]
        public Guid? ProvinciaId { get; set; }
        public Provincia Provincia { get; set; }

        [Required]
        public Guid? PaisId { get; set; }
        public Pais Pais { get; set; }

        [Required]
        public int CodigoPostal { get; set; }

        // Identificación personal
        [Required]
        public TipoDocumento Documento { get; set; }

        [Required]
        public string NumeroDocumento { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public Genero Genero { get; set; }

        [Required]
        public Nacionalidad Nacionalidad { get; set; }

        // Información adicional
        public RolUsuario Rol { get; set; }
        public bool EsEmpresa { get; set; }

        // Relaciones con otras entidades
        public ICollection<Poliza> Polizas { get; set; } = new List<Poliza>();
        public ICollection<Cotizacion> Cotizaciones { get; set; } = new List<Cotizacion>();
        public ICollection<DocumentoAdjunto> DocumentosAdjuntos { get; set; } = new List<DocumentoAdjunto>();
        public ICollection<Siniestro> Siniestros { get; set; } = new List<Siniestro>();
    }
}
