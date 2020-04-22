using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.DO.Objects
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
