using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace inventory_control_system
{
    public partial class splash_screen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public splash_screen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            guna2CircleProgressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...");// new comment
        }

        private void splash_screen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Value += 1;
            guna2CircleProgressBar1.Text=guna2CircleProgressBar1.Value.ToString() + "%";
            if (guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Form1 login = new Form1();
                login.Show();
            }

        }
    }
}
