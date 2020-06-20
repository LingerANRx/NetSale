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
                else
                {
                    total = cantidad * precio;
                    ConfirmarVenta.Productos(Alimento1.Text, cantidad, precio, total);
                }
            }
            if (P2.Checked == true)
            {
                int cantidad2 = Convert.ToInt32(cantidadP2.Value);
                double precio2 = Convert.ToDouble(precioP2.Text.Substring(1));
                double total2 = cantidad2 * precio2;
                if (cantidad2 == 0)
                {
                    cantidad2 = 1;
                    total2 = cantidad2 * precio2;
                    ConfirmarVenta.Productos(Alimento2.Text, cantidad2, precio2, total2);
                }
                else
                {
                    total2 = cantidad2 * precio2;
                    ConfirmarVenta.Productos(Alimento2.Text, cantidad2, precio2, total2);
                }
            }
            if (P3.Checked == true)
            {
                int cantidad3 = Convert.ToInt32(cantidadP3.Value);
                double precio3 = Convert.ToDouble(precioP3.Text.Substring(1));
                double total3 = cantidad3 * precio3;
                if (cantidad3 == 0)
                {
                    cantidad3 = 1;
                    total3 = cantidad3 * precio3;
                    ConfirmarVenta.Productos(Alimento3.Text, cantidad3, precio3, total3);
                }
                else
                {
                    total3 = cantidad3 * precio3;
                    ConfirmarVenta.Productos(Alimento3.Text, cantidad3, precio3, total3);
                }
            }
            if (P4.Checked == true)
            {
                int cantidad4 = Convert.ToInt32(cantidadP4.Value);
                double precio4 = Convert.ToDouble(precioP4.Text.Substring(1));
                double total4 = cantidad4 * precio4;
                if (cantidad4 == 0)
                {
                    cantidad4 = 1;
                    total4 = cantidad4 * precio4;
                    ConfirmarVenta.Productos(Bebida1.Text, cantidad4, precio4, total4);
                }
                else
                {
                    total4 = cantidad4 * precio4;
                    ConfirmarVenta.Productos(Bebida1.Text, cantidad4, precio4, total4);
                }
            }
            if (P5.Checked == true)
            {
                int cantidad5 = Convert.ToInt32(cantidadP5.Value);
                double precio5 = Convert.ToDouble(precioP5.Text.Substring(1));
                double total5 = cantidad5 * precio5;
                if (cantidad5 == 0)
                {
                    cantidad5 = 1;
                    total5 = cantidad5 * precio5;
                    ConfirmarVenta.Productos(Bebida2.Text, cantidad5, precio5, total5);
                }
                else
                {
                    total5 = cantidad5 * precio5;
                    ConfirmarVenta.Productos(Bebida2.Text, cantidad5, precio5, total5);
                }
            }
            if (P6.Checked == true)
            {
                int cantidad6 = Convert.ToInt32(cantidadP6.Value);
                double precio6 = Convert.ToDouble(precioP6.Text.Substring(1));
                double total6 = cantidad6 * precio6;
                if (cantidad6 == 0)
                {
                    cantidad6 = 1;
                    total6 = cantidad6 * precio6;
                    ConfirmarVenta.Productos(Bebida3.Text, cantidad6, precio6, total6);
                }
                else
                {
                    total6 = cantidad6 * precio6;
                    ConfirmarVenta.Productos(Bebida3.Text, cantidad6, precio6, total6);
                }
            }
            if (P7.Checked == true)
            {
                int cantidad7 = Convert.ToInt32(cantidadP7.Value);
                double precio7 = Convert.ToDouble(precioP7.Text.Substring(1));
                double total7 = cantidad7 * precio7;
                if (cantidad7 == 0)
                {
                    cantidad7 = 1;
                    total7 = cantidad7 * precio7;
                    ConfirmarVenta.Productos(Postre1.Text, cantidad7, precio7, total7);
                }
                else
                {
                    total7 = cantidad7 * precio7;
                    ConfirmarVenta.Productos(Postre1.Text, cantidad7, precio7, total7);
                }
            }
            if (P8.Checked == true)
            {
                int cantidad8 = Convert.ToInt32(cantidadP8.Value);
                double precio8 = Convert.ToDouble(precioP8.Text.Substring(1));
                double total8 = cantidad8 * precio8;
                if (cantidad8 == 0)
                {
                    cantidad8 = 1;
                    total8 = cantidad8 * precio8;
                    ConfirmarVenta.Productos(Postre2.Text, cantidad8, precio8, total8);
                }
                else
                {
                    total8 = cantidad8 * precio8;
                    ConfirmarVenta.Productos(Postre2.Text, cantidad8, precio8, total8);
                }
            }
            if (P9.Checked == true)
            {
                int cantidad9 = Convert.ToInt32(cantidadP9.Value);
                double precio9 = Convert.ToDouble(precioP9.Text.Substring(1));
                double total9 = cantidad9 * precio9;
                if (cantidad9 == 0)
                {
                    cantidad9 = 1;
                    total9 = cantidad9 * precio9;
                    ConfirmarVenta.Productos(Postre3.Text, cantidad9, precio9, total9);
                }
                else
                {
                    total9 = cantidad9 * precio9;
                    ConfirmarVenta.Productos(Postre3.Text, cantidad9, precio9, total9);
                }
            }
            Confirmar_compra frm3 = new Confirmar_compra();
            frm3.ShowDialog();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            cantidadP1.Value = 0;
            P1.Checked = false;
            cantidadP2.Value = 0;
            P2.Checked = false;
            cantidadP3.Value = 0;
            P3.Checked = false;
            cantidadP4.Value = 0;
            P4.Checked = false;
            cantidadP5.Value = 0;
            P5.Checked = false;
            cantidadP6.Value = 0;
            P6.Checked = false;
            cantidadP7.Value = 0;
            P7.Checked = false;
            cantidadP8.Value = 0;
            P8.Checked = false;
            cantidadP9.Value = 0;
            P9.Checked = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
