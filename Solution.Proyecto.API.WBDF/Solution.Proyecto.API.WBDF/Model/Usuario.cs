using System;
using System.Collections.Generic;

namespace Solution.Proyecto.API.WBDF.Model
{
    public partial class Usuario
    {
        public Usuario()
        {
            Pedido = new HashSet<Pedido>();
            Tienda = new HashSet<Tienda>();
        }

        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string Contrasena { get; set; }
        public string IdTipoUsuario { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<Tienda> Tienda { get; set; }
    }
}
