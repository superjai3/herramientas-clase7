using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;


namespace Seguroquesi.Models

{
    public class Nacionalidad
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nacionalidad")]
        public required string Nombre { get; set; }
    }
}
