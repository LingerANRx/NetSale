using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSale
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = 4000;
            timer1.Start();
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Bienvenido f2 = new Bienvenido();
            this.Hide();
            f2.ShowDialog();
            this.Close();timer1.Stop();
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
