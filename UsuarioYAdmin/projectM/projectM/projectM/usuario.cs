using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projectM
{
    public class usuario
    {
        private MySqlConnection connection;

        public usuario()
        {
            this.Connect();
        }
        public void compra(int idA)
        {
            productos item = null;
            int id;
            string imagen;
            string descripcion;
            int precio;
            int existencias;
            string coleccion;
            try
            {
                string query = "SELECT * FROM productos where id=" + idA + ";";
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
                    item = new productos(id, imagen, descripcion, precio, existencias, coleccion);


                }
                reader.Close();
                if(item != null && item.Existencias > 0)
                {
                    item.Existencias -= 1;
                    existencias = item.Existencias;
                    string updatequery = "UPDATE productos SET existencias= " + existencias + "'" + "where id=" + idA + ";"; ; 
                    MySqlCommand updatecmd = new MySqlCommand(updatequery, this.connection);
                    updatecmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }

        }

        public void agregaCarrito(int idUsuario, int idProd, int cantidad, int precio)
        {
            string query = "";
            try
            {
                //Comprobar si el producto ya esta en el carrito con el mismo usuario
                query = "SELECT cantidad FROM comprasaux WHERE idUsuario = @idUsuario AND idProd = @idProd";

                MySqlCommand cmdCheck = new MySqlCommand(query, connection);
                cmdCheck.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmdCheck.Parameters.AddWithValue("@idProd", idProd);

                var result = cmdCheck.ExecuteScalar(); 

                if (result != null)//si ya se encuentra en el carrito para ese usuario se aumenta solo en cantidad
                {
                    int cantActual=Convert.ToInt32(result);
                    int nuevaCant = cantActual + 1;
                    query = "UPDATE comprasaux SET cantidad = @nuevaCant WHERE idUsuario = @idUsuario AND idProd = @idProd";
                    MySqlCommand cmdUpdate = new MySqlCommand(query, connection);
                    cmdUpdate.Parameters.AddWithValue("@nuevaCant", nuevaCant);
                    cmdUpdate.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmdUpdate.Parameters.AddWithValue("@idProd", idProd);

                    cmdUpdate.ExecuteNonQuery ();
                }
                else
                {
                    query = "INSERT INTO comprasaux (idUsuario,idProd,cantidad,precio) VALUES ("
                       + "'" + idUsuario + "',"
                       + "'" + idProd + "', "
                       + "'" + cantidad + "',"
                       + "'" + precio + "')";



                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    
                }

                MessageBox.Show("Se agrego al carrito");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se agrego al carrito");
                this.Disconnect();
            }
        }

        public List<carrito> getcarrito(int idUsuario)
        {
            List<carrito> carrito = new List<carrito>();
            carrito iterador;
            int idProducto;
            int cantidad;
            int precio;

            try
            {
                string query = "SELECT * FROM comprasaux WHERE idUsuario = @idUsuario";
                
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
                    carrito.Add(iterador);


                }
                reader.Close();

            }
            catch (Exception ex)
            {
             
                this.Disconnect();
            }

            return carrito;
        }
        //AJUSTAR
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


        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                //MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=puntoventalogin; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                //MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
