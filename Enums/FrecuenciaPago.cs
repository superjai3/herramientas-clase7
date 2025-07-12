using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum FrecuenciaPago
    {
        [Display(Name = "Mensual")]
        Mensual,

        [Display(Name = "Trimestral")]
        Trimestral,

        [Display(Name = "Semestral")]
        Semestral,

        [Display(Name = "Anual")]
        Anual
    }
}
