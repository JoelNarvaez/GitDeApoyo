using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QRCoder;

namespace projectM
{
    public partial class FormPago : Form
    {
        private PictureBox pictureBoxQR;

        public FormPago(FlowLayoutPanel panelCarrito)
        {
            InitializeComponent();
            panelOxxo.Visible = false;
            panelOxxo.Size = new Size(600, 500); 


            FlowLayoutPanel panelResumen = new FlowLayoutPanel
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

            panelOxxo.Controls.Add(lblInstrucciones);
            panelOxxo.Controls.Add(lblReferencia);
            panelOxxo.Controls.Add(pictureBoxQR);

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
            panelOxxo.Controls.Clear(); // Limpia el panel antes de agregar nuevos controles

            // Etiqueta principal
            Label lblTitulo = new Label
            {
                Text = "Ingresar datos de tarjeta de crédito",
                Font = new Font("Century Gothic", 16, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // Etiqueta Número de Tarjeta
            Label lblNumeroTarjeta = new Label
            {
                Text = "Número de tarjeta",
                Font = new Font("Century Gothic", 10),
                Location = new Point(10, 50),
                ForeColor = Color.Black, // Opcional para resaltar si es requerido
                AutoSize = true
            };

            TextBox txtNumeroTarjeta = new TextBox
            {
                PlaceholderText = "1234 5678 9101 1121",
                Location = new Point(10, 75),
                Size = new Size(400, 50)
            };

            // Etiqueta Nombre y Apellido
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
                Size = new Size(400, 50)
            };

            // Etiqueta Fecha de Vencimiento
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

            // Etiqueta CVV
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

            // Agregar controles al panel
            panelOxxo.Controls.Add(lblTitulo);
            panelOxxo.Controls.Add(lblNumeroTarjeta);
            panelOxxo.Controls.Add(txtNumeroTarjeta);
            panelOxxo.Controls.Add(lblNombre);
            panelOxxo.Controls.Add(txtNombre);
            panelOxxo.Controls.Add(lblFecha);
            panelOxxo.Controls.Add(txtFecha);
            panelOxxo.Controls.Add(lblCVV);
            panelOxxo.Controls.Add(txtCVV);

            // Opcional: Estilo del panel
            panelOxxo.BackColor = Color.White;
            panelOxxo.BorderStyle = BorderStyle.None;

        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            buttonCerrar.Visible = !buttonCerrar.Visible;
        }

    }
}