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

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            //Boton ventas totales
            pnlVentas.Visible = !pnlVentas.Visible;
            label1.Visible = !label1.Visible;
            if (pnlVentas.Visible)
            {
                mostrar();
            }

        }

        private void botonRedondo2_Click(object sender, EventArgs e)
        {   //Boton buscar
            mostrar();
        }



        private void mostrar()
        {
            administrador obj = new administrador();
            panelProductos.Controls.Clear(); // Limpiar el panel para evitar duplicados
            panelProductos.Visible = true;

            panelProductos.AutoScroll = true;
            panelProductos.Size = new Size(550, 900);
            panelProductos.Location = new Point(550, 25);

            int X = 20, Y = 20;
            int ancho = 450, alto = 200, margenY = 10;
            int Total = 0;
            int cuantos = 0;

            List<carrito> carritoVentas = new List<carrito>();

            if (string.IsNullOrWhiteSpace(idUsuario.Text))
            {
                // Si está vacío, obtén toda la tabla de ventas
                carritoVentas = obj.getTodasLasVentas();
            }
            else
            {
                // Si tiene un número, obtén las ventas específicas
                int id;
                if (int.TryParse(idUsuario.Text, out id))
                {
                    carritoVentas = obj.getVentas(id);
                }
                else
                {
                    MessageBox.Show("ID de usuario no válido.");
                    return;
                }
            }

            if (carritoVentas.Count == 0)
            {
                MessageBox.Show("No hay ventas registradas para mostrar.");
                return;
            }

            foreach (var p in carritoVentas)
            {
                productos producto = obj.obtenerProductoPorId(p.IdProducto);
                if (producto != null)
                {
                    Panel panelProd = new Panel();
                    panelProd.Size = new Size(ancho, alto);
                    panelProd.Location = new Point(X, Y);
                    panelProd.BorderStyle = BorderStyle.FixedSingle;
                    panelProd.BackColor = Color.White;

                    Y += alto + margenY;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(10, 10);
                    pictureBox.Size = new Size(190, 190);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    try
                    {
                        string rutaImg = Path.Combine(Application.StartupPath, "ImagenesProducto", producto.Imagen);
                        if (File.Exists(rutaImg))
                        {
                            pictureBox.Image = Image.FromFile(rutaImg);
                        }
                    }
                    catch { }

                    panelProd.Controls.Add(pictureBox);

                    Label label = new Label();
                    label.Text = producto.Descripcion;
                    label.ForeColor = Color.BlueViolet;
                    label.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                    label.Location = new Point(210, 20);
                    panelProd.Controls.Add(label);

                    Label label2 = new Label();
                    label2.Text = "Cantidad: " + p.Cantidad;
                    cuantos += p.Cantidad;
                    label2.ForeColor = Color.Black;
                    label2.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                    label2.Location = new Point(210, 50);
                    panelProd.Controls.Add(label2);

                    Label label3 = new Label();
                    label3.Text = "$ " + producto.Precio.ToString("F2");
                    label3.ForeColor = Color.Black;
                    label3.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                    label3.Location = new Point(210, 80);
                    panelProd.Controls.Add(label3);

                    Label label4 = new Label();
                    label4.Text = "Total " + (producto.Precio * p.Cantidad);
                    label4.ForeColor = Color.DeepPink;
                    label4.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                    label4.Location = new Point(210, 105);
                    panelProd.Controls.Add(label4);

                    panelProductos.Controls.Add(panelProd);

                    Total += producto.Precio * p.Cantidad;

                    if (p == carritoVentas.Last())
                    {
                        Y += 80;

                        Label labelTotal = new Label();
                        labelTotal.Text = $"Total a pagar: ${Total}";
                        labelTotal.ForeColor = Color.Black;
                        labelTotal.Font = new Font("Century Gothic", 16, FontStyle.Bold);
                        labelTotal.AutoSize = true;
                        labelTotal.Location = new Point(70, Y);
                        panelProductos.Controls.Add(labelTotal);
                    }
                }
            }

            panelProductos.Height = Y + 100;
            panelProductos.Visible = true;
            pnlVentas.Visible = true;
        }
    }


}