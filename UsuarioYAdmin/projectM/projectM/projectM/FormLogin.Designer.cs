
namespace projectM
{ 
    public partial class FormLogin
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
            panel3 = new Panel();
            labelHora = new Label();
            labelFecha = new Label();
            btnMinimized = new Button();
            btnMaximized = new Button();
            btnClose = new Button();
            label12 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label10 = new Label();
            botonRedondo2 = new botonRedondo();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pContenedor = new Panel();
            button1 = new Button();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            panelRedondo1 = new PanelRedondo();
            validoOno = new Label();
            pictureBox1 = new PictureBox();
            panelRedondo3 = new PanelRedondo();
            pictureBox4 = new PictureBox();
            txtContrasena = new TextBox();
            panelRedondo2 = new PanelRedondo();
            txtUsuario = new TextBox();
            btnEntrar = new botonRedondo();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            buttonMinCont = new Button();
            buttonMaxCont = new Button();
            buttonCloseCont = new Button();
            horaFecha = new System.Windows.Forms.Timer(components);
            pPrincipal.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panelRedondo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRedondo3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelRedondo2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pPrincipal
            // 
            pPrincipal.BackColor = Color.White;
            pPrincipal.Controls.Add(panel3);
            pPrincipal.Controls.Add(label12);
            pPrincipal.Controls.Add(label8);
            pPrincipal.Controls.Add(label7);
            pPrincipal.Controls.Add(label6);
            pPrincipal.Controls.Add(label10);
            pPrincipal.Controls.Add(botonRedondo2);
            pPrincipal.Controls.Add(pictureBox2);
            pPrincipal.Controls.Add(label2);
            pPrincipal.Controls.Add(pictureBox3);
            pPrincipal.Controls.Add(label1);
            pPrincipal.Location = new Point(0, -1);
            pPrincipal.Name = "pPrincipal";
            pPrincipal.Size = new Size(1184, 716);
            pPrincipal.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(labelHora);
            panel3.Controls.Add(labelFecha);
            panel3.Controls.Add(btnMinimized);
            panel3.Controls.Add(btnMaximized);
            panel3.Controls.Add(btnClose);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1184, 24);
            panel3.TabIndex = 72;
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Dock = DockStyle.Left;
            labelHora.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHora.ForeColor = Color.Brown;
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
            labelFecha.ForeColor = Color.Brown;
            labelFecha.ImageAlign = ContentAlignment.MiddleRight;
            labelFecha.Location = new Point(0, 0);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(54, 18);
            labelFecha.TabIndex = 7;
            labelFecha.Text = "Fecha";
            // 
            // btnMinimized
            // 
            btnMinimized.BackColor = Color.DarkCyan;
            btnMinimized.Dock = DockStyle.Right;
            btnMinimized.FlatAppearance.BorderSize = 0;
            btnMinimized.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimized.FlatStyle = FlatStyle.Flat;
            btnMinimized.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimized.ForeColor = Color.White;
            btnMinimized.Location = new Point(1109, 0);
            btnMinimized.Margin = new Padding(0);
            btnMinimized.Name = "btnMinimized";
            btnMinimized.Size = new Size(25, 24);
            btnMinimized.TabIndex = 2;
            btnMinimized.Text = "-";
            btnMinimized.UseVisualStyleBackColor = false;
            btnMinimized.Click += btnMinimized_Click;
            // 
            // btnMaximized
            // 
            btnMaximized.BackColor = Color.DarkCyan;
            btnMaximized.Dock = DockStyle.Right;
            btnMaximized.FlatAppearance.BorderSize = 0;
            btnMaximized.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMaximized.FlatStyle = FlatStyle.Flat;
            btnMaximized.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximized.ForeColor = Color.White;
            btnMaximized.Location = new Point(1134, 0);
            btnMaximized.Margin = new Padding(0);
            btnMaximized.Name = "btnMaximized";
            btnMaximized.Size = new Size(25, 24);
            btnMaximized.TabIndex = 1;
            btnMaximized.Text = "O";
            btnMaximized.UseVisualStyleBackColor = false;
            btnMaximized.Click += btnMaximized_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkCyan;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 97, 97);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 97, 97);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1159, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 24);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DeepPink;
            label12.Location = new Point(994, 281);
            label12.Name = "label12";
            label12.Size = new Size(57, 25);
            label12.TabIndex = 71;
            label12.Text = "HOY";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.BlueViolet;
            label8.Location = new Point(947, 565);
            label8.Name = "label8";
            label8.Size = new Size(130, 36);
            label8.TabIndex = 68;
            label8.Text = "NAVIGA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MediumBlue;
            label7.Location = new Point(731, 536);
            label7.Name = "label7";
            label7.Size = new Size(194, 25);
            label7.TabIndex = 67;
            label7.Text = "Y ve mas allá con";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(740, 353);
            label6.Name = "label6";
            label6.Size = new Size(337, 25);
            label6.TabIndex = 66;
            label6.Text = "Sientete parte de nuestra tienda";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(708, 318);
            label10.Name = "label10";
            label10.Size = new Size(397, 25);
            label10.TabIndex = 65;
            label10.Text = "Los mejores productos al mejor precio";
            // 
            // botonRedondo2
            // 
            botonRedondo2.BackColor = Color.IndianRed;
            botonRedondo2.BackgroundColor = Color.IndianRed;
            botonRedondo2.BorderColor = Color.PaleVioletRed;
            botonRedondo2.BorderRadius = 20;
            botonRedondo2.BorderSize = 0;
            botonRedondo2.FlatAppearance.BorderSize = 0;
            botonRedondo2.FlatStyle = FlatStyle.Flat;
            botonRedondo2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondo2.ForeColor = Color.White;
            botonRedondo2.Location = new Point(801, 436);
            botonRedondo2.Name = "botonRedondo2";
            botonRedondo2.Size = new Size(219, 58);
            botonRedondo2.TabIndex = 64;
            botonRedondo2.Text = "Comprar YA";
            botonRedondo2.TextColor = Color.White;
            botonRedondo2.UseVisualStyleBackColor = false;
            botonRedondo2.Click += botonRedondo2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.NavigaLogoLog;
            pictureBox2.Location = new Point(801, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 166);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 63;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(774, 281);
            label2.Name = "label2";
            label2.Size = new Size(214, 25);
            label2.TabIndex = 62;
            label2.Text = "Conectate al futuro,";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LadoIzq1;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(620, 724);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DeepPink;
            label9.Location = new Point(103, 48);
            label9.Name = "label9";
            label9.Size = new Size(57, 25);
            label9.TabIndex = 69;
            label9.Text = "HOY";
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.White;
            pContenedor.Controls.Add(button1);
            pContenedor.Controls.Add(label9);
            pContenedor.Controls.Add(label11);
            pContenedor.Controls.Add(pictureBox5);
            pContenedor.Controls.Add(panelRedondo1);
            pContenedor.Controls.Add(panel5);
            pContenedor.Location = new Point(0, -1);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(644, 713);
            pContenedor.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(103, 23);
            label11.Name = "label11";
            label11.Size = new Size(214, 25);
            label11.TabIndex = 70;
            label11.Text = "Conectate al futuro,";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.NavigaLogoLog;
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(94, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 70;
            pictureBox5.TabStop = false;
            // 
            // panelRedondo1
            // 
            panelRedondo1.BackColor = Color.White;
            panelRedondo1.BackgroundColor = Color.White;
            panelRedondo1.BorderColor = Color.BlueViolet;
            panelRedondo1.BorderRadius = 30;
            panelRedondo1.BorderSize = 2;
            panelRedondo1.Controls.Add(validoOno);
            panelRedondo1.Controls.Add(pictureBox1);
            panelRedondo1.Controls.Add(panelRedondo3);
            panelRedondo1.Controls.Add(panelRedondo2);
            panelRedondo1.Controls.Add(btnEntrar);
            panelRedondo1.Controls.Add(label5);
            panelRedondo1.Controls.Add(label4);
            panelRedondo1.Controls.Add(label3);
            panelRedondo1.Location = new Point(88, 92);
            panelRedondo1.Name = "panelRedondo1";
            panelRedondo1.Size = new Size(444, 555);
            panelRedondo1.TabIndex = 61;
            panelRedondo1.Paint += panelRedondo1_Paint;
            // 
            // validoOno
            // 
            validoOno.Font = new Font("Berlin Sans FB", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validoOno.ForeColor = Color.Red;
            validoOno.Location = new Point(57, 410);
            validoOno.Name = "validoOno";
            validoOno.Size = new Size(304, 21);
            validoOno.TabIndex = 77;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.log_in;
            pictureBox1.Location = new Point(148, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // panelRedondo3
            // 
            panelRedondo3.BackColor = Color.White;
            panelRedondo3.BackgroundColor = Color.White;
            panelRedondo3.BorderColor = Color.Silver;
            panelRedondo3.BorderRadius = 15;
            panelRedondo3.BorderSize = 2;
            panelRedondo3.Controls.Add(pictureBox4);
            panelRedondo3.Controls.Add(txtContrasena);
            panelRedondo3.Location = new Point(58, 348);
            panelRedondo3.Name = "panelRedondo3";
            panelRedondo3.Size = new Size(315, 49);
            panelRedondo3.TabIndex = 73;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.contraOjo;
            pictureBox4.Location = new Point(255, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 77;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(18, 15);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "Ingresa tu contraseña";
            txtContrasena.Size = new Size(255, 24);
            txtContrasena.TabIndex = 1;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // panelRedondo2
            // 
            panelRedondo2.BackColor = Color.White;
            panelRedondo2.BackgroundColor = Color.White;
            panelRedondo2.BorderColor = Color.Silver;
            panelRedondo2.BorderRadius = 15;
            panelRedondo2.BorderSize = 2;
            panelRedondo2.Controls.Add(txtUsuario);
            panelRedondo2.Location = new Point(56, 235);
            panelRedondo2.Name = "panelRedondo2";
            panelRedondo2.Size = new Size(315, 49);
            panelRedondo2.TabIndex = 72;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(20, 12);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingresa tu usuario";
            txtUsuario.Size = new Size(255, 24);
            txtUsuario.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.BlueViolet;
            btnEntrar.BackgroundColor = Color.BlueViolet;
            btnEntrar.BorderColor = Color.PaleVioletRed;
            btnEntrar.BorderRadius = 20;
            btnEntrar.BorderSize = 0;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(120, 444);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(179, 45);
            btnEntrar.TabIndex = 71;
            btnEntrar.Text = "Iniciar Sesión";
            btnEntrar.TextColor = Color.White;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 315);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 68;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 202);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 67;
            label4.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(172, 42);
            label3.Name = "label3";
            label3.Size = new Size(92, 33);
            label3.TabIndex = 66;
            label3.Text = "Log in";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(buttonMinCont);
            panel5.Controls.Add(buttonMaxCont);
            panel5.Controls.Add(buttonCloseCont);
            panel5.Location = new Point(553, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(78, 24);
            panel5.TabIndex = 60;
            // 
            // buttonMinCont
            // 
            buttonMinCont.BackColor = Color.DarkCyan;
            buttonMinCont.Dock = DockStyle.Right;
            buttonMinCont.FlatAppearance.BorderSize = 0;
            buttonMinCont.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMinCont.FlatStyle = FlatStyle.Flat;
            buttonMinCont.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMinCont.ForeColor = Color.White;
            buttonMinCont.Location = new Point(3, 0);
            buttonMinCont.Margin = new Padding(0);
            buttonMinCont.Name = "buttonMinCont";
            buttonMinCont.Size = new Size(25, 24);
            buttonMinCont.TabIndex = 2;
            buttonMinCont.Text = "-";
            buttonMinCont.UseVisualStyleBackColor = false;
            // 
            // buttonMaxCont
            // 
            buttonMaxCont.BackColor = Color.DarkCyan;
            buttonMaxCont.Dock = DockStyle.Right;
            buttonMaxCont.FlatAppearance.BorderSize = 0;
            buttonMaxCont.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMaxCont.FlatStyle = FlatStyle.Flat;
            buttonMaxCont.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMaxCont.ForeColor = Color.White;
            buttonMaxCont.Location = new Point(28, 0);
            buttonMaxCont.Margin = new Padding(0);
            buttonMaxCont.Name = "buttonMaxCont";
            buttonMaxCont.Size = new Size(25, 24);
            buttonMaxCont.TabIndex = 1;
            buttonMaxCont.Text = "O";
            buttonMaxCont.UseVisualStyleBackColor = false;
            // 
            // buttonCloseCont
            // 
            buttonCloseCont.BackColor = Color.DarkCyan;
            buttonCloseCont.Dock = DockStyle.Right;
            buttonCloseCont.FlatAppearance.BorderSize = 0;
            buttonCloseCont.FlatAppearance.MouseDownBackColor = Color.FromArgb(252, 97, 97);
            buttonCloseCont.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 97, 97);
            buttonCloseCont.FlatStyle = FlatStyle.Flat;
            buttonCloseCont.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCloseCont.ForeColor = Color.White;
            buttonCloseCont.Location = new Point(53, 0);
            buttonCloseCont.Margin = new Padding(0);
            buttonCloseCont.Name = "buttonCloseCont";
            buttonCloseCont.Size = new Size(25, 24);
            buttonCloseCont.TabIndex = 0;
            buttonCloseCont.Text = "X";
            buttonCloseCont.UseVisualStyleBackColor = false;
            buttonCloseCont.Click += buttonCloseCont_Click_1;
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 711);
            Controls.Add(pContenedor);
            Controls.Add(pPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pPrincipal.ResumeLayout(false);
            pPrincipal.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panelRedondo1.ResumeLayout(false);
            panelRedondo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRedondo3.ResumeLayout(false);
            panelRedondo3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelRedondo2.ResumeLayout(false);
            panelRedondo2.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pPrincipal;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Panel pContenedor;
        private PictureBox pictureBox3;
        private botonRedondo botonRedondo1;
        private Panel panel5;
        private Button buttonMinCont;
        private Button buttonMaxCont;
        private Button buttonCloseCont;
        private PanelRedondo panelRedondo1;
        private Label label10;
        private botonRedondo botonRedondo2;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private PanelRedondo panelRedondo3;
        private PanelRedondo panelRedondo2;
        private botonRedondo btnEntrar;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label validoOno;
        private Label label12;
        private Label label11;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label labelHora;
        private Label labelFecha;
        private Button btnMinimized;
        private Button btnMaximized;
        private Button btnClose;
        private System.Windows.Forms.Timer horaFecha;
        private Button button1;
    }
}
