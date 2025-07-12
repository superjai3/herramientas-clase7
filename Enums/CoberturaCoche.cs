
using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum CoberturaCoche    // Cobertura del seguro, por ejemplo: Todo Riesgo, Responsabilidad Civil, etc.
    {
        [Display(Name = "Responsabilidad Civil")]
        ResponsabilidadCivil,

        [Display(Name = "Todo Riesgo")]
        TodoRiesgo,

        [Display(Name = "Terceros Completo")]
        TercerosCompleto,

        [Display(Name = "Terceros Básico")]
        TercerosBasico,

        [Display(Name = "Robo/Incendio")]
        RoboIncendio
    }
}