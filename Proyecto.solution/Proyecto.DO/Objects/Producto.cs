using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.DO.Objects
{
    public class Producto
    {
        [Key]
        public int? idProducto { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public int precio { get; set; }
    }
}
