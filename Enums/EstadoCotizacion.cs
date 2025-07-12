using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum EstadoCotizacion    // Pendiente, Aceptada, Rechazada
    {
        [Display(Name = "En Proceso")]
        EnProceso,

        [Display(Name = "Aceptada")]
        Aceptada,

        [Display(Name = "Rechazada")]
        Rechazada,

        [Display(Name = "Expirada")]
        Expirada
    }
}