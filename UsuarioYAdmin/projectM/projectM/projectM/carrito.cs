using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectM
{
    public class carrito
    {
        private int idProducto;
        private int cantidad;
        private int precio;

        public carrito()
        {

        }

        public carrito(int idProducto, int cantidad, int precio)
        {
            this.IdProducto = idProducto;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
    }
}
