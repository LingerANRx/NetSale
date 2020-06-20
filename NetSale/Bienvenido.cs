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
    public partial class Bienvenido : Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu frm3 = new Menu();
            this.Hide();
            frm3.ShowDialog();
            this.Close();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frmAd = new Login();
            frmAd.ShowDialog();
        }
    }
}
