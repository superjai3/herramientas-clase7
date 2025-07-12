using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum EstadoCivil
    {
        [Display(Name = "Soltero/a")]
        Soltero,

        [Display(Name = "Casado/a")]
        Casado,

        [Display(Name = "Divorciado/a")]
        Divorciado,

        [Display(Name = "Viudo/a")]
        Viudo
    }
}
