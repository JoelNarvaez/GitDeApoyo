namespace projectM
{
    partial class home
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
            label1 = new Label();
            panel1 = new Panel();
            pictureBoxHome = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(446, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrchid;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 55);
            panel1.TabIndex = 1;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Image = Properties.Resources.fondoHome1;
            pictureBoxHome.Location = new Point(99, 61);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(777, 599);
            pictureBoxHome.TabIndex = 2;
            pictureBoxHome.TabStop = false;
            // 
            // home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(985, 660);
            Controls.Add(pictureBoxHome);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "home";
            Text = "home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBoxHome;
    }
}