namespace projectM
{
    partial class Grafica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            botonRedondo1 = new botonRedondo();
            pnlVentas = new PanelRedondo();
            panelProductos = new PanelRedondo();
            panelRedondo1 = new PanelRedondo();
            idUsuario = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            pnlVentas.SuspendLayout();
            panelRedondo1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(401, 9);
            label1.Name = "label1";
            label1.Size = new Size(398, 28);
            label1.TabIndex = 0;
            label1.Text = "GRAFICA ralacion Usuario-Monto";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(23, 58);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1154, 580);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // botonRedondo1
            // 
            botonRedondo1.BackColor = Color.DeepPink;
            botonRedondo1.BackgroundColor = Color.DeepPink;
            botonRedondo1.BorderColor = Color.PaleVioletRed;
            botonRedondo1.BorderRadius = 20;
            botonRedondo1.BorderSize = 0;
            botonRedondo1.FlatAppearance.BorderSize = 0;
            botonRedondo1.FlatStyle = FlatStyle.Flat;
            botonRedondo1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonRedondo1.ForeColor = Color.White;
            botonRedondo1.Location = new Point(56, 3);
            botonRedondo1.Name = "botonRedondo1";
            botonRedondo1.Size = new Size(157, 43);
            botonRedondo1.TabIndex = 2;
            botonRedondo1.Text = "Ventas Totales";
            botonRedondo1.TextColor = Color.White;
            botonRedondo1.UseVisualStyleBackColor = false;
            botonRedondo1.Click += botonRedondo1_Click;
            // 
            // pnlVentas
            // 
            pnlVentas.AutoScroll = true;
            pnlVentas.BackColor = Color.White;
            pnlVentas.BackgroundColor = Color.White;
            pnlVentas.BorderColor = Color.Transparent;
            pnlVentas.BorderRadius = 30;
            pnlVentas.BorderSize = 3;
            pnlVentas.Controls.Add(panelProductos);
            pnlVentas.Controls.Add(panelRedondo1);
            pnlVentas.Controls.Add(label2);
            pnlVentas.Location = new Point(2, 52);
            pnlVentas.Name = "pnlVentas";
            pnlVentas.Size = new Size(1198, 597);
            pnlVentas.TabIndex = 3;
            pnlVentas.Visible = false;
            // 
            // panelProductos
            // 
            panelProductos.AutoScroll = true;
            panelProductos.BackColor = Color.White;
            panelProductos.BackgroundColor = Color.White;
            panelProductos.BorderColor = Color.DarkGray;
            panelProductos.BorderRadius = 30;
            panelProductos.BorderSize = 3;
            panelProductos.Location = new Point(515, 30);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new Size(564, 508);
            panelProductos.TabIndex = 2;
            // 
            // panelRedondo1
            // 
            panelRedondo1.BackColor = Color.White;
            panelRedondo1.BackgroundColor = Color.White;
            panelRedondo1.BorderColor = Color.DarkGray;
            panelRedondo1.BorderRadius = 24;
            panelRedondo1.BorderSize = 3;
            panelRedondo1.Controls.Add(idUsuario);
            panelRedondo1.Location = new Point(44, 64);
            panelRedondo1.Name = "panelRedondo1";
            panelRedondo1.Size = new Size(139, 52);
            panelRedondo1.TabIndex = 1;
            // 
            // idUsuario
            // 
            idUsuario.BorderStyle = BorderStyle.None;
            idUsuario.Location = new Point(22, 16);
            idUsuario.Name = "idUsuario";
            idUsuario.Size = new Size(100, 16);
            idUsuario.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 42);
            label2.Name = "label2";
            label2.Size = new Size(183, 19);
            label2.TabIndex = 0;
            label2.Text = "Dame el id del usuario";
            // 
            // Grafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1200, 650);
            Controls.Add(pnlVentas);
            Controls.Add(botonRedondo1);
            Controls.Add(chart1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Grafica";
            Text = "Grafica";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            pnlVentas.ResumeLayout(false);
            pnlVentas.PerformLayout();
            panelRedondo1.ResumeLayout(false);
            panelRedondo1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private botonRedondo botonRedondo1;
        private PanelRedondo pnlVentas;
        private Label label2;
        private PanelRedondo panelRedondo1;
        private TextBox idUsuario;
        private PanelRedondo panelProductos;
    }
}