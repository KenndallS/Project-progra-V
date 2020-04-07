using System;
using System.Collections.Generic;

namespace Solution.Proyecto.API.WBDF.Model
{
    public partial class Pedido
    {
        public int IdPedido { get; set; }
        public bool Atendido { get; set; }
        public DateTime Fecha { get; set; }
        public decimal CostoTotal { get; set; }
        public int IdProducto { get; set; }
        public int IdUsuario { get; set; }
        public int IdTienda { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Tienda IdTiendaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
