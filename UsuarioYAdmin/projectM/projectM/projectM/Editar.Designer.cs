namespace projectM
{
    partial class Editar
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
            panelAgregar = new Panel();
            txtBtExistencias = new TextBox();
            btnCerrarAgregar = new Button();
            btnAceptarAgregar = new Button();
            label5 = new Label();
            radioBtnPerifericos = new RadioButton();
            radioBtnGaming = new RadioButton();
            richTextBoxColeccion = new RichTextBox();
            txtBtPrecio = new TextBox();
            txtBtDesc = new TextBox();
            txtBtImg = new TextBox();
            txtBtId = new TextBox();
            label1 = new Label();
            panelAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // panelAgregar
            // 
            panelAgregar.BackColor = Color.FromArgb(255, 192, 255);
            panelAgregar.Controls.Add(txtBtExistencias);
            panelAgregar.Controls.Add(btnCerrarAgregar);
            panelAgregar.Controls.Add(btnAceptarAgregar);
            panelAgregar.Controls.Add(label5);
            panelAgregar.Controls.Add(radioBtnPerifericos);
            panelAgregar.Controls.Add(radioBtnGaming);
            panelAgregar.Controls.Add(richTextBoxColeccion);
            panelAgregar.Controls.Add(txtBtPrecio);
            panelAgregar.Controls.Add(txtBtDesc);
            panelAgregar.Controls.Add(txtBtImg);
            panelAgregar.Controls.Add(txtBtId);
            panelAgregar.Controls.Add(label1);
            panelAgregar.Location = new Point(444, 130);
            panelAgregar.Name = "panelAgregar";
            panelAgregar.Size = new Size(312, 413);
            panelAgregar.TabIndex = 5;
            panelAgregar.Visible = false;
            // 
            // txtBtExistencias
            // 
            txtBtExistencias.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBtExistencias.Location = new Point(61, 234);
            txtBtExistencias.Name = "txtBtExistencias";
            txtBtExistencias.PlaceholderText = "Existencias del producto";
            txtBtExistencias.Size = new Size(193, 22);
            txtBtExistencias.TabIndex = 10;
            txtBtExistencias.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCerrarAgregar
            // 
            btnCerrarAgregar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarAgregar.Location = new Point(281, 13);
            btnCerrarAgregar.Name = "btnCerrarAgregar";
            btnCerrarAgregar.Size = new Size(28, 23);
            btnCerrarAgregar.TabIndex = 9;
            btnCerrarAgregar.Text = "X";
            btnCerrarAgregar.UseVisualStyleBackColor = true;
            btnCerrarAgregar.Click += btnCerrarAgregar_Click;
            // 
            // btnAceptarAgregar
            // 
            btnAceptarAgregar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptarAgregar.Location = new Point(90, 363);
            btnAceptarAgregar.Name = "btnAceptarAgregar";
            btnAceptarAgregar.Size = new Size(124, 42);
            btnAceptarAgregar.TabIndex = 8;
            btnAceptarAgregar.Text = "Agregar";
            btnAceptarAgregar.UseVisualStyleBackColor = true;
            btnAceptarAgregar.Click += btnAceptarAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(90, 275);
            label5.Name = "label5";
            label5.Size = new Size(149, 16);
            label5.TabIndex = 7;
            label5.Text = "Selecciona Colección";
            // 
            // radioBtnPerifericos
            // 
            radioBtnPerifericos.AutoSize = true;
            radioBtnPerifericos.BackColor = Color.White;
            radioBtnPerifericos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioBtnPerifericos.Location = new Point(112, 321);
            radioBtnPerifericos.Name = "radioBtnPerifericos";
            radioBtnPerifericos.Size = new Size(90, 21);
            radioBtnPerifericos.TabIndex = 6;
            radioBtnPerifericos.TabStop = true;
            radioBtnPerifericos.Text = "Periféricos";
            radioBtnPerifericos.UseVisualStyleBackColor = false;
            // 
            // radioBtnGaming
            // 
            radioBtnGaming.AutoSize = true;
            radioBtnGaming.BackColor = Color.White;
            radioBtnGaming.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioBtnGaming.Location = new Point(112, 294);
            radioBtnGaming.Name = "radioBtnGaming";
            radioBtnGaming.Size = new Size(79, 21);
            radioBtnGaming.TabIndex = 5;
            radioBtnGaming.TabStop = true;
            radioBtnGaming.Text = "Gaming";
            radioBtnGaming.UseVisualStyleBackColor = false;
            // 
            // richTextBoxColeccion
            // 
            richTextBoxColeccion.Location = new Point(61, 266);
            richTextBoxColeccion.Name = "richTextBoxColeccion";
            richTextBoxColeccion.Size = new Size(193, 91);
            richTextBoxColeccion.TabIndex = 0;
            richTextBoxColeccion.Text = "";
            // 
            // txtBtPrecio
            // 
            txtBtPrecio.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBtPrecio.Location = new Point(61, 206);
            txtBtPrecio.Name = "txtBtPrecio";
            txtBtPrecio.PlaceholderText = "Precio del producto";
            txtBtPrecio.Size = new Size(193, 22);
            txtBtPrecio.TabIndex = 4;
            txtBtPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBtDesc
            // 
            txtBtDesc.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBtDesc.Location = new Point(38, 164);
            txtBtDesc.Multiline = true;
            txtBtDesc.Name = "txtBtDesc";
            txtBtDesc.PlaceholderText = "Descripcion del producto (20 caracteres)";
            txtBtDesc.Size = new Size(248, 36);
            txtBtDesc.TabIndex = 3;
            txtBtDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBtImg
            // 
            txtBtImg.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBtImg.Location = new Point(61, 126);
            txtBtImg.Name = "txtBtImg";
            txtBtImg.PlaceholderText = "Nombre de la imagen";
            txtBtImg.Size = new Size(193, 22);
            txtBtImg.TabIndex = 2;
            txtBtImg.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBtId
            // 
            txtBtId.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBtId.Location = new Point(61, 87);
            txtBtId.Name = "txtBtId";
            txtBtId.PlaceholderText = "Id del producto";
            txtBtId.Size = new Size(193, 22);
            txtBtId.TabIndex = 1;
            txtBtId.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 14);
            label1.Name = "label1";
            label1.Size = new Size(193, 39);
            label1.TabIndex = 0;
            label1.Text = "Agregar Producto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 660);
            Controls.Add(panelAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Editar";
            Text = "Editar";
            panelAgregar.ResumeLayout(false);
            panelAgregar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAgregar;
        private Button btnCerrarAgregar;
        private Button btnAceptarAgregar;
        private Label label5;
        private RadioButton radioBtnPerifericos;
        private RadioButton radioBtnGaming;
        private RichTextBox richTextBoxColeccion;
        private TextBox txtBtPrecio;
        private TextBox txtBtDesc;
        private TextBox txtBtImg;
        private TextBox txtBtId;
        private Label label1;
        private TextBox txtBtExistencias;
    }
}