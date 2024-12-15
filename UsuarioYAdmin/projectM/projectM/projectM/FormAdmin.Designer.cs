namespace projectM
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            btnPerifericos = new Button();
            btnGaming = new Button();
            btnAcerca = new Button();
            btnHome = new Button();
            panel4 = new Panel();
            btnDesp = new Button();
            labelAdmin = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            labelHora = new Label();
            labelFecha = new Label();
            buttonMin = new Button();
            buttonMax = new Button();
            buttonClose = new Button();
            buttonCerrar = new Button();
            barOpc = new FlowLayoutPanel();
            btnEditar = new Button();
            btnGrafica = new Button();
            btnExist = new Button();
            timerOpc = new System.Windows.Forms.Timer(components);
            HoraFecha = new System.Windows.Forms.Timer(components);
            pnlExist = new Panel();
            dgvExistencias = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            existencias = new DataGridViewTextBoxColumn();
            coleccion = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            btnCerrarExist = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            barOpc.SuspendLayout();
            pnlExist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExistencias).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 90);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnPerifericos);
            panel3.Controls.Add(btnGaming);
            panel3.Controls.Add(btnAcerca);
            panel3.Controls.Add(btnHome);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(1200, 60);
            panel3.TabIndex = 1;
            // 
            // btnPerifericos
            // 
            btnPerifericos.BackColor = Color.White;
            btnPerifericos.FlatAppearance.BorderSize = 0;
            btnPerifericos.FlatStyle = FlatStyle.Flat;
            btnPerifericos.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPerifericos.Image = Properties.Resources.flecha;
            btnPerifericos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerifericos.Location = new Point(389, 5);
            btnPerifericos.Name = "btnPerifericos";
            btnPerifericos.Size = new Size(151, 45);
            btnPerifericos.TabIndex = 15;
            btnPerifericos.Text = "        Perifericos";
            btnPerifericos.TextAlign = ContentAlignment.MiddleLeft;
            btnPerifericos.UseVisualStyleBackColor = false;
            btnPerifericos.Click += btnPerifericos_Click;
            // 
            // btnGaming
            // 
            btnGaming.BackColor = Color.White;
            btnGaming.FlatAppearance.BorderSize = 0;
            btnGaming.FlatStyle = FlatStyle.Flat;
            btnGaming.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGaming.Image = Properties.Resources.flecha;
            btnGaming.ImageAlign = ContentAlignment.MiddleLeft;
            btnGaming.Location = new Point(593, 5);
            btnGaming.Name = "btnGaming";
            btnGaming.Size = new Size(151, 45);
            btnGaming.TabIndex = 14;
            btnGaming.Text = "        Gaming";
            btnGaming.TextAlign = ContentAlignment.MiddleLeft;
            btnGaming.UseVisualStyleBackColor = false;
            btnGaming.Click += btnGaming_Click;
            // 
            // btnAcerca
            // 
            btnAcerca.FlatAppearance.BorderSize = 0;
            btnAcerca.FlatStyle = FlatStyle.Flat;
            btnAcerca.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcerca.Image = Properties.Resources.informacion;
            btnAcerca.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcerca.Location = new Point(788, 7);
            btnAcerca.Name = "btnAcerca";
            btnAcerca.Size = new Size(151, 45);
            btnAcerca.TabIndex = 11;
            btnAcerca.Text = "        Acerca";
            btnAcerca.TextAlign = ContentAlignment.MiddleLeft;
            btnAcerca.UseVisualStyleBackColor = true;
            btnAcerca.Click += btnAcerca_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Image = Properties.Resources.hogar;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(187, 6);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(151, 45);
            btnHome.TabIndex = 2;
            btnHome.Text = "         Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnDesp);
            panel4.Controls.Add(labelAdmin);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(163, 60);
            panel4.TabIndex = 10;
            // 
            // btnDesp
            // 
            btnDesp.BackColor = Color.Transparent;
            btnDesp.Cursor = Cursors.Hand;
            btnDesp.FlatAppearance.BorderSize = 0;
            btnDesp.FlatStyle = FlatStyle.Flat;
            btnDesp.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesp.ForeColor = Color.FromArgb(93, 101, 123);
            btnDesp.Location = new Point(129, 19);
            btnDesp.Margin = new Padding(0);
            btnDesp.Name = "btnDesp";
            btnDesp.Size = new Size(25, 25);
            btnDesp.TabIndex = 5;
            btnDesp.Text = "⮛";
            btnDesp.UseVisualStyleBackColor = false;
            btnDesp.Click += btnDesp_Click;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdmin.ForeColor = Color.FromArgb(93, 101, 123);
            labelAdmin.Location = new Point(52, 19);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(62, 19);
            labelAdmin.TabIndex = 4;
            labelAdmin.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.iconoUs;
            pictureBox1.Location = new Point(9, 10);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(93, 101, 123);
            label4.Location = new Point(1005, 38);
            label4.Name = "label4";
            label4.Size = new Size(143, 16);
            label4.TabIndex = 9;
            label4.Text = "Conectate al futuro, hoy.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(93, 101, 123);
            label3.Location = new Point(1101, 16);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 8;
            label3.Text = "elec.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(997, 10);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 7;
            label2.Text = "NAVIGA";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.NavigaLogo2;
            pictureBox2.Location = new Point(1151, 10);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Controls.Add(labelHora);
            panel2.Controls.Add(labelFecha);
            panel2.Controls.Add(buttonMin);
            panel2.Controls.Add(buttonMax);
            panel2.Controls.Add(buttonClose);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 30);
            panel2.TabIndex = 0;
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Dock = DockStyle.Left;
            labelHora.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHora.ForeColor = Color.White;
            labelHora.Location = new Point(54, 0);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(43, 18);
            labelHora.TabIndex = 7;
            labelHora.Text = "Hora";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Dock = DockStyle.Left;
            labelFecha.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.ForeColor = Color.White;
            labelFecha.Location = new Point(0, 0);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(54, 18);
            labelFecha.TabIndex = 6;
            labelFecha.Text = "Fecha";
            // 
            // buttonMin
            // 
            buttonMin.BackColor = Color.Transparent;
            buttonMin.Dock = DockStyle.Right;
            buttonMin.FlatAppearance.BorderSize = 0;
            buttonMin.FlatStyle = FlatStyle.Flat;
            buttonMin.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMin.Location = new Point(1128, 0);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(24, 30);
            buttonMin.TabIndex = 5;
            buttonMin.Text = "-";
            buttonMin.UseVisualStyleBackColor = true;
            buttonMin.Click += buttonMin_Click;
            // 
            // buttonMax
            // 
            buttonMax.BackColor = Color.Transparent;
            buttonMax.Dock = DockStyle.Right;
            buttonMax.FlatAppearance.BorderSize = 0;
            buttonMax.FlatStyle = FlatStyle.Flat;
            buttonMax.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMax.Location = new Point(1152, 0);
            buttonMax.Name = "buttonMax";
            buttonMax.Size = new Size(24, 30);
            buttonMax.TabIndex = 4;
            buttonMax.Text = "O";
            buttonMax.UseVisualStyleBackColor = true;
            buttonMax.Click += buttonMax_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.Transparent;
            buttonClose.Dock = DockStyle.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(1176, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(24, 30);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.FlatAppearance.BorderSize = 0;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCerrar.Image = Properties.Resources.salida;
            buttonCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCerrar.Location = new Point(3, 156);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(160, 45);
            buttonCerrar.TabIndex = 12;
            buttonCerrar.Text = "        Cerrar Sesión";
            buttonCerrar.TextAlign = ContentAlignment.MiddleLeft;
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // barOpc
            // 
            barOpc.BackColor = Color.White;
            barOpc.Controls.Add(btnEditar);
            barOpc.Controls.Add(btnGrafica);
            barOpc.Controls.Add(btnExist);
            barOpc.Controls.Add(buttonCerrar);
            barOpc.Location = new Point(0, 96);
            barOpc.Name = "barOpc";
            barOpc.Size = new Size(163, 0);
            barOpc.TabIndex = 2;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(3, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(160, 45);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "         Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGrafica
            // 
            btnGrafica.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnGrafica.FlatAppearance.BorderSize = 0;
            btnGrafica.FlatStyle = FlatStyle.Flat;
            btnGrafica.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrafica.Image = Properties.Resources.grafica;
            btnGrafica.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrafica.Location = new Point(3, 54);
            btnGrafica.Name = "btnGrafica";
            btnGrafica.Size = new Size(160, 45);
            btnGrafica.TabIndex = 17;
            btnGrafica.Text = "         Grafica";
            btnGrafica.TextAlign = ContentAlignment.MiddleLeft;
            btnGrafica.UseVisualStyleBackColor = true;
            btnGrafica.Click += btnGrafica_Click;
            // 
            // btnExist
            // 
            btnExist.FlatAppearance.BorderSize = 0;
            btnExist.FlatStyle = FlatStyle.Flat;
            btnExist.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExist.Image = Properties.Resources.flecha;
            btnExist.ImageAlign = ContentAlignment.MiddleLeft;
            btnExist.Location = new Point(3, 105);
            btnExist.Name = "btnExist";
            btnExist.Size = new Size(160, 45);
            btnExist.TabIndex = 18;
            btnExist.Text = "        Existencias";
            btnExist.TextAlign = ContentAlignment.MiddleLeft;
            btnExist.UseVisualStyleBackColor = true;
            btnExist.Click += btnExist_Click;
            // 
            // timerOpc
            // 
            timerOpc.Enabled = true;
            timerOpc.Interval = 5;
            timerOpc.Tick += timerOpc_Tick;
            // 
            // HoraFecha
            // 
            HoraFecha.Enabled = true;
            HoraFecha.Tick += HoraFecha_Tick;
            // 
            // pnlExist
            // 
            pnlExist.AutoScroll = true;
            pnlExist.BackColor = Color.White;
            pnlExist.Controls.Add(dgvExistencias);
            pnlExist.Controls.Add(panel6);
            pnlExist.Location = new Point(330, 99);
            pnlExist.Name = "pnlExist";
            pnlExist.Size = new Size(619, 633);
            pnlExist.TabIndex = 4;
            pnlExist.Visible = false;
            // 
            // dgvExistencias
            // 
            dgvExistencias.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExistencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExistencias.Columns.AddRange(new DataGridViewColumn[] { IdProducto, descripcion, precio, existencias, coleccion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvExistencias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvExistencias.Location = new Point(15, 64);
            dgvExistencias.Name = "dgvExistencias";
            dgvExistencias.Size = new Size(594, 545);
            dgvExistencias.TabIndex = 1;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "ID del Producto";
            IdProducto.Name = "IdProducto";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // existencias
            // 
            existencias.HeaderText = "Existencias";
            existencias.Name = "existencias";
            // 
            // coleccion
            // 
            coleccion.HeaderText = "Coleccion";
            coleccion.Name = "coleccion";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Purple;
            panel6.Controls.Add(btnCerrarExist);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(619, 45);
            panel6.TabIndex = 0;
            // 
            // btnCerrarExist
            // 
            btnCerrarExist.BackColor = Color.Purple;
            btnCerrarExist.Dock = DockStyle.Right;
            btnCerrarExist.FlatStyle = FlatStyle.Flat;
            btnCerrarExist.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarExist.ForeColor = Color.White;
            btnCerrarExist.Location = new Point(583, 0);
            btnCerrarExist.Name = "btnCerrarExist";
            btnCerrarExist.Size = new Size(36, 45);
            btnCerrarExist.TabIndex = 1;
            btnCerrarExist.Text = "X";
            btnCerrarExist.UseVisualStyleBackColor = false;
            btnCerrarExist.Click += btnCerrarExist_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 5);
            label1.Name = "label1";
            label1.Size = new Size(438, 28);
            label1.TabIndex = 0;
            label1.Text = "Listado de productos por existencias";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 750);
            Controls.Add(pnlExist);
            Controls.Add(barOpc);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmin";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            barOpc.ResumeLayout(false);
            pnlExist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExistencias).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label labelAdmin;
        private Button btnDesp;
        private Button btnHome;
        private Button buttonCerrar;
        private Button btnAcerca;
        private FlowLayoutPanel barOpc;
        private Button btnGaming;
        private Button btnPerifericos;
        private Button btnEditar;
        private Button btnGrafica;
        private System.Windows.Forms.Timer timerOpc;
        private Button buttonClose;
        private Button buttonMax;
        private Button buttonMin;
        private Label labelHora;
        private Label labelFecha;
        private System.Windows.Forms.Timer HoraFecha;
        private Button btnExist;
        private Panel pnlExist;
        private Panel panel6;
        private Label label1;
        private Button btnCerrarExist;
        private DataGridView dgvExistencias;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn existencias;
        private DataGridViewTextBoxColumn coleccion;
    }
}