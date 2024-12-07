namespace WinFormLogin
{
    public partial class FormLogin : Form
    {
        private bool controlTimer = false;

        public FormLogin()
        {
            InitializeComponent();
            txtUsu.Enter += txtEnter;
            txtUsu.Leave += txtLeave;
            txtContra.Enter += txtEnter;
            txtContra.Leave += txtLeave;
            btnEntrar.MouseEnter += btnMouseEnter;
            btnEntrar.MouseLeave += btnMouseLeave;
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFech.Text = DateTime.Now.ToLongDateString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pContenedor.Visible = false;
            pPrincipal.Visible = true;
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
                pContra.BringToFront();

                if (pContenedor.Left <= 0)
                {
                    pContenedor.Left = 0;
                    timer1.Stop();
                    controlTimer = false;
                }
            }
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("si");
            string username = txtUsu.Text;
            string password = txtContra.Text;

            BD bd = new BD();
            bd.Login(username, password);
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinCont_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaxCont_Click_1(object sender, EventArgs e)
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
                panel4.Visible = false;
            }
        }
    }





}
