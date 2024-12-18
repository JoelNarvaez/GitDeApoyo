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
using Org.BouncyCastle.Pqc.Crypto.Saber;


namespace projectM
{
    public partial class FormPago : Form
    {
        private PictureBox pictureBoxQR;
        private string nombreUsuario;
        private FlowLayoutPanel panelClonado;
        List<carrito> carritoPago;
        private decimal monto;
        private int idUsuario;

        public FormPago(FlowLayoutPanel clonedPanel, string nombreUsuario, List<carrito> carritoPago, int idUsuario)
        {
            InitializeComponent();
            this.panelClonado = clonedPanel;
            this.nombreUsuario = nombreUsuario;
            this.idUsuario = idUsuario;
            label1.Text = nombreUsuario;
            panelOxxo.Visible = false;
            panelOxxo.Size = new Size(600, 500);
            this.carritoPago = carritoPago;

            rbtnOxxo.CheckedChanged += rbtnOxxo_CheckedChanged;
            rbtnTarjeta.CheckedChanged += rbtnTarjeta_CheckedChanged;

            panelClonado = new FlowLayoutPanel
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
            this.Controls.Add(panelClonado);

            Label labelEncabezado = new Label
            {
                Text = "Resumen de Compra",
                Font = new Font("Century Gothic", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                Size = new Size(panelClonado.Width - 20, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.White,
            };

            Panel panelDecorativo = new Panel
            {
                Size = new Size(panelClonado.Width - 20, 3),
                BackColor = Color.Black,
                Margin = new Padding(0, 5, 0, 5)
            };

            panelClonado.Controls.Add(labelEncabezado);
            panelClonado.Controls.Add(panelDecorativo);

            foreach (Control control in clonedPanel.Controls)
            {
                if (control is Button)
                    continue;

                Control newControl = CloneControl(control, panelClonado.Width - 20);
                panelClonado.Controls.Add(newControl);
            }

            ResizeFlowLayoutPanel(panelClonado);

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
            FormUsuario formUsuario = new FormUsuario(nombreUsuario, idUsuario);
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

            Button btnAtras = new Button
            {
                Text = "Atrás",
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Size = new Size(botonesAncho, 30),
                Location = new Point(margenHorizontal, pictureBoxQR.Bottom + margenVertical),
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White
            };

            Button btnFin = new Button
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
                MostrarConfirmacion("OXXO", carritoPago, referencia);
                agregarMonto();
                actualizarTablaVentasYBorrarCarrito();
                modificarExistencias();


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

            int tamañoCuadro = 7;

            string logoPath = Path.Combine(Application.StartupPath, "Resources", "NavigaLogoLog.png");

            Bitmap logo = new Bitmap(logoPath);

            int logoWidth = qrCode.GetGraphic(tamañoCuadro).Width / 5;
            int logoHeight = qrCode.GetGraphic(tamañoCuadro).Height / 5;

            Bitmap resizedLogo = new Bitmap(logo, new Size(logoWidth, logoHeight));

            Bitmap qrCodeImage = qrCode.GetGraphic(tamañoCuadro, Color.Black, Color.White, resizedLogo);

            pictureBoxQR.Size = qrCodeImage.Size;
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

            Button btnAtras = new Button
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

            Button btnFin = new Button
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
                MessageBox.Show("Procesando informacion de pago.");
                string numeroTarjeta = txtNumeroTarjeta.Text;
                MostrarConfirmacion("Tarjeta de Crédito", carritoPago, txtNumeroTarjeta.Text);
                agregarMonto();
                actualizarTablaVentasYBorrarCarrito();
                modificarExistencias();

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

        private void MostrarConfirmacion(string metodoPago, List<carrito> carritoPago, string referenciaOTarjeta)
        {
            panelOxxo.Controls.Clear();
            panelOxxo.AutoScroll = true;
            panelClonado.Visible = false;

            PictureBox logo = new PictureBox
            {
                Image = Properties.Resources.NavigaLogoLog,
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point((panelOxxo.Width - 100) / 2, 10),
                BackColor = Color.White
            };

            Label eslogan = new Label
            {
                Text = "Conecta con el futuro",
                Font = new Font("Century Gothic", 12, FontStyle.Italic),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point((panelOxxo.Width - 200) / 2, logo.Bottom + 10)
            };

            Label fechaHora = new Label
            {
                Text = DateTime.Now.ToString("F"),
                Font = new Font("Century Gothic", 10),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point((panelOxxo.Width - 300) / 2, eslogan.Bottom + 20)
            };

            Label lblUsuario = new Label
            {
                Text = $"Nombre: {nombreUsuario}",
                Font = new Font("Century Gothic", 10),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, fechaHora.Bottom + 10)
            };

            Label lblMetodoPago = new Label
            {
                Text = $"Método de Pago: {metodoPago}",
                Font = new Font("Century Gothic", 10),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(10, lblUsuario.Bottom + 10)
            };

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

            Label labelProductos = new Label
            {
                Text = $"Productos (0)",
                ForeColor = Color.Black,
                Font = new Font("Century Gothic", 12, FontStyle.Regular),
                Location = new Point(20, lblReferenciaOTarjeta.Bottom + 20),
                AutoSize = true
            };
            panelOxxo.Controls.Add(labelProductos);

            int X = 20, Y = labelProductos.Bottom + 20;
            int ancho = 450, alto = 100, margenY = 10;
            decimal Total = 0;
            int cuantos = 0;

            usuario obj = new usuario();

            foreach (var p in carritoPago)
            {
                productos producto = obj.obtenerProductoPorId(p.IdProducto);
                if (producto != null)
                {
                    Panel panelProd = new Panel
                    {
                        Size = new Size(ancho, alto),
                        Location = new Point(X, Y),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.White
                    };

                    Y += alto + margenY;

                    Label label = new Label
                    {
                        Text = producto.Descripcion,
                        ForeColor = Color.BlueViolet,
                        Font = new Font("Century Gothic", 12, FontStyle.Bold),
                        Location = new Point(10, 10),
                        AutoSize = true
                    };
                    panelProd.Controls.Add(label);

                    cuantos += p.Cantidad;
                    Label label2 = new Label
                    {
                        Text = "Cantidad: " + p.Cantidad,
                        ForeColor = Color.Black,
                        Font = new Font("Century Gothic", 11, FontStyle.Bold),
                        Location = new Point(10, 40),
                        AutoSize = true
                    };
                    panelProd.Controls.Add(label2);

                    Label label3 = new Label
                    {
                        Text = "$ " + producto.Precio.ToString("F2"),
                        ForeColor = Color.Black,
                        Font = new Font("Century Gothic", 12, FontStyle.Regular),
                        Location = new Point(200, 10),
                        AutoSize = true
                    };
                    panelProd.Controls.Add(label3);

                    Label label4 = new Label
                    {
                        Text = "Total: $ " + (producto.Precio * p.Cantidad).ToString("F2"),
                        ForeColor = Color.DeepPink,
                        Font = new Font("Century Gothic", 12, FontStyle.Regular),
                        Location = new Point(200, 40),
                        AutoSize = true
                    };
                    panelProd.Controls.Add(label4);

                    panelOxxo.Controls.Add(panelProd);

                    Total += producto.Precio * p.Cantidad;

                }
            }
            monto = Total;
            labelProductos.Text = $"Productos ({cuantos})";

            decimal totalFinal = Total * 1.06m;
            decimal totalImpuestos = totalFinal - Total;

            Label labelTotal = new Label
            {
                Text = $"Total: ${Total:F2}",
                ForeColor = Color.Black,
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Location = new Point(20, Y + 10),
                AutoSize = true
            };
            panelOxxo.Controls.Add(labelTotal);

            Label labelImpuestos = new Label
            {
                Text = $"Impuestos (6%): ${totalImpuestos:F2}",
                ForeColor = Color.Black,
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Location = new Point(20, labelTotal.Bottom + 10),
                AutoSize = true
            };


            Label labelTotalConImpuestos = new Label
            {
                Text = $"Total con impuestos: ${totalFinal:F2}",
                ForeColor = Color.Black,
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Location = new Point(20, labelImpuestos.Bottom + 10),
                AutoSize = true
            };

            Button btnDescargar = new Button
            {
                Text = "Descargar Nota",
                ForeColor = Color.White,
                Font = new Font("Century Gothic", 12, FontStyle.Bold),
                Location = new Point((panelOxxo.Width - 200) / 2, labelTotalConImpuestos.Bottom + 10),
                AutoSize = true,
                BackColor = Color.BlueViolet,

            };
            panelOxxo.Controls.Add(btnDescargar);
            panelOxxo.Controls.Add(labelTotalConImpuestos);
            panelOxxo.Controls.Add(labelImpuestos);

            panelOxxo.Visible = true;
            panelOxxo.BringToFront();

            btnDescargar.Click += (s, e) =>
            {
                GenerarPDF generador = new GenerarPDF();
                string nombreArchivo = $"NotaCompra_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";

                generador.CrearPDF(
                    nombreArchivo,
                    metodoPago,
                    carritoPago,
                    referenciaOTarjeta,
                    nombreUsuario,
                    Total,
                    totalImpuestos,
                    totalFinal
                );
                FormUsuario formUsuario = new FormUsuario(nombreUsuario,idUsuario);
                formUsuario.Show();
                this.Close();
            };
        }


        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin nuevoFormulario = new FormLogin();
            nuevoFormulario.Show();
        }


        public void agregarMonto()
        {
            usuario obj = new usuario();
            obj.agregarPersonaMonto(monto, nombreUsuario);
        }

        public void modificarExistencias()
        {
            usuario obj = new usuario();
            obj.compra(carritoPago);
        }

        public void actualizarTablaVentasYBorrarCarrito()
        {
            usuario obj = new usuario();
            obj.actualVentas(carritoPago, idUsuario);
            obj.borrarCarrito(idUsuario);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}