using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace NetSale
{
    public partial class Confirmar_compra : Form
    {
        static double totalFinal = 0.0;
        static List<Producto> productos = new List<Producto>();
        CRUD crd = new CRUD();

        public static double TotalFinal { get => totalFinal; set => totalFinal = value; }

        public Confirmar_compra()
        {
            InitializeComponent();
        }

        private void Confirmar_compra_Load(object sender, EventArgs e)
        {
            Columnas();
            RellenaListView();
            txt_Total.Text = "$0";
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

        public void reducirInventario()
        {
            for (int i = 0; i < productos.Count; i++)
            {
                crd.reducirInventario(productos[i].producto, productos[i].cantidad);
            }
        }

        public void productosClear()
        {
            productos.Clear();
        }

        public void generarTicket(string dinero, string cambio)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("SO000001.pdf", FileMode.Create));
            doc.Open();
            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES_BOLD, 20f, BaseColor.BLACK);
            title.Add("N E T   S A L E");
            doc.Add(new Paragraph("------------------------------------------------- "));
            doc.Add(new Paragraph(" "));
            doc.Add(title);
            doc.Add(new Paragraph(" ------------------------------------------------"));
            doc.Add(new Paragraph(""));
            for (int i = 0; i < productos.Count; i++)
            {
                doc.Add(new Paragraph(string.Format("Producto: {0}  || Cantidad: {1}  || Precio unitario: {2} ||  Subtotal: {3}", productos[i].producto, productos[i].cantidad, productos[i].precio, productos[i].total)));
            }
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Total: " + Confirmar_compra.TotalFinal));
            doc.Add(new Paragraph("Efectivo: " + dinero));
            doc.Add(new Paragraph("Cambio: " + cambio));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Gracias por preferirnos :) "));
            doc.Close();
            System.Diagnostics.Process.Start("AcroRd32.exe", "SO000001.pdf");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvProductos.Clear();
            this.Hide();
            productos.Clear();
            TotalFinal = 0.00;
            txt_Total.Text = string.Empty;
        }

        static double TotalText()
        {
            for (int i = 0; i < productos.Count; i++)
            {
                TotalFinal = TotalFinal + Convert.ToDouble(productos[i].total);
            }
            return TotalFinal;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_Total.Text == "$0")
                MessageBox.Show("Primero necesitas agregar productos al carrito...", "Carrito vacio");
            else
            {
                //reducirInventario(); //LLevar a ticket
                lvProductos.Clear();
                this.Hide();
                //productos.Clear(); //llevar a ticket
                txt_Total.Text = string.Empty;
                Ticket frm4 = new Ticket();
                frm4.ShowDialog();
            }
            
        }
    }
}
