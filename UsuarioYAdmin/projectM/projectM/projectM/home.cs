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
    public partial class home : Form
    {
        private bool isUsuario;

        List<productos> data;
        int margenX = 20, margenY = 20;
        int ancho = 250, alto = 280;

        public home()
        {
            InitializeComponent();
        }

        public home(bool isUsuario)
        {
            InitializeComponent();
            this.isUsuario = isUsuario;
            extraerLista();
        }
        public void extraerLista()
        {
            ListaProductos obj = new ListaProductos();
            data = obj.crear();
            mostrar(data);
        }
        public void mostrar(List<productos> data)
        {
            int X = 25, Y = 50;
            if (this.isUsuario == false)
            {
                this.Width = 1200;
            }
            else
            {
                this.Width = 980;
            }
            foreach (var productos in data)
            {
                Panel panel = new Panel();
                panel.Size = new Size(ancho, alto);
                panel.Location = new Point(X, Y);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.BackColor = Color.White;
                X += ancho + margenX;
                if (X > 1200 - ancho)
                {
                    X = 25;
                    Y += alto + margenY;
                }


                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(14, 14);
                pictureBox.Size = new Size(220, 190);

                try
                {
                    string rutaImg = Path.Combine(Application.StartupPath, "ImagenesProducto", productos.Imagen);
                    if (File.Exists(rutaImg))
                    {
                        pictureBox.Image = Image.FromFile(rutaImg);
                    }
                    else
                    {
                        //pictureBox.Image = Properties.Resources.ImgDefecto;
                    }
                }
                catch { }
                panel.Controls.Add(pictureBox);

                Label label = new Label();
                label.Text = productos.Descripcion;
                label.ForeColor = Color.Black;
                label.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                label.Location = new Point(14, 215);
                panel.Controls.Add(label);

                Label label2 = new Label();
                label2.Size = new Size(200, 20);
                label2.Text = ($"Existencia: {Convert.ToString(productos.Existencias)}");
                label2.ForeColor = Color.BlueViolet;
                label2.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                label2.Location = new Point(135, 215);
                panel.Controls.Add(label2);

                Label label3 = new Label();
                label3.Text = "$ " + Convert.ToString(productos.Precio);
                label3.ForeColor = Color.Black;
                label3.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                label3.Location = new Point(14, 240);
                panel.Controls.Add(label3);

                this.Controls.Add(panel);
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
