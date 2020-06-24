using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace NetSale
{
    public partial class Login : Form
    {
        CRUD crd = new CRUD();
        ConectarDB ConDB = new ConectarDB();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (crd.validacion(txt_usuario.Text, txt_password.Text) == 11)
            {
                Administrador frmRoot = new Administrador();
                this.Hide();
                frmRoot.ShowDialog();
                this.Close();
            }
            else
            {
                if (crd.validacion(txt_usuario.Text, txt_password.Text) == 1)
                {
                    Usuario frmUser = new Usuario();
                    this.Hide();
                    frmUser.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("La contraseña o el usuaio no coinciden", "Algo anda mal...");
            }
                
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
