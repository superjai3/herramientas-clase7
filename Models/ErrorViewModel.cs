using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Seguroquesi.Enums;
using Seguroquesi.Models;



namespace Seguroquesi.Models
{

    public class ErrorViewModel
    {
        public required string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}