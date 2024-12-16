using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QRCoder;
using static projectM.FormUsuario;
using projectM;


namespace projectM
{
    public partial class FormPago : Form
    {
        private PictureBox pictureBoxQR;
        private string nombreUsuario;
        private FlowLayoutPanel panelResumen;
        List<carrito> carritoAux;

        public FormPago(FlowLayoutPanel panelCarrito, string nombreUsuario, List<carrito> carritoAux)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            label1.Text = nombreUsuario;
            panelOxxo.Visible = false;
            panelOxxo.Size = new Size(600, 500);
            this.carritoAux = carritoAux;

            rbtnOxxo.CheckedChanged += rbtnOxxo_CheckedChanged;
            rbtnTarjeta.CheckedChanged += rbtnTarjeta_CheckedChanged;

            panelResumen = new FlowLayoutPanel
            {
                Size = new Size(350, 200),
                Location = new Point(740, 150),
                BackColor = Color.White,
                AutoScroll = false,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(10),
                Margin = new Padding(0)
            };
            this.Controls.Add(panelResumen);

            Label labelEncabezado = new Label
            {
                Text = "Resumen de Compra",
                Font = new Font("Century Gothic", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                Size = new Size(panelResumen.Width - 20, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.White,
            };

            Panel panelDecorativo = new Panel
            {
                Size = new Size(panelResumen.Width - 20, 3),
                BackColor = Color.Black,
                Margin = new Padding(0, 5, 0, 5)
            };

            panelResumen.Controls.Add(labelEncabezado);
            panelResumen.Controls.Add(panelDecorativo);

            foreach (Control control in panelCarrito.Controls)
            {
                if (control is Button)
                    continue;

                Control newControl = CloneControl(control, panelResumen.Width - 20);
                panelResumen.Controls.Add(newControl);
            }

            ResizeFlowLayoutPanel(panelResumen);

        }

        private Control CloneControl(Control original, int newWidth)
        {
            Control newControl;

            if (original is PictureBox originalPictureBox)
            {
                newControl = new PictureBox
                {
                    Image = originalPictureBox.Image,
                    SizeMode = originalPictureBox.SizeMode,
                    Size = new Size(newWidth, originalPictureBox.Height),
                    BackColor = Color.White,
                };
            }
            else
            {
                newControl = new Label
                {
                    Text = original.Text,
                    Font = original.Font,
                    ForeColor = original.ForeColor,
                    BackColor = Color.White,
                    AutoSize = false,
                    Size = new Size(newWidth, 25),
                    TextAlign = ContentAlignment.MiddleLeft
                };
            }
            newControl.Margin = new Padding(0, 5, 0, 5);
            return newControl;
        }

        private void ResizeFlowLayoutPanel(FlowLayoutPanel panel)
        {
            int totalHeight = 0;

            foreach (Control control in panel.Controls)
            {
                totalHeight += control.Height + control.Margin.Top + control.Margin.Bottom;
            }

            panel.Height = totalHeight + panel.Padding.Top + panel.Padding.Bottom;
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

        private void botonRedondo1_Click_1(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.Show();
            this.Close();
        }


        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (rbtnOxxo.Checked)
            {
                MostrarOxxo();
            }
            else if (rbtnTarjeta.Checked)
            {
                MostrarTarjeta();
                panelOxxo.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un método de pago.");
            }
        }

        private void MostrarOxxo()
        {
            panelOxxo.Controls.Clear();

            Label lblInstrucciones = new Label
            {
                Text = "Instrucciones para pagar en OXXO:\n\n1. Ve a cualquier tienda OXXO.\n2. Indica que quieres pagar un servicio.\n3. Proporciona el número de referencia o muestra el código QR.\n4. Realiza el pago en efectivo.",
                Font = new Font("Century Gothic", 12),
                Size = new Size(380, 150),
                Location = new Point(10, 10),
                AutoSize = false
            };

            string referencia = NumeroReferencia();
            Label lblReferencia = new Label
            {
                Text = $"Número de referencia OXXO: {referencia}",
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, lblInstrucciones.Bottom + 10),
                ForeColor = Color.Black
            };

            pictureBoxQR = new PictureBox
            {
                Size = new Size(150, 150),
                Location = new Point((panelOxxo.Width - 150) / 2, lblReferencia.Bottom + 20),
                BackColor = Color.White
            };

            MostrarCodigoQR(referencia);

            int botonesAncho = 80;
            int margenHorizontal = 20;
            int margenVertical = 30;

            Button btnAtras = new RoundedButton
            {
                Text = "Atrás",
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Size = new Size(botonesAncho, 30),
                Location = new Point(margenHorizontal, pictureBoxQR.Bottom + margenVertical),
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White
            };

            Button btnFin = new RoundedButton
            {
                Text = "Finalizar Compra",
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Size = new Size(botonesAncho + 80, 30),
                Location = new Point(panelOxxo.Width - botonesAncho - margenHorizontal - 90, pictureBoxQR.Bottom + margenVertical),
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White
            };

            btnFin.Click += (sender, e) =>
            {
                MessageBox.Show("Procesando informacion de pago.");
                MostrarConfirmacion("OXXO", carritoAux, referencia);

            };

            btnAtras.Click += (sender, e) =>
            {
                panelOxxo.Visible = false;
                panelOxxo.Controls.Clear();
            };

            panelOxxo.Controls.Add(lblInstrucciones);
            panelOxxo.Controls.Add(lblReferencia);
            panelOxxo.Controls.Add(pictureBoxQR);
            panelOxxo.Controls.Add(btnAtras);
            panelOxxo.Controls.Add(btnFin);

            panelOxxo.Visible = true;
            panelOxxo.BringToFront();
        }

        private string NumeroReferencia()
        {
            Random rnd = new Random();
            long numero = (long)(rnd.NextDouble() * 9_000_000_000L) + 1_000_000_000L;
            return numero.ToString();
        }

        private void MostrarCodigoQR(string texto)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            int tamañoCuadro = 5;
            Bitmap qrCodeImage = qrCode.GetGraphic(tamañoCuadro);
            pictureBoxQR.Image = qrCodeImage;
        }

        private void btnGenerarCodigoQR_Click(object sender, EventArgs e)
        {
            string referencia = NumeroReferencia();
            MostrarCodigoQR(referencia);
        }

        private void MostrarTarjeta()
        {
            panelOxxo.Controls.Clear();

            Label lblTitulo = new Label
            {
                Text = "Ingresar datos de tarjeta de crédito",
                Font = new Font("Century Gothic", 16, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblNumeroTarjeta = new Label
            {
                Text = "Número de tarjeta",
                Font = new Font("Century Gothic", 10),
                Location = new Point(10, 50),
                ForeColor = Color.Black,
                AutoSize = true
            };

            TextBox txtNumeroTarjeta = new TextBox
            {
                PlaceholderText = "1234 5678 9101 1121",
                Location = new Point(10, 75),
                Size = new Size(400, 30)
            };

            Label lblNombre = new Label
            {
                Text = "Nombre y apellido",
                Font = new Font("Century Gothic", 10),
                Location = new Point(10, 120),
                AutoSize = true
            };

            TextBox txtNombre = new TextBox
            {
                Location = new Point(10, 145),
                Size = new Size(400, 30)
            };

            Label lblFecha = new Label
            {
                Text = "Fecha de vencimiento",
                Font = new Font("Century Gothic", 10),
                Location = new Point(10, 190),
                AutoSize = true
            };

            TextBox txtFecha = new TextBox
            {
                PlaceholderText = "MM/AA",
                Location = new Point(10, 215),
                Size = new Size(100, 30)
            };


            Label lblCVV = new Label
            {
                Text = "Código de seguridad",
                Font = new Font("Century Gothic", 10),
                Location = new Point(130, 190),
                AutoSize = true
            };

            TextBox txtCVV = new TextBox
            {
                PlaceholderText = "CVV",
                Location = new Point(130, 215),
                Size = new Size(80, 30)
            };

            int botonesAncho = 80;
            int margenHorizontal = 20;
            int margenVertical = 30;

            Button btnAtras = new RoundedButton
            {
                Text = "Atrás",
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Size = new Size(botonesAncho, 30),
                Location = new Point(margenHorizontal, txtFecha.Bottom + margenVertical),
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White
            };

            btnAtras.Click += (sender, e) =>
            {
                panelOxxo.Visible = false;
                panelOxxo.Controls.Clear();
            };

            Button btnFin = new RoundedButton
            {
                Text = "Finalizar Compra",
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Size = new Size(botonesAncho + 80, 30),
                Location = new Point(panelOxxo.Width - botonesAncho - margenHorizontal - 90, txtFecha.Bottom + margenVertical),
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White
            };

            btnFin.Click += (sender, e) =>
            {
                if (!ValidarTarjeta(txtNumeroTarjeta.Text))
                {
                    MessageBox.Show("Número de tarjeta inválido. Por favor verifica el formato.");
                    return;
                }

                MessageBox.Show("Procesando informacion de pago.");
                string numeroTarjeta = txtNumeroTarjeta.Text;
                MostrarConfirmacion("Tarjeta de Crédito", carritoAux, txtNumeroTarjeta.Text);


            };

            panelOxxo.Controls.Add(lblTitulo);
            panelOxxo.Controls.Add(lblNumeroTarjeta);
            panelOxxo.Controls.Add(txtNumeroTarjeta);
            panelOxxo.Controls.Add(lblNombre);
            panelOxxo.Controls.Add(txtNombre);
            panelOxxo.Controls.Add(lblFecha);
            panelOxxo.Controls.Add(txtFecha);
            panelOxxo.Controls.Add(lblCVV);
            panelOxxo.Controls.Add(txtCVV);
            panelOxxo.Controls.Add(btnAtras);
            panelOxxo.Controls.Add(btnFin);

            panelOxxo.BackColor = Color.White;
            panelOxxo.BorderStyle = BorderStyle.None;

            panelOxxo.Visible = true;
            panelOxxo.BringToFront();
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

        private void rbtnOxxo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOxxo.Checked)
            {
                rbtnTarjeta.Checked = false;
            }
        }

        private void rbtnTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTarjeta.Checked)
            {
                rbtnOxxo.Checked = false;
            }
        }

        private void panelOxxo_Paint(object sender, PaintEventArgs e)
        {

        }

        public class RoundedButton : Button
        {
            protected override void OnPaint(PaintEventArgs pevent)
            {
                base.OnPaint(pevent);
                Graphics g = pevent.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);
                    path.AddArc(new Rectangle(Width - 20, 0, 20, 20), 270, 90);
                    path.AddArc(new Rectangle(Width - 20, Height - 20, 20, 20), 0, 90);
                    path.AddArc(new Rectangle(0, Height - 20, 20, 20), 90, 90);
                    path.CloseAllFigures();
                    this.Region = new Region(path);
                }
            }
        }
        private void MostrarConfirmacion(string metodoPago, List<carrito> carritoAux, string referenciaOTarjeta)
        {
            panelOxxo.Controls.Clear();

            // Logo
            PictureBox logo = new PictureBox
            {
                Image = Properties.Resources.NavigaLogo1, // Asegúrate de tener un recurso de logo agregado.
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point((panelOxxo.Width - 100) / 2, 10),
                BackColor = Color.White
            };

            // Eslogan
            Label eslogan = new Label
            {
                Text = "Conecta con el futuro",
                Font = new Font("Century Gothic", 12, FontStyle.Italic),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point((panelOxxo.Width - 200) / 2, logo.Bottom + 10)
            };

            // Fecha y Hora
            Label fechaHora = new Label
            {
                Text = DateTime.Now.ToString("F"),
                Font = new Font("Century Gothic", 10),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point((panelOxxo.Width - 200) / 2, eslogan.Bottom + 20)
            };

            // Nombre de usuario
            Label lblUsuario = new Label
            {
                Text = $"Nombre: {nombreUsuario}",
                Font = new Font("Century Gothic", 10),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, fechaHora.Bottom + 10)
            };

            // Método de pago
            Label lblMetodoPago = new Label
            {
                Text = $"Método de Pago: {metodoPago}",
                Font = new Font("Century Gothic", 10),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, lblUsuario.Bottom + 10)
            };

            // Referencia o número de tarjeta
            Label lblReferenciaOTarjeta = new Label
            {
                Text = metodoPago == "OXXO" ? $"Número de referencia: {referenciaOTarjeta}" : $"Número de tarjeta: {referenciaOTarjeta}",
                Font = new Font("Century Gothic", 10),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, lblMetodoPago.Bottom + 10)
            };

            panelOxxo.Controls.Add(logo);
            panelOxxo.Controls.Add(eslogan);
            panelOxxo.Controls.Add(fechaHora);
            panelOxxo.Controls.Add(lblUsuario);
            panelOxxo.Controls.Add(lblMetodoPago);
            panelOxxo.Controls.Add(lblReferenciaOTarjeta);

            // Productos
            Button btnFinalizar = new RoundedButton
            {
                Text = "Finalizar",
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Size = new Size(100, 40),
                Location = new Point((panelOxxo.Width - 100) / 2, lblReferenciaOTarjeta.Bottom + 20),
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White
            };

            btnFinalizar.Click += (sender, e) =>
            {
                int yPosition = lblReferenciaOTarjeta.Bottom + 50;
                decimal total = 0;

                foreach (var producto in carritoAux)
                {
                    Label lblProducto = new Label
                    {
                        Text = $"- {producto.IdProducto} (x{producto.Cantidad}): ${producto.Precio * producto.Cantidad:F2}",
                        Font = new Font("Century Gothic", 10),
                        ForeColor = Color.Black,
                        AutoSize = true,
                        Location = new Point(20, yPosition)
                    };
                    panelOxxo.Controls.Add(lblProducto);
                    yPosition = lblProducto.Bottom + 5;
                    total += producto.Precio * producto.Cantidad;
                }

                // Total sin impuestos
                Label lblTotal = new Label
                {
                    Text = $"Total: ${total:F2}",
                    Font = new Font("Century Gothic", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Location = new Point(10, yPosition + 10)
                };

                // Total con impuestos
                decimal totalConImpuestos = total * 1.06m;
                Label lblTotalConImpuestos = new Label
                {
                    Text = $"Total con impuestos (6%): ${totalConImpuestos:F2}",
                    Font = new Font("Century Gothic", 12, FontStyle.Bold),
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Location = new Point(10, lblTotal.Bottom + 10)
                };

                panelOxxo.Controls.Add(lblTotal);
                panelOxxo.Controls.Add(lblTotalConImpuestos);
                panelOxxo.Visible = true;
                panelOxxo.BringToFront();
            };

            panelOxxo.Controls.Add(btnFinalizar);
        }


        private bool ValidarTarjeta(string numeroTarjeta)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(numeroTarjeta, @"^\d{4} \d{4} \d{4} \d{4}$");
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin nuevoFormulario = new FormLogin();
            nuevoFormulario.Show();
        }
    }
}