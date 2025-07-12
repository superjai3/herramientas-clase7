using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum Sexo
    {
        [Display(Name = "Masculino")]
        Masculino,

        [Display(Name = "Femenino")]
        Femenino,

        [Display(Name = "Otro")]
        Otro
    }
}
