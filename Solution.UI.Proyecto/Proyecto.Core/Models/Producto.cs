using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Core.Models
{
    public class Producto
    {
        [Key]
        public int? idProducto { get; set; }
        [Required]
        public string descripcion { get; set; }
        public int precio { get; set; }
        public Boolean estado { get; set; }
        public string comentario { get; set; }
    }
}
