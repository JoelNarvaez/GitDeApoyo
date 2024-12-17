using System.Drawing.Printing;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public bool isUsuario = true;
        private List<carrito> carritoPago = new List<carrito>();
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
            viewHome = new home(isUsuario)

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
                viewHome = new home(true)
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewHome.Show();
            }
            else
            {
                viewHome = new home(true)
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewHome.Show();
                //viewHome.Activate();
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
            if (viewGaming == null)
            {
                viewGaming = new Gaming(idUsuario, isUsuario)
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewGaming.Show();
            }
            else
            {
                viewGaming.Dispose();
                viewGaming = new Gaming(idUsuario, isUsuario)
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewGaming.Show();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (viewPerifericos == null)
            {
                viewPerifericos = new Perifericos(idUsuario, isUsuario)
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewPerifericos.Show();
            }
            else
            {
                viewPerifericos.Dispose();
                viewPerifericos = new Perifericos(idUsuario, isUsuario)
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewPerifericos.Show();
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
            pnlProductos.Controls.Clear();
            mostrarCarro();
        }

        private void mostrarCarro()
        {
            usuario obj = new usuario();

            List<carrito> carritoAux = obj.getcarrito(idUsuario);
            carritoPago = obj.getcarrito(idUsuario);
            int cuantos = 0;
            pnlProductos.AutoScroll = true;
            pnlProductos.Size = new Size(550, 900);
            pnlProductos.Location = new Point(25, 25);
            pnlProductos.Visible = true;

            int X = 20, Y = 20;
            int ancho = 450, alto = 200, margenY = 10;
            int Total = 0;

            if (carritoAux.Count == 0)
            {
                MessageBox.Show("NO HAY PRODUCTOS");
                return;
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
                        string rutaImg = Path.Combine(Application.StartupPath, "ImagenesProducto", producto.Imagen);
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
                    pnlProductos.Controls.Add(panelProd);

                    Total += producto.Precio * p.Cantidad;

                    if (p==carritoAux.Last())
                    {
                        Y += 80;
                        Label labelResumen = new Label();
                        labelResumen.ForeColor = Color.Black;
                        labelResumen.Font = new Font("Century Gothic", 16, FontStyle.Bold);
                        labelResumen.Location = new Point(70, Y);
                        pnlProductos.Controls.Add(labelResumen);

                        Y += 50;

                        Label labelProductos = new Label();
                        labelProductos.Text = $"Productos ({cuantos}):                   ${Total}";
                        labelProductos.ForeColor = Color.Black;
                        labelProductos.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                        labelProductos.AutoSize = false; // Desactiva AutoSize
                        labelProductos.Size = new Size(300, 30); // Aumenta el tamaño de la etiqueta
                        labelProductos.Location = new Point(70, Y);
                        pnlProductos.Controls.Add(labelProductos);

                        Y += 50;

                        Label labelEnvios = new Label();
                        labelEnvios.Text = $"Envios ({cuantos}):                          Gratis";
                        labelEnvios.ForeColor = Color.Black;
                        labelEnvios.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                        labelEnvios.AutoSize = false;
                        labelEnvios.Size = new Size(300, 30);
                        labelEnvios.Location = new Point(70, Y);
                        pnlProductos.Controls.Add(labelEnvios);

                        Y += 50;

                        Label labelTotal = new Label();
                        labelTotal.Text = $"Total a pagar:                     ${Total}";
                        labelTotal.ForeColor = Color.Black;
                        labelTotal.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                        labelTotal.AutoSize = false;
                        labelTotal.Size = new Size(300, 30);
                        labelTotal.Location = new Point(70, Y);
                        pnlProductos.Controls.Add(labelTotal);
                    }

                }
            }
            

            pnlProductos.Height = Y + 100;
            pnlProductos.Visible = true;

            pnlCarrito.Visible = !pnlCarrito.Visible;
        }

        private FlowLayoutPanel ClonePanel(Panel originalPanel)
        {
            // Crear un nuevo FlowLayoutPanel con las mismas propiedades generales
            FlowLayoutPanel newPanel = new FlowLayoutPanel
            {
                Size = originalPanel.Size,
                Location = originalPanel.Location,
                BackColor = originalPanel.BackColor,
                BorderStyle = originalPanel.BorderStyle,
                AutoScroll = true, // Habilitar desplazamiento si es necesario
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(5),
                Margin = new Padding(5)
            };

            // Iterar sobre los controles del panel original
            foreach (Control control in originalPanel.Controls)
            {
                if (control is Label originalLabel)
                {
                    // Crear un nuevo Label con las propiedades de texto y estilo
                    Label newLabel = new Label
                    {
                        Text = originalLabel.Text,
                        Font = originalLabel.Font,
                        ForeColor = originalLabel.ForeColor,
                        BackColor = originalLabel.BackColor,
                        AutoSize = true, // Ajustar automáticamente el tamaño
                        Margin = new Padding(0, 5, 0, 0) // Márgenes
                    };
                    newPanel.Controls.Add(newLabel);
                }
                else if (control is Button originalButton || control is PictureBox originalPictureBox)
                {
                    continue;
                }
                else if (control is TextBox originalTextBox)
                {
                    // Crear un nuevo TextBox con las propiedades de texto
                    TextBox newTextBox = new TextBox
                    {
                        Text = originalTextBox.Text,
                        Font = originalTextBox.Font,
                        ForeColor = originalTextBox.ForeColor,
                        BackColor = originalTextBox.BackColor,
                        Size = originalTextBox.Size,
                        Margin = new Padding(0, 5, 0, 0)
                    };
                    newPanel.Controls.Add(newTextBox);
                }
            }

            return newPanel;
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel clonedPanel = ClonePanel(pnlProductos);
            FormPago formPago = new FormPago(clonedPanel, nombreUsuario, carritoPago, idUsuario);
            formPago.Show();
            this.Close();

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DialogResult result = MessageBox.Show("¿Eliminar carrito definitivamente?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (btn != null)
            {
                usuario obj = new usuario();
                obj.borrarCarrito(idUsuario);
                pnlCarrito.Hide();
            }
            else
            {
                MessageBox.Show("Se cancelo la eliminacion");
            }
           
        }
    }
}
