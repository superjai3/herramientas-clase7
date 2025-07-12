using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum MetodoPago    // Transferencia, tarjeta, etc.
    {
        [Display(Name = "Transferencia Bancaria")]
        TransferenciaBancaria,

        [Display(Name = "Tarjeta de Crédito")]
        TarjetaCredito,

        [Display(Name = "Tarjeta de Débito")]
        TarjetaDebito,

        [Display(Name = "Pago en Efectivo")]
        Efectivo,

        [Display(Name = "Débito Automático")]
        DebitoAutomatico,

        [Display(Name = "Mercado Pago")]
        MercadoPago
    }
}