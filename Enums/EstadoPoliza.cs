using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum EstadoPoliza
    {
        [Display(Name = "En Emisión")]
        EnProceso,

        [Display(Name = "Emitida")]
        Emitida,

        [Display(Name = "Vigente")]
        Aceptada,

        [Display(Name = "Anulada")]
        Rechazada,

        [Display(Name = "Vencida")]
        Expirada,

        [Display(Name = "En Prorroga")]
        Prorrogada
    }
}
