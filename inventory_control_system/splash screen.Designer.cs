namespace inventory_control_system
{
    partial class splash_screen
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash_screen));
            label1 = new Label();
            label2 = new Label();
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkTurquoise;
            label1.Location = new Point(128, 68);
            label1.Name = "label1";
            label1.Size = new Size(1015, 65);
            label1.TabIndex = 0;
            label1.Text = "STOCK INVENTORY MANAGEMENT ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkTurquoise;
            label2.Location = new Point(491, 161);
            label2.Name = "label2";
            label2.Size = new Size(220, 55);
            label2.TabIndex = 1;
            label2.Text = "SYSTEM";
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.BackColor = Color.Transparent;
            guna2CircleProgressBar1.FillColor = Color.FromArgb(200, 213, 218, 223);
            guna2CircleProgressBar1.Font = new Font("Segoe UI", 12F);
            guna2CircleProgressBar1.ForeColor = Color.White;
            guna2CircleProgressBar1.Location = new Point(987, 387);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ProgressColor = Color.Teal;
            guna2CircleProgressBar1.ProgressColor2 = Color.FromArgb(224, 224, 224);
            guna2CircleProgressBar1.ProgressOffset = 2;
            guna2CircleProgressBar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new Size(150, 150);
            guna2CircleProgressBar1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSeaGreen;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(769, 512);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 4;
            label3.Text = "Loading.......";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 564);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 5;
            label4.Text = "Copyright ";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // splash_screen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1205, 634);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(guna2CircleProgressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.WaitCursor;
            FormBorderStyle = FormBorderStyle.None;
            Name = "splash_screen";
            Text = "splash_screen";
            WindowState = FormWindowState.Maximized;
            Load += splash_screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}