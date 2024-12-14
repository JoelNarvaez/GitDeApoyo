using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace projectM
{
    public partial class FormUsuario : Form
    {
        home viewHome;
        Gaming viewGaming;
        Perifericos viewPerifericos;
        Acerca viewAcerca;
        private string nombreUsuario;
        private int idUsuario;

        public FormUsuario()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            viewHome = new home()

            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };

            viewHome.Show();

        }
        public FormUsuario(string nombreUsuario, int idUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.idUsuario = idUsuario;
            viewHome = new home()

            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };

            viewHome.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        bool expandSubMenu = true;
        bool sidebarExpand = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = nombreUsuario;
        }

        private void subMenuTransition_Tick(object sender, EventArgs e)
        {

            if (!expandSubMenu)
            {
                subMenuContainer.Height += 5;
                if (subMenuContainer.Height >= 135)
                {
                    subMenuTransition.Stop();
                    expandSubMenu = true;
                }
            }
            else
            {
                subMenuContainer.Height -= 5;
                if (subMenuContainer.Height <= 44)
                {

                    subMenuTransition.Stop();
                    expandSubMenu = false;
                }
            }

        }

        private void btnSubMenu_Click(object sender, EventArgs e)
        {
            subMenuTransition.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 64)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 215)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                }
            }
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (viewHome == null)
            {
                viewHome = new home
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewHome.Show();
            }
            else
            {
                viewHome.Activate();
            }
        }



        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin nuevoFormulario = new FormLogin();
            nuevoFormulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (viewGaming == null || viewGaming.IsDisposed)
            {
                viewGaming = new Gaming(idUsuario)
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewGaming.Show();
            }
            else
            {
                viewGaming.Activate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (viewPerifericos == null || viewPerifericos.IsDisposed)
            {
                viewPerifericos = new Perifericos(idUsuario)
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewPerifericos.Show();
            }
            else
            {
                viewPerifericos.Activate();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (viewAcerca == null)
            {
                viewAcerca = new Acerca()
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewAcerca.Show();
            }
            else
            {
                viewAcerca.Activate();
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            buttonCerrar.Visible = !buttonCerrar.Visible;
        }



        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin nuevoFormulario = new FormLogin();
            nuevoFormulario.Show();
        }

        private void btnPagaroComp_Click(object sender, EventArgs e)
        {
            pnlProductos.AutoScroll = true;
            pnlProductos.Size = new Size(550, 900);
            pnlProductos.Location = new Point(25, 25);
            pnlProductos.Visible = true;
            int X = 20, Y = 20;
            int ancho = 450, alto = 200, margenY = 10;
            int Total = 0;
            List<carrito> carritoAux = new List<carrito>();

            usuario obj = new usuario();

            carritoAux = obj.getcarrito(idUsuario);

            if (carritoAux.Count == 0)
            {
                MessageBox.Show("NO HAY PRODUCTOS");
                return; // Salir si no hay productos
            }

            foreach (var p in carritoAux)
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
                        var imagen = (Image)Properties.Resources.ResourceManager.GetObject(producto.Imagen.Split('.')[0]);
                        if (imagen != null)
                        {
                            pictureBox.Image = imagen;
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
                    label2.ForeColor = Color.Black;
                    label2.Font = new Font("Century Gothic", 11, FontStyle.Bold);
                    label2.Location = new Point(210, 50);
                    panelProd.Controls.Add(label2);

                    /*Button button = new Button();
                    button.Image = Properties.Resources.comp;
                    button.ImageAlign = ContentAlignment.MiddleCenter;
                    button.Size = new Size(35, 35);
                    button.Location = new Point(120, 10);
                    button.FlatStyle = FlatStyle.Flat;
                    button.Tag = p.Id;
                    //button.Click += new EventHandler(button_Click);
                    panelProd.Controls.Add(button);

                    Label label2 = new Label();
                    label2.Text = Convert.ToString(p.Existencias);
                    label2.ForeColor = Color.Black;
                    label2.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                    label2.Location = new Point(200, 10);
                    panelProd.Controls.Add(label2);*/

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
                    pnlProductos.Controls.Add(panelProd);

                    Total += producto.Precio * p.Cantidad;

                    if (p == carritoAux.Last())
                    {
                        Label label5 = new Label();
                        label5.Text = "Total: " + (Total);
                        label5.ForeColor = Color.Black;
                        label5.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                        label5.Location = new Point(600, pnlProductos.Height + 20);
                        pnlProductos.Controls.Add(label5);
                    }
                }
            }
            pnlProductos.Height = Y + 100;
            pnlCarrito.Visible = !pnlCarrito.Visible;

        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {

        }
    }
}
