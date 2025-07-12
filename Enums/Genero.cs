using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum Genero  // Masculino, Femenino, Otro
    {
        [Display(Name = "Masculino")]
        Masculino,

        [Display(Name = "Femenino")]
        Femenino,

        [Display(Name = "Otro")]
        Otro
    }
}