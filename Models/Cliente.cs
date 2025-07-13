using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;



namespace Seguroquesi.Models
{
    public class Cliente : Tomador
    {
        public required string NumeroIdentificacion { get; set; }
    }
}
