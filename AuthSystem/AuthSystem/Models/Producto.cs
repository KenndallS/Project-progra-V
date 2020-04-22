using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystem.Models
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

