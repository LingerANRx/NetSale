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
    public partial class Confirmar_compra : Form
    {
        static double totalFinal = 0.0;
        static List<Producto> productos = new List<Producto>();
        public Confirmar_compra()
        {
            InitializeComponent();
        }

        private void Confirmar_compra_Load(object sender, EventArgs e)
        {
            Columnas();
            RellenaListView();
            txt_Total.Text = Convert.ToString(TotalText());
        }
        public void Columnas()
        {
            lvProductos.View = View.Details;
            lvProductos.Columns.Add("Producto", 100, HorizontalAlignment.Left);;
            lvProductos.Columns.Add("Cant", 75, HorizontalAlignment.Right);
            lvProductos.Columns.Add("Prec", 75, HorizontalAlignment.Right);
            lvProductos.Columns.Add("Total", 100, HorizontalAlignment.Right);
        }
        public void Productos(string product, int cant, double pre, double tot)
        {
            productos.Add(new Producto { producto = product, cantidad = cant, precio = pre, total = tot });
        }
        public void RellenaListView()
        {
            for(int i = 0; i < productos.Count; i++)
            {
                lvProductos.Items.Add(productos[i].producto);
                lvProductos.Items[i].SubItems.Add(Convert.ToString(productos[i].cantidad));
                lvProductos.Items[i].SubItems.Add(Convert.ToString(productos[i].precio));
                lvProductos.Items[i].SubItems.Add(Convert.ToString(productos[i].total));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvProductos.Clear();
            this.Hide();
            productos.Clear();
            totalFinal = 0.00;
            txt_Total.Text = string.Empty;
        }

        static double TotalText()
        {
            for (int i = 0; i < productos.Count; i++)
            {
                totalFinal = totalFinal + Convert.ToDouble(productos[i].total);
            }
            return totalFinal;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
