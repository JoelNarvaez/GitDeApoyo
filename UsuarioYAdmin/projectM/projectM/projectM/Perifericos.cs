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
        public Perifericos()
        {
            InitializeComponent();
            extraerLista();
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

                Button button = new Button();
                button.Image = Properties.Resources.comp;
                button.ImageAlign = ContentAlignment.MiddleCenter;
                button.Size = new Size(35, 35);
                button.Location = new Point(200, 210);
                button.FlatStyle = FlatStyle.Flat;
                panel.Controls.Add(button);

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
    }
}
