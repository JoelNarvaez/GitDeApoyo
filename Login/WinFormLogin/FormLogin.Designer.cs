namespace WinFormLogin
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pPrincipal = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            btnOpcion = new Button();
            panelOpc = new Panel();
            btnInv = new Button();
            btnAdmin = new Button();
            btnUsu = new Button();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pContenedor = new Panel();
            btnEntrar = new Button();
            pContra = new Panel();
            txtContra = new TextBox();
            pUsu = new Panel();
            txtUsu = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelOpc.SuspendLayout();
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pPrincipal
            // 
            pPrincipal.BackColor = Color.White;
            pPrincipal.Controls.Add(panel2);
            pPrincipal.Controls.Add(panel1);
            pPrincipal.Controls.Add(label8);
            pPrincipal.Controls.Add(label7);
            pPrincipal.Controls.Add(pictureBox3);
            pPrincipal.Controls.Add(label6);
            pPrincipal.Controls.Add(pictureBox2);
            pPrincipal.Controls.Add(btnOpcion);
            pPrincipal.Controls.Add(panelOpc);
            pPrincipal.Controls.Add(label2);
            pPrincipal.Controls.Add(label1);
            pPrincipal.Location = new Point(0, -1);
            pPrincipal.Name = "pPrincipal";
            pPrincipal.Size = new Size(1184, 716);
            pPrincipal.TabIndex = 0;
            pPrincipal.Paint += pPrincipal_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Location = new Point(952, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 3);
            panel2.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(809, 609);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 3);
            panel1.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(952, 288);
            label8.Name = "label8";
            label8.Size = new Size(117, 14);
            label8.TabIndex = 10;
            label8.Text = "Registrate ahora";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(796, 288);
            label7.Name = "label7";
            label7.Size = new Size(150, 14);
            label7.TabIndex = 9;
            label7.Text = "No tienes una cuenta?";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.fondo;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(644, 960);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(809, 592);
            label6.Name = "label6";
            label6.Size = new Size(233, 14);
            label6.TabIndex = 7;
            label6.Text = "Olvidaste tu usuario o contraseña?";
            label6.Click += label6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(858, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(149, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnOpcion
            // 
            btnOpcion.FlatAppearance.BorderSize = 0;
            btnOpcion.FlatStyle = FlatStyle.Flat;
            btnOpcion.Font = new Font("Georgia", 10F, FontStyle.Bold);
            btnOpcion.ForeColor = Color.Black;
            btnOpcion.Location = new Point(841, 400);
            btnOpcion.Name = "btnOpcion";
            btnOpcion.Padding = new Padding(10, 0, 0, 0);
            btnOpcion.Size = new Size(184, 25);
            btnOpcion.TabIndex = 4;
            btnOpcion.Text = "Seleccionar             >";
            btnOpcion.TextAlign = ContentAlignment.MiddleLeft;
            btnOpcion.UseVisualStyleBackColor = true;
            btnOpcion.Click += btnOpcion_Click;
            // 
            // panelOpc
            // 
            panelOpc.BackColor = Color.White;
            panelOpc.Controls.Add(btnInv);
            panelOpc.Controls.Add(btnAdmin);
            panelOpc.Controls.Add(btnUsu);
            panelOpc.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelOpc.Location = new Point(858, 431);
            panelOpc.Name = "panelOpc";
            panelOpc.Size = new Size(149, 96);
            panelOpc.TabIndex = 3;
            // 
            // btnInv
            // 
            btnInv.BackColor = Color.Transparent;
            btnInv.Dock = DockStyle.Top;
            btnInv.FlatAppearance.BorderSize = 0;
            btnInv.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnInv.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnInv.FlatStyle = FlatStyle.Flat;
            btnInv.Font = new Font("Georgia", 8F);
            btnInv.ForeColor = Color.Black;
            btnInv.Location = new Point(0, 60);
            btnInv.Name = "btnInv";
            btnInv.Padding = new Padding(30, 0, 0, 0);
            btnInv.Size = new Size(149, 30);
            btnInv.TabIndex = 2;
            btnInv.Text = "Invitado";
            btnInv.TextAlign = ContentAlignment.MiddleLeft;
            btnInv.UseVisualStyleBackColor = false;
            btnInv.Click += btnInv_Click_1;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Georgia", 8F);
            btnAdmin.ForeColor = Color.Black;
            btnAdmin.Location = new Point(0, 30);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Padding = new Padding(30, 0, 0, 0);
            btnAdmin.Size = new Size(149, 30);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Administrador";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnUsu
            // 
            btnUsu.BackColor = Color.Transparent;
            btnUsu.Dock = DockStyle.Top;
            btnUsu.FlatAppearance.BorderSize = 0;
            btnUsu.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnUsu.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnUsu.FlatStyle = FlatStyle.Flat;
            btnUsu.Font = new Font("Georgia", 8F);
            btnUsu.ForeColor = Color.Black;
            btnUsu.Location = new Point(0, 0);
            btnUsu.Name = "btnUsu";
            btnUsu.Padding = new Padding(30, 0, 0, 0);
            btnUsu.Size = new Size(149, 30);
            btnUsu.TabIndex = 1;
            btnUsu.Text = "Usuario";
            btnUsu.TextAlign = ContentAlignment.MiddleLeft;
            btnUsu.UseVisualStyleBackColor = false;
            btnUsu.Click += btnUsu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 16.5F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(809, 352);
            label2.Name = "label2";
            label2.Size = new Size(243, 27);
            label2.TabIndex = 1;
            label2.Text = "Iniciar sesion como:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(469, 58);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.White;
            pContenedor.Controls.Add(btnEntrar);
            pContenedor.Controls.Add(pContra);
            pContenedor.Controls.Add(txtContra);
            pContenedor.Controls.Add(pUsu);
            pContenedor.Controls.Add(txtUsu);
            pContenedor.Controls.Add(label5);
            pContenedor.Controls.Add(label4);
            pContenedor.Controls.Add(label3);
            pContenedor.Controls.Add(pictureBox1);
            pContenedor.Location = new Point(0, -1);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(644, 713);
            pContenedor.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.MidnightBlue;
            btnEntrar.FlatAppearance.BorderColor = Color.White;
            btnEntrar.FlatAppearance.MouseDownBackColor = SystemColors.ScrollBar;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnEntrar.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(241, 583);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(150, 40);
            btnEntrar.TabIndex = 19;
            btnEntrar.Text = "Acceder";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // pContra
            // 
            pContra.BackColor = Color.Silver;
            pContra.Location = new Point(152, 521);
            pContra.Name = "pContra";
            pContra.Size = new Size(340, 3);
            pContra.TabIndex = 18;
            // 
            // txtContra
            // 
            txtContra.BorderStyle = BorderStyle.None;
            txtContra.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContra.Location = new Point(152, 490);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(340, 26);
            txtContra.TabIndex = 17;
            txtContra.Tag = "Contra";
            // 
            // pUsu
            // 
            pUsu.BackColor = Color.Silver;
            pUsu.Location = new Point(152, 411);
            pUsu.Name = "pUsu";
            pUsu.Size = new Size(340, 3);
            pUsu.TabIndex = 16;
            // 
            // txtUsu
            // 
            txtUsu.BorderStyle = BorderStyle.None;
            txtUsu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsu.Location = new Point(152, 380);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new Size(340, 26);
            txtUsu.TabIndex = 15;
            txtUsu.Tag = "Usu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold);
            label5.Location = new Point(152, 442);
            label5.Name = "label5";
            label5.Size = new Size(103, 18);
            label5.TabIndex = 14;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold);
            label4.Location = new Point(152, 341);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 13;
            label4.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(241, 239);
            label3.Name = "label3";
            label3.Size = new Size(184, 29);
            label3.TabIndex = 12;
            label3.Text = "Iniciar Sesion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(256, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 711);
            Controls.Add(pPrincipal);
            Controls.Add(pContenedor);
            Name = "FormLogin";
            Text = "Form1";
            Load += Form1_Load;
            pPrincipal.ResumeLayout(false);
            pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelOpc.ResumeLayout(false);
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pPrincipal;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel pContenedor;
        private Button btnEntrar;
        private Panel pContra;
        private TextBox txtContra;
        private Panel pUsu;
        private TextBox txtUsu;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnOpcion;
        private Panel panelOpc;
        private Button btnUsu;
        private Button btnAdmin;
        private Button btnInv;
        private PictureBox pictureBox2;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label8;
        private Panel panel2;
        private Panel panel1;
    }
}
