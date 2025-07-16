using Microsoft.AspNetCore.Mvc.Rendering;
using Seguroquesi.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.ViewModels
{
    public class PolizaViewModel
    {
        public PolizaViewModel()
        {
            NumeroCotizacion = string.Empty;
            NombreTomador = string.Empty;
            ApellidoTomador = string.Empty;
            NumeroDocumento = string.Empty;
            CodigoPostal = string.Empty;
        }

        public Guid Id { get; set; }

        [Display(Name = "Número de Cotización")]
        public string NumeroCotizacion { get; set; }

        [Required]
        [Display(Name = "Fecha de inicio")]
        public DateTime FechaInicio { get; set; }

        [Required]
        [Display(Name = "Fecha de fin")]
        public DateTime FechaFin { get; set; }

        [Required]
        [Display(Name = "Tipo de Documento")]
        public TipoDocumentoPersona TipoDocumentoPersona { get; set; }

        [Required]
        [Display(Name = "Número de Documento")]
        public string NumeroDocumento { get; set; }

        [Required]
        [Display(Name = "Nombre del Tomador")]
        public string NombreTomador { get; set; }

        [Required]
        [Display(Name = "Apellido del Tomador")]
        public string ApellidoTomador { get; set; }

        [Required]
        [Display(Name = "Ciudad")]
        public Ciudad Ciudad { get; set; }

        [Required]
        [Display(Name = "Provincia")]
        public Provincia Provincia { get; set; }

        [Required]
        [Display(Name = "Pais")]
        public Pais Pais { get; set; }

        [Required]
        [Display(Name = "Código Postal")]
        public string CodigoPostal { get; set; }

        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Display(Name = "Género")]
        public Genero Genero { get; set; }

        [Required]
        [Display(Name = "Ramo")]
        public RamoId Tipo { get; set; }

        [Required]
        [Display(Name = "Cobertura")]
        public CoberturaCoche Cobertura { get; set; }

        [Required]
        public MonedaPoliza Moneda { get; set; }

        [Required]
        public decimal Prima { get; set; }
    }
}