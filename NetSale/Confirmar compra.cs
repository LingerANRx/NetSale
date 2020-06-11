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
        static List<Producto> productos = new List<Producto>();
        public Confirmar_compra()
        {
            InitializeComponent();
        }

        private void Confirmar_compra_Load(object sender, EventArgs e)
        {
            Columnas();
            RellenaListView();
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
    }
}
