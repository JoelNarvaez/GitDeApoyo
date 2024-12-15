using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projectM
{
    public partial class Perifericos : Form
    {
        List<productos> data;
        int margenX = 20, margenY = 20;
        int X = 25, Y = 50;
        int ancho = 250, alto = 280;
        private int idUsuario;
        private bool isUsuario;

        public Perifericos()
        {
            InitializeComponent();
            extraerLista();
        }
        public Perifericos(int idUsuario, bool isUsuario)
        {

            InitializeComponent();
            extraerLista();
            this.idUsuario = idUsuario;
            this.isUsuario = isUsuario;
        }

        public void extraerLista()
        {
            ListaProductos obj = new ListaProductos();
            data = obj.crear();

            List<productos> perifericos = new List<productos>();
            productos p = new productos();

            foreach (var productos in data)
            {
                if (productos.Coleccion == "perifericos")
                {
                    p = productos;
                    perifericos.Add(p);
                }

            }
            mostrar(perifericos);

        }

        public void mostrar(List<productos> perifericos)
        {
            this.Controls.Clear();
            int X = 25, Y = 50;
            foreach (var productos in perifericos)
            {
                Panel panel = new Panel();
                panel.Size = new Size(ancho, alto);
                panel.Location = new Point(X, Y);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.BackColor = Color.White;
                X += ancho + margenX;
                if (X > this.Width - ancho)
                {
                    X = 25;
                    Y += alto + margenY;
                }

                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(14, 14);
                pictureBox.Size = new Size(220, 190);
                try
                {
                    var imagen = (Image)Properties.Resources.ResourceManager.GetObject(productos.Imagen.Split('.')[0]);
                    if (imagen != null)
                    {
                        pictureBox.Image = imagen;
                    }
                }
                catch { }
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(pictureBox);

                Label label = new Label();
                label.Text = productos.Descripcion;
                label.ForeColor = Color.Black;
                label.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                label.Location = new Point(14, 210);
                panel.Controls.Add(label);




                if (this.isUsuario=true)
                {
                    Button button = new Button();
                    button.Image = Properties.Resources.comp;
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.Size = new Size(35, 35);
                    button.Location = new Point(200, 210);
                    button.FlatStyle = FlatStyle.Flat;
                    button.Tag = productos.Id;
                    button.Click += new EventHandler(button_Click);

                    if (productos.Existencias == 0)
                    {
                        button.Enabled = false; // Deshabilitar el botón si no hay existencias

                        button.ForeColor = Color.Red; // Cambiar color del texto a rojo para resaltar

                        Label label4 = new Label();
                        label4.Text = "Sin Stock";
                        label4.ForeColor = Color.Red;
                        label4.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                        label4.Location = new Point(170, 250);
                        panel.Controls.Add(label4);
                    }

                    panel.Controls.Add(button);

                }
               


                Label label2 = new Label();
                label2.Text = Convert.ToString(productos.Existencias);
                label2.ForeColor = Color.Black;
                label2.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                label2.Location = new Point(170, 215);
                panel.Controls.Add(label2);

                Label label3 = new Label();
                label3.Text = "$ " + Convert.ToString(productos.Precio);
                label3.ForeColor = Color.Black;
                label3.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                label3.Location = new Point(14, 240);
                panel.Controls.Add(label3);

                this.Controls.Add(panel);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            int idComprar = 0;
            int cantidad = 0;
            Button btn = sender as Button;

            DialogResult result = MessageBox.Show("¿Agregar el producto al carrito?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (btn != null)
            {
                idComprar = (int)btn.Tag;
                if (result == DialogResult.OK)
                {
                    productos productoSeleccionado = data.FirstOrDefault(P => P.Id == idComprar);

                    int precio = productoSeleccionado.Precio;

                    usuario usuario = new usuario();
                    usuario.agregaCarrito(idUsuario, idComprar, ++cantidad, precio);
                }


            }
            else
            {
                MessageBox.Show("Se cancelo la compra");
            }
        }
    }
}
