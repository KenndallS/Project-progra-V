using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystem.Models
{
    public class MetodoPago
    {
        [Key]
        public int? idMetodoPago { get; set; }
        [Required]
        public string nombre { get; set; }
    }
}
