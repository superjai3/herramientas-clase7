using System.ComponentModel.DataAnnotations;

namespace Seguroquesi.Models
{
    public class Nacionalidad
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nacionalidad")]
        public string Nombre { get; set; }
    }
}
