using System;
using System.Collections.Generic;

namespace Solution.Proyecto.API.WBDF.Model
{
    public partial class Producto
    {
        public Producto()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool Estado { get; set; }
        public string Comentario { get; set; }

        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
