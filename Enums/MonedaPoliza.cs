using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum MonedaPoliza    // ARS, USD, etc.
    {
        [Display(Name = "Peso Argentino")]
        ARS,

        [Display(Name = "Dólar Estadounidense")]
        USD,

        [Display(Name = "Euro")]
        EUR
    }
}