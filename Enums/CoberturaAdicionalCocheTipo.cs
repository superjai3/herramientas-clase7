using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Enums
{
    public enum CoberturaAdicionalCocheTipo
    {
        [Display(Name = "Robo")]
        Robo,

        [Display(Name = "Incendio")]
        Incendio,

        [Display(Name = "Daños por agua")]
        DañosPorAgua,

        [Display(Name = "Responsabilidad civil")]
        ResponsabilidadCivil,

        [Display(Name = "Asistencia en viaje")]
        AsistenciaEnViaje,

        [Display(Name = "Accidentes personales")]
        AccidentesPersonales
    }
}
