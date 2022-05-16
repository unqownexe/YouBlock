using System;
using System.Windows.Forms;
namespace YouBlock
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        string Password = "405930";


        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Opacity = 100.0f;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Opacity = 0.0f;
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == Password)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0f;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
