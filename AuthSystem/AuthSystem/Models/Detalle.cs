using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystem.Models
{
    public class Detalle
    {
        [Key]
        public int? idDetalle { get; set; }
        [Required]
        public int idOrden { get; set; }
        [Required]
        public int idProducto { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        public int precio { get; set; }
    }
}
