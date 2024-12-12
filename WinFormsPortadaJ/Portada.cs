using System.Media;
using System.Numerics;
using System.Runtime.InteropServices;
using projectM;

namespace WinFormsPortada2
{

    public partial class Portada : Form
    {
        private SoundPlayer player;
        private bool isPlaying = false; // Variable de estado

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int left,
                int top,
                int right,
                int bottom,
                int width,
                int height
            );

        int[] rainSpeeds = { 10, 16, 14, 12, 10, 16, 14, 12, 20, 14, 17, 10 };
        int loadingSpeed = 2;
        float initialPercentage = 0;

        public Portada()
        {
            InitializeComponent();
            player = new SoundPlayer(new MemoryStream(Properties.Resources.musicaIntro));
            player.PlayLooping();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 9, 9));
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                switch (i)
                {
                    case 0:
                        pictureBox21.Location = new Point(pictureBox21.Location.X + rainSpeeds[i], pictureBox21.Location.Y);

                        if (pictureBox21.Location.X > panel1.Size.Width + pictureBox21.Size.Width)
                        {
                            pictureBox21.Location = new Point(0 - pictureBox21.Size.Width, pictureBox21.Location.Y);
                        }
                        break;

                    case 1:
                        pictureBox17.Location = new Point(pictureBox17.Location.X, pictureBox17.Location.Y + rainSpeeds[i]);
                        if (pictureBox17.Location.Y > panel1.Size.Height + pictureBox17.Size.Height)
                        {
                            pictureBox17.Location = new Point(pictureBox17.Location.X, 0 - pictureBox17.Size.Height);
                        }
                        break;
                    case 2:
                        pictureBox18.Location = new Point(pictureBox18.Location.X + rainSpeeds[i], pictureBox18.Location.Y);

                        if (pictureBox18.Location.X > panel1.Size.Width + pictureBox18.Size.Width)
                        {
                            pictureBox18.Location = new Point(0 - pictureBox18.Size.Width, pictureBox18.Location.Y);
                        }
                        break;
                    case 3:
                        pictureBox19.Location = new Point(pictureBox19.Location.X + rainSpeeds[i], pictureBox19.Location.Y);

                        if (pictureBox19.Location.X > panel1.Size.Width + pictureBox19.Size.Width)
                        {
                            pictureBox19.Location = new Point(0 - pictureBox19.Size.Width, pictureBox19.Location.Y);
                        }
                        break;
                    case 4:
                        pictureBox20.Location = new Point(pictureBox20.Location.X, pictureBox20.Location.Y + rainSpeeds[i]);
                        if (pictureBox20.Location.Y > panel1.Size.Height + pictureBox20.Size.Height)
                        {
                            pictureBox20.Location = new Point(pictureBox20.Location.X, 0 - pictureBox20.Size.Height);
                        }
                        break;
                    case 5:
                        pictureBox38.Location = new Point(pictureBox38.Location.X, pictureBox38.Location.Y + rainSpeeds[i]);
                        if (pictureBox38.Location.Y > panel1.Size.Height + pictureBox38.Size.Height)
                        {
                            pictureBox38.Location = new Point(pictureBox38.Location.X, 0 - pictureBox38.Size.Height);
                        }
                        break;
                    case 6:
                        pictureBox30.Location = new Point(pictureBox30.Location.X, pictureBox30.Location.Y + rainSpeeds[i]);
                        if (pictureBox30.Location.Y > panel2.Size.Height + pictureBox38.Size.Height)
                        {
                            pictureBox30.Location = new Point(pictureBox30.Location.X, 0 - pictureBox30.Size.Height);
                        }
                        break;
                    case 7:
                        pictureBox16.Location = new Point(pictureBox16.Location.X, pictureBox16.Location.Y + rainSpeeds[i]);
                        if (pictureBox16.Location.Y > panel2.Size.Height + pictureBox38.Size.Height)
                        {
                            pictureBox16.Location = new Point(pictureBox16.Location.X, 0 - pictureBox16.Size.Height);
                        }
                        break;
                    case 8:
                        pictureBox29.Location = new Point(pictureBox29.Location.X, pictureBox29.Location.Y + rainSpeeds[i]);
                        if (pictureBox29.Location.Y > panel2.Size.Height + pictureBox29.Size.Height)
                        {
                            pictureBox29.Location = new Point(pictureBox29.Location.X, 0 - pictureBox29.Size.Height);
                        }
                        break;
                    case 9:
                        pictureBox14.Location = new Point(pictureBox14.Location.X + rainSpeeds[i], pictureBox14.Location.Y);

                        if (pictureBox14.Location.X > panel2.Size.Width + pictureBox21.Size.Width)
                        {
                            pictureBox14.Location = new Point(0 - pictureBox14.Size.Width, pictureBox14.Location.Y);
                        }
                        break;
                    case 10:
                        pictureBox22.Location = new Point(pictureBox22.Location.X + rainSpeeds[i], pictureBox22.Location.Y);

                        if (pictureBox22.Location.X > panel2.Size.Width + pictureBox21.Size.Width)
                        {
                            pictureBox22.Location = new Point(0 - pictureBox22.Size.Width, pictureBox22.Location.Y);
                        }
                        break;
                    case 11:
                        pictureBox28.Location = new Point(pictureBox28.Location.X + rainSpeeds[i], pictureBox28.Location.Y);

                        if (pictureBox28.Location.X > panel2.Size.Width + pictureBox21.Size.Width)
                        {
                            pictureBox29.Location = new Point(0 - pictureBox28.Size.Width, pictureBox28.Location.Y);
                        }
                        break;
                }
            }
            labelH.Text = DateTime.Now.ToLongTimeString();
            labelF.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            FormLogin nuevoFormulario = new FormLogin();
            nuevoFormulario.Show();
            this.Hide();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                player.Stop();
                isPlaying = false;
                
            }
            else
            {
                player.PlayLooping();
                isPlaying = true;
            }
        }
    }
}
