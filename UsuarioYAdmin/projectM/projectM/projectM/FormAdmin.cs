using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectM
{
    public partial class FormAdmin : Form
    {
        home viewhome;
        Gaming viewgaming;
        Perifericos viewperifericos;
        Acerca viewacerca;
        Grafica viewgrafica;
        Editar vieweditar;

        bool expandOpc = true;
        public FormAdmin()
        {
            InitializeComponent();
            viewhome = new home()

            {
                MdiParent = this,
                Dock = DockStyle.Fill
            };

            viewhome.Show();
        }

        private void btnDesp_Click(object sender, EventArgs e)
        {
            timerOpc.Start();
        }

        private void timerOpc_Tick(object sender, EventArgs e)
        {
            if (!expandOpc)
            {
                barOpc.Height += 5;
                if (barOpc.Height >= 159)
                {
                    timerOpc.Stop();
                    expandOpc = true;
                }
            }
            else
            {
                barOpc.Height -= 5;
                if (barOpc.Height <= 0)
                {

                    timerOpc.Stop();
                    expandOpc = false;
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (viewhome == null)
            {
                viewhome = new home
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewhome.Show();
            }
            else
            {
                viewhome.Activate();
            }
        }

        private void btnPerifericos_Click(object sender, EventArgs e)
        {
            if (viewperifericos == null)
            {
                viewperifericos = new Perifericos
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewperifericos.Show();
            }
            else
            {
                viewperifericos.Activate();
            }
        }

        private void btnGaming_Click(object sender, EventArgs e)
        {
            if (viewgaming == null)
            {
                viewgaming = new Gaming
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewgaming.Show();
            }
            else
            {
                viewgaming.Activate();
            }
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            if (viewacerca == null)
            {
                viewacerca = new Acerca
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewacerca.Show();
            }
            else
            {
                viewacerca.Activate();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (vieweditar == null)
            {
                vieweditar = new Editar
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                vieweditar.Show();
            }
            else
            {
                vieweditar.Activate();
            }
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            if (viewgrafica == null)
            {
                viewgrafica = new Grafica
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewgrafica.Show();
            }
            else
            {
                viewgrafica.Activate();
            }
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToLongDateString();
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }

    }
}
