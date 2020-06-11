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
    public partial class Menu : Form
    {
        static Confirmar_compra ConfirmarVenta = new Confirmar_compra();
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(P1.Checked == true)
            {
                int cantidad = Convert.ToInt32(cantidadP1.Value);
                double precio = Convert.ToDouble(precioP1.Text.Substring(1));
                double total = cantidad * precio;
                if(cantidad == 0)
                {
                    cantidad = 1;
                    total = cantidad * precio;
                    ConfirmarVenta.Productos(Alimento1.Text, cantidad, precio, total);
                }
            }
            Confirmar_compra frm3 = new Confirmar_compra();
            frm3.ShowDialog();
        }
    }
}
