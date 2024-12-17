using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projectM
{
    public class administrador
    {
        private MySqlConnection connection;

        public administrador()
        {
            this.Connect();
        }

        public void agregar(int id, string imagen, string descripcion, int precio, int existencias, string coleccion)
        {
            string query = "";
            try
            {
                query = "INSERT INTO productos (id,imagen,descripcion,precio, existencias, coleccion) VALUES ("
               + "'" + id + "',"
               + "'" + imagen + "', "
               + "'" + descripcion + "',"
               + "'" + precio + "', "
               + "'" + existencias +"',"
               + "'" + coleccion +"')";



                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                
                this.Disconnect();
            }
        }

        public void eliminar(int id)
        {
            string query = "";
            try
            {
                //Verificar cuantos productos hay en la base de datos
                query = "SELECT COUNT(*) FROM productos";
                MySqlCommand cmdCount = new MySqlCommand(query, connection);
                int total=Convert.ToInt32(cmdCount.ExecuteScalar());

                if (total > 6)//si hay mas de 6 productos
                {
                    query = "DELETE FROM productos WHERE id=" + id + ";";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el producto, en la base de datos solo hay 6 productos");
                }

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se elimino");
                this.Disconnect();
            }
        }
        public productos getProdAElimiar(int idProducto)
        {
            productos producto = null;
            try
            {
                string query = "SELECT * FROM productos WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.Parameters.AddWithValue("@id", idProducto);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string descripcion = Convert.ToString(reader["descripcion"]);
                    int precio = Convert.ToInt32(reader["precio"]);
                    string imagen = Convert.ToString(reader["imagen"]);
                    string coleccion = Convert.ToString(reader["coleccion"]);
                    int  existencia= Convert.ToInt32(reader["existencias"]);

                    producto = new productos(id, imagen, descripcion, precio, existencia, coleccion);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el producto: {ex.Message}");
            }

            return producto;
        }

        public List<productos> listExist()
        {
            List<productos> lista = new List<productos>();
            productos iterador;
            int id;
            string imagen;
            string descripcion;
            int precio;
            int existencias;
            string coleccion;
            try
            {
                string query = "SELECT * FROM productos";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    descripcion = Convert.ToString(reader["descripcion"]) ?? "";
                    precio = Convert.ToInt32(reader["precio"]);
                    existencias = Convert.ToInt32(reader["existencias"]);
                    coleccion = Convert.ToString(reader["coleccion"]) ?? "";

                    iterador = new productos(id, imagen, descripcion, precio, existencias, coleccion);
                    lista.Add(iterador);

                }
                reader.Close();
                
                lista=lista.OrderBy(x=>x.Existencias).ToList();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return lista;
        }


        public List<carrito> getVentas(int idUsuario)
        {
            List<carrito> ventas = new List<carrito>();
            carrito iterador;
            int idProducto;
            int cantidad;
            int precio;

            try
            {
                string query = "SELECT * FROM ventas WHERE idUsuario = @idUsuario";

                MySqlCommand command = new MySqlCommand(query, this.connection);

                command.Parameters.AddWithValue("@idUsuario", idUsuario);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                }

                while (reader.Read())
                {
                    idProducto = Convert.ToInt32(reader["idProd"]);
                    cantidad = Convert.ToInt32(reader["cantidad"]);
                    precio = Convert.ToInt32(reader["precio"]);
                    iterador = new carrito(idProducto, cantidad, precio);
                    ventas.Add(iterador);


                }
                reader.Close();

            }
            catch (Exception ex)
            {

                this.Disconnect();
            }

            return ventas;
        }

        public productos obtenerProductoPorId(int idProducto)
        {
            productos producto = null;
            try
            {
                string query = "SELECT * FROM productos WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                command.Parameters.AddWithValue("@id", idProducto);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"]);
                    string descripcion = Convert.ToString(reader["descripcion"]);
                    int precio = Convert.ToInt32(reader["precio"]);
                    string imagen = Convert.ToString(reader["imagen"]);

                    producto = new productos(id, imagen, descripcion, precio, 0, "");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el producto: {ex.Message}");
            }

            return producto;
        }

        public List<carrito> getTodasLasVentas()
        {
           
            List<carrito> ventas = new List<carrito>();
            try
            {
                string query = "SELECT * FROM ventas;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idProducto = Convert.ToInt32(reader["idProd"]);
                    int cantidad = Convert.ToInt32(reader["cantidad"]);
                    int precio = Convert.ToInt32(reader["precio"]);

                    ventas.Add(new carrito
                    {
                        IdProducto = idProducto,
                        Cantidad = cantidad,
                        Precio = precio
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener todas las ventas: " + ex.Message);
            }
            return ventas;
            

        }


        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=puntoventalogin; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
            }
            catch (Exception ex)
            {   }
        }



    }
}
