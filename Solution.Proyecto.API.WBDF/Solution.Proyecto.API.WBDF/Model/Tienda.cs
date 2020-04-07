using System;
using System.Collections.Generic;

namespace Solution.Proyecto.API.WBDF.Model
{
    public partial class Tienda
    {
        public Tienda()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int IdTienda { get; set; }
        public string DireccionTienda { get; set; }
        public int UsuarioTienda { get; set; }

        public virtual Usuario UsuarioTiendaNavigation { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
