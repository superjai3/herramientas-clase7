using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum EstadoPoliza
    {
        [Display(Name = "Activa")]
        Activa,

        [Display(Name = "Vencida")]
        Vencida,

        [Display(Name = "Cancelada")]
        Cancelada,

        [Display(Name = "Pendiente de Pago")]
        PendienteDePago
    }
}
