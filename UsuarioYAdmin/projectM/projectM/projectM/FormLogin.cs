namespace projectM
{
    public partial class FormLogin : Form
    {
        private bool controlTimer = false;

        public FormLogin()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            txtUsuario.Enter += txtEnter;
            txtUsuario.Leave += txtLeave;
            txtContrasena.Enter += txtEnter;
            txtContrasena.Leave += txtLeave;
            btnEntrar.MouseEnter += btnMouseEnter;
            btnEntrar.MouseLeave += btnMouseLeave;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pContenedor.Visible = false;
            pPrincipal.Visible = true;
            labelFecha.Text = DateTime.Now.ToLongDateString();
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt != null)
            {
                bt.ForeColor = Color.Black;
            }
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt != null)
            {
                bt.ForeColor = Color.White;
            }
        }

        private void txtEnter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                foreach (Control ctr in pContenedor.Controls)
                {
                    if (ctr is Panel && ctr.Name == "p" + txt.Tag?.ToString())
                    {
                        ctr.BackColor = Color.Black;
                        break;
                    }
                }
            }
        }

        private void txtLeave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                foreach (Control ctr in pContenedor.Controls)
                {
                    if (ctr is Panel && ctr.Name == "p" + txt.Tag?.ToString())
                    {
                        ctr.BackColor = Color.Silver;
                        break;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!controlTimer)
            {
                pContenedor.Left += 10;
                pContenedor.BringToFront();

                if (pContenedor.Left >= 556)
                {
                    pContenedor.Left = 556;
                    timer1.Stop();
                    controlTimer = true;
                }
            }
            else
            {
                pContenedor.Left -= 10;

                if (pContenedor.Left <= 0)
                {
                    pContenedor.Left = 0;
                    timer1.Stop();
                    controlTimer = false;
                }
            }
        }

        private void btnMinimized_Click_1(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximized_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }


        private void buttonCloseCont_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void botonRedondo2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                pContenedor.Visible = true;
                timer1.Start();
            }
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtContrasena.Text;

            BD bd = new BD(validoOno);
            bool loginExitoso = bd.Login(username, password);

            if (loginExitoso)
            {
                bd.Disconnect();
                this.Close();
            }
            else
            {
                bd.ActualizarTexto("Usuario o Contraseña invalidos");

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;
        }


        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {

            labelFecha.Text = DateTime.Now.ToLongDateString();
            labelHora.Text = DateTime.Now.ToLongTimeString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelRedondo1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}






