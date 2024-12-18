using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
        private ListaProductos prodAux;
        private MySqlConnection connection;


        private List<carrito> carritoAux=new List<carrito>();
        public usuario()
        {
            this.prodAux=new ListaProductos();
            this.Connect();
        }
        public void compra(List<carrito> carrito)
        {
            try
            {
                foreach (var itemCarrito in carrito)
                {
                 
                    int idProducto = itemCarrito.IdProducto;
                    int cantidadComprada = itemCarrito.Cantidad;

                    string query = "SELECT existencias FROM productos WHERE id = @idProducto;";
                    MySqlCommand command = new MySqlCommand(query, this.connection);
                    command.Parameters.AddWithValue("@idProducto", idProducto);

                    int existenciasActuales = 0;

                    //Leer existencias actuales
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            existenciasActuales = Convert.ToInt32(reader["existencias"]);
                        }
                    }

                    // Verificar si hay suficientes existencias
                    if (existenciasActuales >= cantidadComprada)
                    {
                        // Resta la cantidad comprada a las existencias actuales
                        int nuevasExistencias = existenciasActuales - cantidadComprada;

                        //Actualiza la base de datos
                        string updateQuery = "UPDATE productos SET existencias = @nuevasExistencias WHERE id = @idProducto;";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, this.connection);
                        updateCommand.Parameters.AddWithValue("@nuevasExistencias", nuevasExistencias);
                        updateCommand.Parameters.AddWithValue("@idProducto", idProducto);

                        updateCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        // Mensaje en caso de falta de existencias
                        MessageBox.Show($"No hay suficientes existencias para el producto con ID: {idProducto}");
                    }
                }

                MessageBox.Show("Compra procesada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la compra: " + ex.Message);
            }
            finally
            {
                this.Disconnect();
            }
        }


        public void agregaCarrito(int idUsuario, int idProd, int cantidad, int precio)
        {
            string query = "";
            try
            {

                var producto = prodAux.crear().FirstOrDefault(p => p.Id == idProd);
                if (producto != null)
                {
                    if(producto.Existencias == 0)
                    {
                        MessageBox.Show("No hay unidades en stock");
                        return;
                    }

                    if(cantidad > producto.Existencias)
                    {
                        MessageBox.Show($"Ya no hay unidades disponibles  {producto.Existencias} ");
                        return;
                    }

                    //SI TODO ESTA BIEN SI SE AGREGA AL CARRITO

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
                            int cantActual = Convert.ToInt32(result);
                            int nuevaCant = cantActual + 1;
                            query = "UPDATE comprasaux SET cantidad = @nuevaCant WHERE idUsuario = @idUsuario AND idProd = @idProd";
                            MySqlCommand cmdUpdate = new MySqlCommand(query, connection);
                            cmdUpdate.Parameters.AddWithValue("@nuevaCant", nuevaCant);
                            cmdUpdate.Parameters.AddWithValue("@idUsuario", idUsuario);
                            cmdUpdate.Parameters.AddWithValue("@idProd", idProd);

                            cmdUpdate.ExecuteNonQuery();
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
                        producto.Existencias-=1;

                        MessageBox.Show("Producto agregado al carrito");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error");
                    }     
                }

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

        public void borrarCarrito(int idUsuario)
        {
            string query = "";
            try
            {
                query = "DELETE FROM comprasaux WHERE idUsuario = @idUsuario";

                MySqlCommand cmdDelete = new MySqlCommand(query, connection);
                cmdDelete.Parameters.AddWithValue("@idUsuario", idUsuario);

                cmdDelete.ExecuteNonQuery();
            }
            catch
            {
                this.Disconnect();
            }
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
            {
            }
        }


        public void agregarPersonaMonto(decimal monto, string nombreUsuario)
        {
            // La consulta SQL suma el valor de monto al valor existente
            string query = "UPDATE personas SET monto = monto + @monto WHERE nombre = @nombreUsuario";

            try
            {
                // Abre la conexión si está cerrada
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                using (MySqlCommand cmdUpdate = new MySqlCommand(query, connection))
                {
                    // Parámetros seguros para evitar SQL Injection
                    cmdUpdate.Parameters.AddWithValue("@monto", monto);
                    cmdUpdate.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    // Ejecutar la consulta y verificar si se actualizó alguna fila
                    int result = cmdUpdate.ExecuteNonQuery();

                    if (result == 0)
                    {
                        MessageBox.Show("Usuario no encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la base de datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión en el bloque 'finally'
                connection.Close();
            }
        }


        public void actualVentas(List<carrito> carritoaux, int idUsuario)
        {
            string query = "";

            MySqlCommand cmdCheck = new MySqlCommand(query, connection);

            try
            {
                foreach (var item in carritoaux)
                {
                    
                    query = "INSERT INTO ventas(idUsuario, idProd, cantidad, precio) VALUES("
                        + "'" + idUsuario + "',"
                               + "'" + item.IdProducto + "', "
                               + "'" + item.Cantidad + "',"
                               + "'" + item.Precio + "')";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                this.Disconnect();
            }
        }







    }




}
