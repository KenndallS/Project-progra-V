using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.DO.Objects
{
    public class Usuario
    {
        [Key]
        public int? idUsuario { get; set; }
        [Required]
        public String nomUsuario { get; set; }
        public String contrasena { get; set; }
        public String idTipoUsuario { get; set; }
        public String apellido1 { get; set; }
        public String apellido2 { get; set; }
        public String correo { get; set; }
        public String direccion { get; set; }
        public int telefono { get; set; }
    }
}
