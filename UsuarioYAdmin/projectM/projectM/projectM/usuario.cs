using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
