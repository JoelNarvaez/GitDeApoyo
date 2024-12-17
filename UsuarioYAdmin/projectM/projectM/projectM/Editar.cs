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
        private Panel vistaPrevia;
        int margenX = 20, margenY = 20;
        private int idUsuario;

        int ancho = 250, alto = 280;

        public Editar()
        {
            InitializeComponent();
        }
        public Editar(int idUsuario)
        {
            InitializeComponent();
            extraerLista();
            this.idUsuario = idUsuario;

        }

        public void extraerLista()
        {
            ListaProductos obj = new ListaProductos();
            data = obj.crear();
            mostrar(data);
        }

        public void mostrar(List<productos> data)
        {
            this.Controls.Clear();
            this.Controls.Add(panelAgregar);
            int X = 25, Y = 50;
            foreach (var productos in data)
            {
                if (data.Count==0)
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
            if (vistaPrevia != null)
            {
                this.Controls.Remove(vistaPrevia); // Quitar el panel de vista previa
                vistaPrevia = null; // Limpiar la referencia
            }
            panelAgregar.Visible = false;

        }

        private string imagenSeleccionada = string.Empty;
        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            int id;
            string imagen;
            string descripcion;
            int precio;
            int existencias;
            string coleccion = string.Empty;
            txtBtImg.PlaceholderText = "Nombre de la imagen";


            id = Convert.ToInt32(txtBtId.Text);
            descripcion = txtBtDesc.Text;
            precio = Convert.ToInt32(txtBtPrecio.Text);
            existencias = Convert.ToInt32(txtBtExistencias.Text);


            if (string.IsNullOrEmpty(imagenSeleccionada))
            {
                MessageBox.Show("Por favor, seleccione una imagen.");
                return;
            }
            

            imagen = imagenSeleccionada;
            txtBtImg.PlaceholderText = imagen;

            if (radioBtnGaming.Checked)
            {
                coleccion = "gaming";
            }
            else if (radioBtnPerifericos.Checked)
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
            int idEliminar = 0;
            Button btn = sender as Button;

            if (btn != null)
            {
                idEliminar = (int)btn.Tag;
                administrador admin = new administrador();
                productos producto = admin.getProdAElimiar(idEliminar);

                if (producto != null)
                {
                    // Mostrar vista previa del producto a eliminar
                    MostrarVistaPrevia(producto);

                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el producto?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        admin.eliminar(idEliminar);

                        this.Controls.Remove(eliminar);

                    }
                    else
                    {
                        MessageBox.Show("Se canceló la eliminación");
                        this.Controls.Remove(eliminar);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el producto a eliminar");
                }
            }
            extraerLista();

        }

        private Panel eliminar;

        private void MostrarVistaPrevia(productos producto)
        {
            if (eliminar != null)
            {
                this.Controls.Remove(eliminar);
            }

            eliminar = new Panel
            {
                Size = new Size(500, 250),
                Location = new Point(340, 10),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Silver
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(240, 215),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.None,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            //try
            //{
              //  var imagen = (Image)Properties.Resources.ResourceManager.GetObject(producto.Imagen.Split('.')[0]);
                //pictureBox.Image = imagen ?? Properties.Resources.NavigaLogoLog; // Imagen por defecto
            //}
            //catch
            //{
              //  pictureBox.Image = Properties.Resources.NavigaLogoLog;
            //}

            try
            {
                string rutaImg = Path.Combine(Application.StartupPath, "ImagenesProducto", producto.Imagen);
                if (File.Exists(rutaImg))
                {
                    pictureBox.Image = Image.FromFile(rutaImg);
                }
                else
                {
                    pictureBox.Image = Properties.Resources.NavigaLogoLog;
                }
            }
            catch
            {            }

            eliminar.Controls.Add(pictureBox);

            Label lblDescripcion = new Label
            {
                Text = producto.Descripcion,
                Location = new Point(305, 170),
                Size = new Size(250, 20),
                Font = new Font("Century Gothic", 13, FontStyle.Bold),
                ForeColor = Color.BlueViolet
            };
            eliminar.Controls.Add(lblDescripcion);

            Label lblPrecio = new Label
            {
                Text = "Precio: $" + producto.Precio,
                Location = new Point(305, 50),
                Size = new Size(250, 20),
                Font = new Font("Century Gothic", 12, FontStyle.Regular),
                ForeColor = Color.Black
            };
            eliminar.Controls.Add(lblPrecio);

            Label lblExistencias = new Label
            {
                Text = "Existencias: " + producto.Existencias,
                Location = new Point(305, 130),
                Size = new Size(250, 20),
                Font = new Font("Century Gothic", 12, FontStyle.Regular),
                ForeColor = Color.Black
            };
            eliminar.Controls.Add(lblExistencias);

            Label lblColeccion = new Label
            {
                Text = "Colección: " + producto.Coleccion,
                Location = new Point(305, 90),
                Size = new Size(250, 20),
                Font = new Font("Century Gothic", 12, FontStyle.Regular),
                ForeColor = Color.Black
            };
            eliminar.Controls.Add(lblColeccion);

            this.Controls.Add(eliminar);
            eliminar.BringToFront();
        }

        private void panelAgregar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtBtId.Text) ||
                string.IsNullOrEmpty(txtBtImg.Text) ||
                string.IsNullOrEmpty(txtBtDesc.Text) ||
                string.IsNullOrEmpty(txtBtPrecio.Text) ||
                string.IsNullOrEmpty(txtBtExistencias.Text) ||
                (!radioBtnGaming.Checked && !radioBtnPerifericos.Checked))
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione una colección antes de continuar.");
                return;
            }

            if (vistaPrevia != null)
            {
                this.Controls.Remove(vistaPrevia);
            }

            vistaPrevia = new Panel
            {
                Size = new Size(530, 390),
                Location = new Point(545, 110),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(300, 275),
                Location = new Point(25, 20),
                BorderStyle = BorderStyle.None,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            //try
            //{
              //  var imagen = (Image)Properties.Resources.ResourceManager.GetObject(txtBtImg.Text.Split('.')[0]);
                //pictureBox.Image = imagen ?? Properties.Resources.NavigaLogoLog; // Imagen por defecto

            //}
            //catch
            //{
              //  pictureBox.Image = Properties.Resources.NavigaLogoLog;
            //}


            try
            {
                string rutaImg = Path.Combine(Application.StartupPath, "ImagenesProducto", txtBtImg.Text);
                if (File.Exists(rutaImg))
                {
                    pictureBox.Image = Image.FromFile(rutaImg);
                }
                else
                {
                    pictureBox.Image = Properties.Resources.NavigaLogoLog;
                }
            }
            catch
            { }

            vistaPrevia.Controls.Add(pictureBox);

            Label lblDescripcion = new Label
            {
                Text = txtBtDesc.Text,
                Location = new Point(25, 300),
                Size = new Size(250, 20),
                Font = new Font("Century Gothic", 13, FontStyle.Bold),
                ForeColor = Color.BlueViolet
            };
            vistaPrevia.Controls.Add(lblDescripcion);

            Label lblPrecio = new Label
            {
                Text = "Precio: $" + txtBtPrecio.Text,
                Location = new Point(335, 50),
                Size = new Size(250, 20),
                Font = new Font("Century Gothic", 12, FontStyle.Regular),
                ForeColor = Color.Black
            };
            vistaPrevia.Controls.Add(lblPrecio);


            Label lblExistencias = new Label
            {
                Text = "Existencias: " + txtBtExistencias.Text,
                Location = new Point(335, 130),
                Size = new Size(250, 20),
                Font = new Font("Century Gothic", 12, FontStyle.Regular),
                ForeColor = Color.Black
            };
            vistaPrevia.Controls.Add(lblExistencias);

            Label lblColeccion = new Label
            {
                Text = "Colección: " + (radioBtnGaming.Checked ? "Gaming" : "Periféricos"),
                Location = new Point(335, 90),
                Size = new Size(250, 20),
                Font = new Font("Century Gothic", 12, FontStyle.Regular),
                ForeColor = Color.Black
            };
            vistaPrevia.Controls.Add(lblColeccion);

            this.Controls.Add(vistaPrevia);
            vistaPrevia.BringToFront();
        }

        private void seleccionImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Seleccionar Imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagenSeleccionada = openFileDialog.FileName;
                imagenSeleccionada = Path.GetFileName(rutaImagenSeleccionada);

                string rutaDestino = Path.Combine(Application.StartupPath, "ImagenesProducto", imagenSeleccionada);
                
                MessageBox.Show(Application.StartupPath);

                string folderPath = Path.Combine(Application.StartupPath, "ImagenesProducto");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                File.Copy(rutaImagenSeleccionada, rutaDestino, true);
            }
            else
            {
                MessageBox.Show("No se seleccionó ninguna imagen.");
            }
        }

    }
}
    