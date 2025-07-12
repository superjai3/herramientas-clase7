using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace clase7.Models
{
    public class CondicionesPoliza
    {
        [Key, ForeignKey("Poliza")]
        public Guid PolizaId { get; set; } // Es clave primaria y foránea al mismo tiempo.

        public Poliza Poliza { get; set; }  //Relación 1 a 1 con Póliza.

        public string Generales { get; set; }
        public string Particulares { get; set; }
        public string Especiales { get; set; }
        public string Exclusiones { get; set; }
        public string Obligaciones { get; set; }
        public string Derechos { get; set; }
        public string Reclamaciones { get; set; }
        public string Cancelacion { get; set; }
        public string Renovacion { get; set; }
        public string Modificacion { get; set; }
        public string Suspensiones { get; set; }
        public string Indemnizacion { get; set; }
    }
}
