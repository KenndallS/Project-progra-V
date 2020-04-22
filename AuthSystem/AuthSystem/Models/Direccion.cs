using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystem.Models
{
    public class Direccion
    {
        [Key]
        public int? idDireccion { get; set; }
        [Required]
        public string idUsuario { get; set; }
        [Required]
        public string provincia { get; set; }
        [Required]
        public string canton { get; set; }
        [Required]
        public string distrito { get; set; }
        [Required]
        public string direccion { get; set; }

    }
}
