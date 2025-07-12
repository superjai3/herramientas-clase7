using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum TipoDocumentoEmpresa
    {
        [Display(Name = "CUIT (Argentina)")]
        CUIT,

        [Display(Name = "CIF (España)")]
        CIF
    }
}
