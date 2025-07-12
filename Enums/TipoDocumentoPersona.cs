using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum TipoDocumentoPersona
    {
        [Display(Name = "DNI (Documento Nacional de Identidad)")]
        DNI,

        [Display(Name = "NIE (Número de Identidad de Extranjero)")]
        NIE,

        [Display(Name = "CUIT (Código Único de Identificación Tributaria)")]
        CUIT
    }
}
