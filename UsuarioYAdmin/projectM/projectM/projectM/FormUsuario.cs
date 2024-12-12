using System.Runtime.InteropServices;

namespace projectM
{
    public partial class FormUsuario : Form
    {
        home viewHome;
        Gaming viewGaming;
        Perifericos viewPerifericos;
        Acerca viewAcerca;

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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        bool expandSubMenu = true;
        bool sidebarExpand = false;

        private void Form1_Load(object sender, EventArgs e)
        {

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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (viewGaming == null)
            {
                viewGaming = new Gaming
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
            if (viewPerifericos == null)
            {
                viewPerifericos = new Perifericos
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
        }
    }
}
