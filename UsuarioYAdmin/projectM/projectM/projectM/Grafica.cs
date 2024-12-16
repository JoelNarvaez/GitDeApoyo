using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace projectM
{
    public partial class Grafica : Form
    {
        private System.Windows.Forms.Timer timer;

        public Grafica()
        {
            InitializeComponent();
            CargarDatosYMostrarGrafica();

            // Configurar el Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; // Intervalo en milisegundos (5000 ms = 5 segundos)
            timer.Tick += new EventHandler(OnTimerTick);
            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            CargarDatosYMostrarGrafica();
        }

        private void CargarDatosYMostrarGrafica()
        {
            string connectionString = "Server=localhost; Database=puntoventalogin; User=root; Password=; SslMode=none;";
            string query = "SELECT tipo, nombre, monto FROM personas";

            List<string> nombres = new List<string>();  // Lista unificada de nombres
            List<double> montos = new List<double>();   // Lista unificada de montos

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tipo = reader["tipo"].ToString();  // Obtener el tipo de usuario
                    string nombre = reader["nombre"].ToString();
                    decimal monto = Convert.ToDecimal(reader["monto"]);

                    // Si el tipo no es "administrador", agregar el nombre y monto a las listas
                    if (tipo != "administrador")
                    {
                        nombres.Add(nombre);  // Agregar el nombre a la lista
                        montos.Add((double)monto);  // Agregar el monto a la lista, convirtiendo a double
                    }
                }

                reader.Close();
            }

            chart1.Series.Clear(); // Limpiar las series existentes antes de agregar nuevas

            for (int i = 0; i < nombres.Count; i++)
            {
                Series s = chart1.Series.Add(nombres[i]);
                s.Label = montos[i].ToString();
                s.Points.Add(montos[i]);
            }
        }
    }
}