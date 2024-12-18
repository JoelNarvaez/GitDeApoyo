using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.VisualBasic.Logging;
using projectM;

namespace projectM
{
    public class BD
    {
        private MySqlConnection connection;
        private Label validoOno;

        public BD(Label valido)
        {
            this.Connect();
            validoOno = valido;
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
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public (bool, string, string, int) consultaLogin(string username, string password)
        {
            bool existe = false;
            string tipoUsuario = string.Empty;
            string nombreUsuario = string.Empty;
            int idUsuario=-1;

            try
            {
                string query = "SELECT id, tipo, nombre FROM Personas WHERE usuario = @username AND contraseña = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    existe = true;
                    tipoUsuario = reader["tipo"].ToString();
                    nombreUsuario = reader["nombre"].ToString();
                    idUsuario=Convert.ToInt32(reader["id"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (existe, tipoUsuario, nombreUsuario, idUsuario);
        }


        public bool Login(string username, string password)
        {
            var (existe, tipoUsuario, nombreUsuario, idUsuario) = consultaLogin(username, password);

            if (existe)
            {
                switch (tipoUsuario)
                {
                    case "administrador":
                        FormAdmin formAdmin = new FormAdmin(nombreUsuario, idUsuario);
                        MessageBox.Show($"Bienvenido(a) a NAVIGA, {nombreUsuario}");
                        formAdmin.Show();
                        break;
                    case "usuario":
                        FormUsuario formUsuario = new FormUsuario(nombreUsuario, idUsuario);
                        MessageBox.Show($"Bienvenido(a) a NAVIGA, {nombreUsuario}");
                        formUsuario.Show();
                        break;
                    case "invitado":
                        FormUsuario formInvitado = new FormUsuario(nombreUsuario, idUsuario);
                        MessageBox.Show($"Bienvenido(a) a NAVIGA, {nombreUsuario}");
                        formInvitado.Show();
                        break;
                    default:
                        MessageBox.Show("Tipo de usuario desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                }
                return true;
            }
            else
            {
                ActualizarTexto("Usuario o Contraseña Inválidos");
                return false;
            }

        }


        public void ActualizarTexto(string texto)
        {
            if (validoOno != null)
            {
                validoOno.Text = texto;
            }
        }
    }

}

