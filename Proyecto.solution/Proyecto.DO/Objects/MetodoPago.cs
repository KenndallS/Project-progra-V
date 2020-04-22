using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.DO.Objects
{
    public class MetodoPago
    {
        [Key]
        public int? idMetodoPago { get; set; }
        [Required]
        public string nombre { get; set; }
    }
}
