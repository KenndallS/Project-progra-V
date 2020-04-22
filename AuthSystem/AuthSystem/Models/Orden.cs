using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystem.Models
{
    public class Orden
    {
        [Key]
        public int? idOrden { get; set; }
        [Required]
        public string idUsuario { get; set; }
        [Required]
        public int idMetodoPago { get; set; }
        [Required]
        public int total { get; set; }
        [Required]
        public int idDireccion { get; set; }
    }
}
