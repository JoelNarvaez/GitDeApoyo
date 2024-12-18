namespace projectM
{
    partial class FormPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPago));
            panel2 = new Panel();
            panel1 = new Panel();
            labelHora = new Label();
            labelFecha = new Label();
            btnMinimized = new Button();
            btnMaximized = new Button();
            btnClose = new Button();
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
            panelRedondo1 = new PanelRedondo();
            rbtnTarjeta = new RadioButton();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panelRedondo2 = new PanelRedondo();
            label7 = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            rbtnOxxo = new RadioButton();
            label5 = new Label();
            btnContinuar = new botonRedondo();
            buttonCerrar = new Button();
            botonRedondo1 = new botonRedondo();
            panelOxxo = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelRedondo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelRedondo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Magenta;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(labelHora);
            panel2.Controls.Add(labelFecha);
            panel2.Controls.Add(btnMinimized);
            panel2.Controls.Add(btnMaximized);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 30);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(282, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 145);
            panel1.TabIndex = 14;
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
            panel3.TabIndex = 6;
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
            // panelRedondo1
            // 
            panelRedondo1.BackColor = Color.White;
            panelRedondo1.BackgroundColor = Color.White;
            panelRedondo1.BorderColor = Color.DarkGray;
            panelRedondo1.BorderRadius = 20;
            panelRedondo1.BorderSize = 3;
            panelRedondo1.Controls.Add(rbtnTarjeta);
            panelRedondo1.Controls.Add(pictureBox3);
            panelRedondo1.Controls.Add(label6);
            panelRedondo1.Location = new Point(108, 243);
            panelRedondo1.Name = "panelRedondo1";
            panelRedondo1.Size = new Size(515, 65);
            panelRedondo1.TabIndex = 7;
            // 
            // rbtnTarjeta
            // 
            rbtnTarjeta.AutoSize = true;
            rbtnTarjeta.Location = new Point(21, 26);
            rbtnTarjeta.Name = "rbtnTarjeta";
            rbtnTarjeta.Size = new Size(14, 13);
            rbtnTarjeta.TabIndex = 12;
            rbtnTarjeta.TabStop = true;
            rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.tarjeta;
            pictureBox3.Location = new Point(41, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12.75F);
            label6.Location = new Point(82, 26);
            label6.Name = "label6";
            label6.Size = new Size(161, 21);
            label6.TabIndex = 10;
            label6.Text = "Tarjeta de crédito";
            // 
            // panelRedondo2
            // 
            panelRedondo2.BackColor = Color.White;
            panelRedondo2.BackgroundColor = Color.White;
            panelRedondo2.BorderColor = Color.DarkGray;
            panelRedondo2.BorderRadius = 20;
            panelRedondo2.BorderSize = 3;
            panelRedondo2.Controls.Add(label7);
            panelRedondo2.Controls.Add(label8);
            panelRedondo2.Controls.Add(pictureBox4);
            panelRedondo2.Controls.Add(rbtnOxxo);
            panelRedondo2.Location = new Point(108, 329);
            panelRedondo2.Name = "panelRedondo2";
            panelRedondo2.Size = new Size(515, 65);
            panelRedondo2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12.75F);
            label7.Location = new Point(82, 17);
            label7.Name = "label7";
            label7.Size = new Size(137, 21);
            label7.TabIndex = 11;
            label7.Text = "Punto de pago";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.WindowFrame;
            label8.Location = new Point(82, 38);
            label8.Name = "label8";
            label8.Size = new Size(40, 17);
            label8.TabIndex = 12;
            label8.Text = "Oxxo";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.billete;
            pictureBox4.Location = new Point(41, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // rbtnOxxo
            // 
            rbtnOxxo.AutoSize = true;
            rbtnOxxo.Location = new Point(21, 25);
            rbtnOxxo.Name = "rbtnOxxo";
            rbtnOxxo.Size = new Size(14, 13);
            rbtnOxxo.TabIndex = 13;
            rbtnOxxo.TabStop = true;
            rbtnOxxo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(108, 189);
            label5.Name = "label5";
            label5.Size = new Size(235, 28);
            label5.TabIndex = 9;
            label5.Text = "Elige cómo pagar: ";
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.MediumSlateBlue;
            btnContinuar.BackgroundColor = Color.MediumSlateBlue;
            btnContinuar.BorderColor = Color.PaleVioletRed;
            btnContinuar.BorderRadius = 20;
            btnContinuar.BorderSize = 0;
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinuar.ForeColor = Color.White;
            btnContinuar.Location = new Point(282, 471);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(150, 40);
            btnContinuar.TabIndex = 10;
            btnContinuar.Text = "Continuar";
            btnContinuar.TextColor = Color.White;
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCerrar.Location = new Point(1052, 86);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(148, 42);
            buttonCerrar.TabIndex = 11;
            buttonCerrar.Text = "Cerrar Sesión";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Visible = false;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // botonRedondo1
            // 
            botonRedondo1.BackColor = Color.MediumSlateBlue;
            botonRedondo1.BackgroundColor = Color.MediumSlateBlue;
            botonRedondo1.BorderColor = Color.PaleVioletRed;
            botonRedondo1.BorderRadius = 20;
            botonRedondo1.BorderSize = 0;
            botonRedondo1.FlatAppearance.BorderSize = 0;
            botonRedondo1.FlatStyle = FlatStyle.Flat;
            botonRedondo1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondo1.ForeColor = Color.White;
            botonRedondo1.Location = new Point(271, 533);
            botonRedondo1.Name = "botonRedondo1";
            botonRedondo1.Size = new Size(174, 40);
            botonRedondo1.TabIndex = 12;
            botonRedondo1.Text = "Regresar y guardar";
            botonRedondo1.TextColor = Color.White;
            botonRedondo1.UseVisualStyleBackColor = false;
            botonRedondo1.Click += botonRedondo1_Click_1;
            // 
            // panelOxxo
            // 
            panelOxxo.BackColor = Color.White;
            panelOxxo.Location = new Point(66, 155);
            panelOxxo.Name = "panelOxxo";
            panelOxxo.Size = new Size(607, 435);
            panelOxxo.TabIndex = 13;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // FormPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1200, 750);
            Controls.Add(panelOxxo);
            Controls.Add(panelRedondo1);
            Controls.Add(botonRedondo1);
            Controls.Add(buttonCerrar);
            Controls.Add(btnContinuar);
            Controls.Add(label5);
            Controls.Add(panelRedondo2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPago";
            Text = "FormPago";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelRedondo1.ResumeLayout(false);
            panelRedondo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelRedondo2.ResumeLayout(false);
            panelRedondo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label labelHora;
        private Label labelFecha;
        private Button btnMinimized;
        private Button btnMaximized;
        private Button btnClose;
        private Panel panel3;
        private Panel panel4;
        private Button btnMenu;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSidebar;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private PanelRedondo panelRedondo1;
        private PanelRedondo panelRedondo2;
        private Label label5;
        private Label label6;
        private Label label7;
        private RadioButton rbtnTarjeta;
        private RadioButton rbtnOxxo;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label8;
        private botonRedondo btnContinuar;
        private Button buttonCerrar;
        private botonRedondo botonRedondo1;
        private Panel panelOxxo;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}