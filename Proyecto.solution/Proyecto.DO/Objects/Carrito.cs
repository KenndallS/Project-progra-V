using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.DO.Objects
{
    public class Carrito
    {
        [Key]
        public int? idCarrito { get; set; }
        [Required]
        public string idUsuario { get; set; }
        [Required]
        public int idProducto { get; set; }
        [Required]
        public int cantidad { get; set; }
    }
}
