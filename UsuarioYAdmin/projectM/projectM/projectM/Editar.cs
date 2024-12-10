using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectM
{
    public partial class Editar : Form
    {
        List<productos> data;
        int margenX = 20, margenY = 20;
        int X = 25, Y = 50;
        int ancho = 250, alto = 280;
        public Editar()
        {
            InitializeComponent();
            ListaProductos obj = new ListaProductos();
            data = obj.crear();
            mostrar(data);
        }

        public void mostrar(List<productos> data)
        {

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
                    var imagen = (Image)Properties.Resources.ResourceManager.GetObject(productos.Imagen.Split('.')[0]);
                    if (imagen != null)
                    {
                        pictureBox.Image = imagen;
                    }
                }
                catch { }
                panel.Controls.Add(pictureBox);

                Label label = new Label();
                label.Text = productos.Descripcion;
                label.ForeColor = Color.Black;
                label.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                label.Location = new Point(14, 210);
                panel.Controls.Add(label);

                Button button = new Button();
                button.Image = Properties.Resources.eliminar;
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


                //AUN NO SE MUESTRA BIEN
                if (productos == data.Last())
                {
                    Button buttonAgregar = new Button();
                    buttonAgregar.Text = "+";
                    buttonAgregar.TextAlign = ContentAlignment.MiddleCenter;
                    buttonAgregar.Font = new Font("Century Gothic", 35, FontStyle.Bold);
                    buttonAgregar.Size = new Size(150, 150);
                    buttonAgregar.Location = new Point(X, Y);
                    buttonAgregar.FlatStyle = FlatStyle.Flat;
                    this.Controls.Add(buttonAgregar);
                }
            }
        }
    }
}
