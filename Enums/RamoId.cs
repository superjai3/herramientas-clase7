
using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum RamoId    // Identificador del ramo
    {
        [Display(Name = "Seguro de Vida")]
        Vida,

        [Display(Name = "Seguro de Auto")]
        Auto,

        [Display(Name = "Seguro de Salud")]
        Salud,

        [Display(Name = "Seguro de Hogar")]
        Hogar,

        [Display(Name = "Responsabilidad Civil")]
        ResponsabilidadCivil
    }
}