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
        Gaming viewGaming;
        Perifericos viewPerifericos;
        Acerca viewacerca;
        Grafica viewgrafica;
        Editar vieweditar;
        private string nombreUsuario;
        private int idUsuario;
        public bool isUsuario=false;

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
        public FormAdmin(string nombreUsuario, int idUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.idUsuario = idUsuario;
            this.Load += FormAdmin_Load;
            viewhome = new home(isUsuario)

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
                if (barOpc.Height >= 209)
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

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            labelAdmin.Text = nombreUsuario;
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
            FormLogin nuevoFormulario = new FormLogin();
            nuevoFormulario.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (viewhome == null)
            {
                viewhome = new home(false)
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewhome.Show();
            }
            else
            {
                viewhome = new home(false)
                {
                    MdiParent = this,
                    Dock = DockStyle.Fill
                };
                viewhome.Show();
                //viewhome.Activate();
            }
        }

        private void btnPerifericos_Click(object sender, EventArgs e)
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


        private void btnGaming_Click(object sender, EventArgs e)
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
                vieweditar = new Editar(idUsuario)
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

        private void btnExist_Click(object sender, EventArgs e)
        {
            administrador obj = new administrador();
            List<productos> existencias = obj.listExist();

            dgvExistencias.Rows.Clear();

            foreach (var producto in existencias)
            {
                int rowIndex = dgvExistencias.Rows.Add();

                dgvExistencias.Rows[rowIndex].Cells["IdProducto"].Value = producto.Id;
                dgvExistencias.Rows[rowIndex].Cells["descripcion"].Value = producto.Descripcion;
                dgvExistencias.Rows[rowIndex].Cells["precio"].Value = producto.Precio;
                dgvExistencias.Rows[rowIndex].Cells["existencias"].Value = producto.Existencias;
                dgvExistencias.Rows[rowIndex].Cells["coleccion"].Value = producto.Coleccion;
            }

            pnlExist.Visible = !pnlExist.Visible;

        }

        private void btnCerrarExist_Click(object sender, EventArgs e)
        {
            pnlExist.Visible=false;
        }
    }
}
