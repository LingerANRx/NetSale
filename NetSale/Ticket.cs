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
    public partial class Ticket : Form
    {
        public static double totalTicket;
        public Ticket()
        {
            InitializeComponent();
        }

        private void pagar_Click(object sender, EventArgs e)
        {
            if ((txt_Dinero.Text != string.Empty) && (Convert.ToDouble(txt_Dinero.Text) >= Convert.ToDouble(Confirmar_compra.TotalFinal)))
            {
                totalTicket = Convert.ToDouble(txt_Dinero.Text) - Convert.ToDouble(Confirmar_compra.TotalFinal);
                txt_Cambio.Text = Convert.ToString(totalTicket);
                DialogResult _Resp = new DialogResult();
                _Resp = MessageBox.Show("¿Desea imprimir el ticket?",
                    "Ticket", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (_Resp == DialogResult.Yes)
                {
                    //Imprmmir el ticket
                    //GenerarTicket(varFolio);
                    this.Close();
                }
                else
                {
                    this.Close();
                }
                this.Close();
                Confirmar_compra.TotalFinal = 0.0;
                Confirmar_compra frm4 = new Confirmar_compra();
                frm4.Close();
            }
            else
            {
                MessageBox.Show("Debe introducir una Cantidad Valida",
                    "Faltan datos");
            }
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            txt_totalPagar.Text = "$" + Convert.ToString(Confirmar_compra.TotalFinal);
        }
    }
}
