using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        
        int ancho = 250, alto = 280;
        public Editar()
        {
            InitializeComponent();
            extraerLista();
        }

        public void extraerLista()
        {
            ListaProductos obj = new ListaProductos();
            data=obj.crear();
            mostrar(data);
            Perifericos perifericos = new Perifericos();
            perifericos.extraerLista();
            Gaming gaming = new Gaming();
            gaming.extraerLista();
        }

        public void mostrar(List<productos> data)
        {
            this.Controls.Clear();
            this.Controls.Add(panelAgregar);
            int X = 25, Y = 50;
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

                Button btnEliminar = new Button();
                btnEliminar.Image = Properties.Resources.eliminar;
                btnEliminar.ImageAlign = ContentAlignment.MiddleCenter;
                btnEliminar.Size = new Size(35, 35);
                btnEliminar.Location = new Point(200, 210);
                btnEliminar.FlatStyle = FlatStyle.Flat;
                btnEliminar.Tag = productos.Id;
                btnEliminar.Click += new EventHandler(btnEliminar_Click);
                panel.Controls.Add(btnEliminar);

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

                if (productos == data.Last())
                {
                    Button buttonAgregar = new Button();
                    buttonAgregar.Text = "+";
                    buttonAgregar.TextAlign = ContentAlignment.MiddleCenter;
                    buttonAgregar.Font = new Font("Century Gothic", 35, FontStyle.Bold);
                    buttonAgregar.Size = new Size(150, 150);
                    buttonAgregar.Location = new Point(X, Y);
                    buttonAgregar.FlatStyle = FlatStyle.Flat;
                    buttonAgregar.Click += new EventHandler(ButtonAgregar_Click);
                    this.Controls.Add(buttonAgregar);
                }
            }

        }
        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = !panelAgregar.Visible;
        }

        private void btnCerrarAgregar_Click(object sender, EventArgs e)
        {
            panelAgregar.Visible = false;
        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            int id;
            string imagen;
            string descripcion;
            int precio;
            int existencias;
            string coleccion=string.Empty;
            

            id = Convert.ToInt32(txtBtId.Text);
            imagen=txtBtImg.Text;
            descripcion=txtBtDesc.Text;
            precio=Convert.ToInt32(txtBtPrecio.Text);
            existencias = Convert.ToInt32(txtBtExistencias.Text);
            if(radioBtnGaming.Checked)
            {
                coleccion = "gaming";
            }
            else if(radioBtnPerifericos.Checked)
            {
                coleccion = "perifericos";
            }

            if (string.IsNullOrEmpty(coleccion))
            {
                MessageBox.Show("Por favor, seleccione una colección."); return;
            }

            administrador admin = new administrador();

            admin.agregar(id, imagen, descripcion, precio, existencias, coleccion);
            panelAgregar.Visible = false;
            extraerLista();



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEliminar=0;
            Button btn = sender as Button;

            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el producto?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (btn != null)
            {
                idEliminar = (int)btn.Tag;
                if (result == DialogResult.OK)
                {
                    administrador admin = new administrador();
                    admin.eliminar(idEliminar);

                    extraerLista();
                }


            }
            else
            {
                MessageBox.Show("Se cancelo la eliminación");
            }
            
            
        }
    }
}
