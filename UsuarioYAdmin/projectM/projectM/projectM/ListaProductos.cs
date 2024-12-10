using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectM
{
    public class ListaProductos
    {
        private MySqlConnection connection;
        public ListaProductos()
        {
            this.Connect();
        }

        public List<productos> crear()
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

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }

            return lista;
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
