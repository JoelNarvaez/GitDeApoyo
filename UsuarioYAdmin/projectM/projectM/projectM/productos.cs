using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectM
{
    public class productos
    {
        private int id;
        private string imagen;
        private string descripcion;
        private int precio;
        private int existencias;
        private string coleccion;

        public productos()
        {

        }

        public productos(int id, string imagen, string descripcion, int precio, int existencias, string coleccion)
        {
            this.Id = id;
            this.Imagen = imagen;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Existencias = existencias;
            this.Coleccion = coleccion;
        }

        public int Id { get => id; set => id = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Existencias { get => existencias; set => existencias = value; }
        public string Coleccion { get => coleccion; set => coleccion = value; }
    }
}
