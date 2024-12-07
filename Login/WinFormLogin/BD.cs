using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WinFormLogin;
using ZstdSharp.Unsafe;
using static System.Runtime.InteropServices.JavaScript.JSType;
using projectM;
using Microsoft.VisualBasic.Logging;


namespace WinFormLogin
{
    public class BD
    {
        private MySqlConnection connection;

        public BD()
        {
            this.Connect();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexión cerrada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=puntoventalogin; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                MessageBox.Show("Conexión establecida exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public (bool, string) consultaLogin(string username, string password)
        {
            bool existe = false;
            string tipoUsuario = string.Empty;

            try
            {
                string query = "SELECT tipo FROM Personas WHERE usuario = @username AND contraseña = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    existe = true;
                    tipoUsuario = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (existe, tipoUsuario);
        }

        public void Login(string username, string password)
        {
            var (existe, tipoUsuario) = consultaLogin(username, password);

            if (existe)
            {
                switch (tipoUsuario)
                {
                    case "administrador":
                        FormAdmin formAdmin = new FormAdmin();
                        formAdmin.Show();
                        break;
                    case "usuario":
                        FormUsuario formUsuario = new FormUsuario();
                        formUsuario.Show();
                        break;
                    case "invitado":
                        FormUsuario formInvitado = new FormUsuario();
                        formInvitado.Show();
                        break;
                    default:
                        MessageBox.Show("Tipo de usuario desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}



