namespace projectM
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnMenu = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSidebar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            labelHora = new Label();
            labelFecha = new Label();
            btnMinimized = new Button();
            btnMaximized = new Button();
            btnClose = new Button();
            sidebar = new FlowLayoutPanel();
            btnHome = new Button();
            subMenuContainer = new FlowLayoutPanel();
            btnSubMenu = new Button();
            button4 = new Button();
            button5 = new Button();
            btnInfo = new Button();
            btnPagaroComp = new Button();
            btnSignOut = new Button();
            subMenuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            buttonCerrar = new Button();
            HoraFecha = new System.Windows.Forms.Timer(components);
            pnlProductos = new Panel();
            botonRedondo1 = new botonRedondo();
            pnlCarrito = new Panel();
            botonRedondo2 = new botonRedondo();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            sidebar.SuspendLayout();
            subMenuContainer.SuspendLayout();
            pnlCarrito.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
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
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnSidebar);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(1200, 60);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMenu);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(942, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(258, 60);
            panel4.TabIndex = 10;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.FromArgb(93, 101, 123);
            btnMenu.Location = new Point(230, 17);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(25, 25);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "⮛";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(75, 23);
            label1.Name = "label1";
            label1.Size = new Size(152, 19);
            label1.TabIndex = 3;
            label1.Text = "Mariel Villalpando";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.iconoUs;
            pictureBox1.Location = new Point(23, 10);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnSidebar
            // 
            btnSidebar.FlatAppearance.BorderSize = 0;
            btnSidebar.FlatStyle = FlatStyle.Flat;
            btnSidebar.Image = (Image)resources.GetObject("btnSidebar.Image");
            btnSidebar.Location = new Point(218, 15);
            btnSidebar.Name = "btnSidebar";
            btnSidebar.Size = new Size(30, 30);
            btnSidebar.TabIndex = 9;
            btnSidebar.UseVisualStyleBackColor = true;
            btnSidebar.Click += btnSidebar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(93, 101, 123);
            label4.Location = new Point(66, 36);
            label4.Name = "label4";
            label4.Size = new Size(143, 16);
            label4.TabIndex = 8;
            label4.Text = "Conectate al futuro, hoy.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(93, 101, 123);
            label3.Location = new Point(165, 17);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 7;
            label3.Text = "elec.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Magenta;
            label2.Location = new Point(63, 11);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 6;
            label2.Text = "NAVIGA";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.NavigaLogo1;
            pictureBox2.Location = new Point(20, 10);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Magenta;
            panel2.Controls.Add(labelHora);
            panel2.Controls.Add(labelFecha);
            panel2.Controls.Add(btnMinimized);
            panel2.Controls.Add(btnMaximized);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 30);
            panel2.TabIndex = 4;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Dock = DockStyle.Left;
            labelHora.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHora.ForeColor = Color.White;
            labelHora.ImageAlign = ContentAlignment.MiddleRight;
            labelHora.Location = new Point(54, 0);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(43, 18);
            labelHora.TabIndex = 8;
            labelHora.Text = "Hora";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Dock = DockStyle.Left;
            labelFecha.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.ForeColor = Color.White;
            labelFecha.ImageAlign = ContentAlignment.MiddleRight;
            labelFecha.Location = new Point(0, 0);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(54, 18);
            labelFecha.TabIndex = 7;
            labelFecha.Text = "Fecha";
            labelFecha.Click += labelFecha_Click;
            // 
            // btnMinimized
            // 
            btnMinimized.BackColor = Color.Magenta;
            btnMinimized.Dock = DockStyle.Right;
            btnMinimized.FlatAppearance.BorderSize = 0;
            btnMinimized.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimized.FlatStyle = FlatStyle.Flat;
            btnMinimized.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimized.ForeColor = Color.White;
            btnMinimized.Location = new Point(1125, 0);
            btnMinimized.Margin = new Padding(0);
            btnMinimized.Name = "btnMinimized";
            btnMinimized.Size = new Size(25, 30);
            btnMinimized.TabIndex = 2;
            btnMinimized.Text = "-";
            btnMinimized.UseVisualStyleBackColor = false;
            btnMinimized.Click += btnMinimized_Click;
            // 
            // btnMaximized
            // 
            btnMaximized.BackColor = Color.Magenta;
            btnMaximized.Dock = DockStyle.Right;
            btnMaximized.FlatAppearance.BorderSize = 0;
            btnMaximized.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMaximized.FlatStyle = FlatStyle.Flat;
            btnMaximized.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximized.ForeColor = Color.White;
            btnMaximized.Location = new Point(1150, 0);
            btnMaximized.Margin = new Padding(0);
            btnMaximized.Name = "btnMaximized";
            btnMaximized.Size = new Size(25, 30);
            btnMaximized.TabIndex = 1;
            btnMaximized.Text = "O";
            btnMaximized.UseVisualStyleBackColor = false;
            btnMaximized.Click += btnMaximized_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Magenta;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 97, 97);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 97, 97);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1175, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(btnHome);
            sidebar.Controls.Add(subMenuContainer);
            sidebar.Controls.Add(btnInfo);
            sidebar.Controls.Add(btnPagaroComp);
            sidebar.Controls.Add(btnSignOut);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 90);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(215, 660);
            sidebar.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.FromArgb(93, 101, 123);
            btnHome.Image = Properties.Resources.hogar;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(18, 0, 0, 0);
            btnHome.Size = new Size(210, 44);
            btnHome.TabIndex = 3;
            btnHome.Text = "          Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // subMenuContainer
            // 
            subMenuContainer.BackColor = Color.White;
            subMenuContainer.Controls.Add(btnSubMenu);
            subMenuContainer.Controls.Add(button4);
            subMenuContainer.Controls.Add(button5);
            subMenuContainer.Location = new Point(3, 53);
            subMenuContainer.Name = "subMenuContainer";
            subMenuContainer.Size = new Size(210, 44);
            subMenuContainer.TabIndex = 3;
            // 
            // btnSubMenu
            // 
            btnSubMenu.BackColor = Color.White;
            btnSubMenu.FlatAppearance.BorderSize = 0;
            btnSubMenu.FlatStyle = FlatStyle.Flat;
            btnSubMenu.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubMenu.ForeColor = Color.FromArgb(93, 101, 123);
            btnSubMenu.Image = Properties.Resources.coleccIcon1;
            btnSubMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubMenu.Location = new Point(0, 0);
            btnSubMenu.Margin = new Padding(0);
            btnSubMenu.Name = "btnSubMenu";
            btnSubMenu.Padding = new Padding(18, 0, 0, 0);
            btnSubMenu.Size = new Size(210, 44);
            btnSubMenu.TabIndex = 4;
            btnSubMenu.Text = "          Colecciones";
            btnSubMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnSubMenu.UseVisualStyleBackColor = false;
            btnSubMenu.Click += btnSubMenu_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(247, 247, 247);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(93, 101, 123);
            button4.Image = Properties.Resources.flecha;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 44);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Padding = new Padding(18, 0, 0, 0);
            button4.Size = new Size(215, 44);
            button4.TabIndex = 5;
            button4.Text = "          Gaming";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(247, 247, 247);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(93, 101, 123);
            button5.Image = Properties.Resources.flecha;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 88);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Padding = new Padding(18, 0, 0, 0);
            button5.Size = new Size(215, 44);
            button5.TabIndex = 6;
            button5.Text = "          Perifericos";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfo.ForeColor = Color.FromArgb(93, 101, 123);
            btnInfo.Image = Properties.Resources.informacion;
            btnInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfo.Location = new Point(3, 103);
            btnInfo.Name = "btnInfo";
            btnInfo.Padding = new Padding(18, 0, 0, 0);
            btnInfo.Size = new Size(210, 44);
            btnInfo.TabIndex = 5;
            btnInfo.Text = "          Acerca de";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnPagaroComp
            // 
            btnPagaroComp.FlatAppearance.BorderSize = 0;
            btnPagaroComp.FlatStyle = FlatStyle.Flat;
            btnPagaroComp.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagaroComp.ForeColor = Color.FromArgb(93, 101, 123);
            btnPagaroComp.Image = Properties.Resources.comp;
            btnPagaroComp.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagaroComp.Location = new Point(3, 153);
            btnPagaroComp.Name = "btnPagaroComp";
            btnPagaroComp.Padding = new Padding(18, 0, 0, 0);
            btnPagaroComp.Size = new Size(210, 44);
            btnPagaroComp.TabIndex = 6;
            btnPagaroComp.Text = "          Ver carrito";
            btnPagaroComp.TextAlign = ContentAlignment.MiddleLeft;
            btnPagaroComp.UseVisualStyleBackColor = true;
            btnPagaroComp.Click += btnPagaroComp_Click;
            // 
            // btnSignOut
            // 
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignOut.ForeColor = Color.FromArgb(93, 101, 123);
            btnSignOut.Image = Properties.Resources.salida;
            btnSignOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignOut.Location = new Point(3, 203);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Padding = new Padding(18, 0, 0, 0);
            btnSignOut.Size = new Size(210, 44);
            btnSignOut.TabIndex = 4;
            btnSignOut.Text = "          Cerrar Sesion";
            btnSignOut.TextAlign = ContentAlignment.MiddleLeft;
            btnSignOut.UseVisualStyleBackColor = true;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // subMenuTransition
            // 
            subMenuTransition.Enabled = true;
            subMenuTransition.Interval = 5;
            subMenuTransition.Tick += subMenuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Enabled = true;
            sidebarTransition.Interval = 5;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCerrar.Location = new Point(1052, 90);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(148, 42);
            buttonCerrar.TabIndex = 5;
            buttonCerrar.Text = "Cerrar Sesión";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Visible = false;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // HoraFecha
            // 
            HoraFecha.Enabled = true;
            HoraFecha.Tick += HoraFecha_Tick;
            // 
            // pnlProductos
            // 
            pnlProductos.AutoScroll = true;
            pnlProductos.BackColor = Color.White;
            pnlProductos.Location = new Point(26, 23);
            pnlProductos.Name = "pnlProductos";
            pnlProductos.Size = new Size(540, 400);
            pnlProductos.TabIndex = 2;
            // 
            // botonRedondo1
            // 
            botonRedondo1.BackColor = Color.BlueViolet;
            botonRedondo1.BackgroundColor = Color.BlueViolet;
            botonRedondo1.BorderColor = Color.PaleVioletRed;
            botonRedondo1.BorderRadius = 20;
            botonRedondo1.BorderSize = 0;
            botonRedondo1.FlatAppearance.BorderSize = 0;
            botonRedondo1.FlatStyle = FlatStyle.Flat;
            botonRedondo1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondo1.ForeColor = Color.White;
            botonRedondo1.Location = new Point(648, 271);
            botonRedondo1.Name = "botonRedondo1";
            botonRedondo1.Size = new Size(194, 52);
            botonRedondo1.TabIndex = 3;
            botonRedondo1.Text = "Continar Compra";
            botonRedondo1.TextColor = Color.White;
            botonRedondo1.UseVisualStyleBackColor = false;
            botonRedondo1.Click += botonRedondo1_Click;
            // 
            // pnlCarrito
            // 
            pnlCarrito.AutoScroll = true;
            pnlCarrito.BackColor = Color.WhiteSmoke;
            pnlCarrito.BorderStyle = BorderStyle.FixedSingle;
            pnlCarrito.Controls.Add(botonRedondo2);
            pnlCarrito.Controls.Add(botonRedondo1);
            pnlCarrito.Controls.Add(pnlProductos);
            pnlCarrito.Location = new Point(237, 96);
            pnlCarrito.Name = "pnlCarrito";
            pnlCarrito.Size = new Size(904, 615);
            pnlCarrito.TabIndex = 7;
            pnlCarrito.Visible = false;
            // 
            // botonRedondo2
            // 
            botonRedondo2.BackColor = Color.White;
            botonRedondo2.BackgroundColor = Color.White;
            botonRedondo2.BorderColor = Color.PaleVioletRed;
            botonRedondo2.BorderRadius = 20;
            botonRedondo2.BorderSize = 0;
            botonRedondo2.FlatAppearance.BorderSize = 0;
            botonRedondo2.FlatStyle = FlatStyle.Flat;
            botonRedondo2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondo2.ForeColor = Color.BlueViolet;
            botonRedondo2.Location = new Point(648, 341);
            botonRedondo2.Name = "botonRedondo2";
            botonRedondo2.Size = new Size(194, 52);
            botonRedondo2.TabIndex = 4;
            botonRedondo2.Text = "Borrar el carrito";
            botonRedondo2.TextColor = Color.BlueViolet;
            botonRedondo2.UseVisualStyleBackColor = false;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1200, 750);
            Controls.Add(pnlCarrito);
            Controls.Add(buttonCerrar);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "FormUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            sidebar.ResumeLayout(false);
            subMenuContainer.ResumeLayout(false);
            pnlCarrito.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Button btnMinimized;
        private Button btnMaximized;
        private Button btnClose;
        private Panel panel3;
        private Button btnSidebar;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btnMenu;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnHome;
        private FlowLayoutPanel subMenuContainer;
        private Button btnSubMenu;
        private Button button4;
        private Button button5;
        private System.Windows.Forms.Timer subMenuTransition;
        private Button btnSignOut;
        private Button btnInfo;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel4;
        private Button buttonCerrar;
        private Button btnPagaroComp;
        private Label labelFecha;
        private Label labelHora;
        private System.Windows.Forms.Timer HoraFecha;
        private Panel pnlProductos;
        private botonRedondo botonRedondo1;
        private Panel pnlCarrito;
        private botonRedondo botonRedondo2;
    }
}
