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

namespace NetSale
{
    public partial class Usuario : Form
    {
        CRUD crd = new CRUD();
        SqlConnection nvConexion = ConectarDB.conexion();
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            txt_pasta.ReadOnly = true;
            txt_hambur.ReadOnly = true;
            txt_cCompleta.ReadOnly = true;
            txt_Jugo.ReadOnly = true;
            txt_cocaC.ReadOnly = true;
            txt_agua.ReadOnly = true;
            txt_choco.ReadOnly = true;
            txt_pay.ReadOnly = true;
            txt_galletas.ReadOnly = true;
            mp1.ReadOnly = true;
            mp2.ReadOnly = true;
            mp3.ReadOnly = true;
            mp4.ReadOnly = true;
            mp5.ReadOnly = true;
            mp6.ReadOnly = true;
            mp7.ReadOnly = true;
            mp8.ReadOnly = true;
            mp9.ReadOnly = true;
            crd.llenarPrecios();
            txt_pasta.Text = Convert.ToString(CRUD.precios[0]);
            txt_hambur.Text = Convert.ToString(CRUD.precios[1]);
            txt_cCompleta.Text = Convert.ToString(CRUD.precios[2]);
            txt_Jugo.Text = Convert.ToString(CRUD.precios[3]);
            txt_cocaC.Text = Convert.ToString(CRUD.precios[4]);
            txt_agua.Text = Convert.ToString(CRUD.precios[5]);
            txt_choco.Text = Convert.ToString(CRUD.precios[6]);
            txt_pay.Text = Convert.ToString(CRUD.precios[7]);
            txt_galletas.Text = Convert.ToString(CRUD.precios[8]);

            crd.llenarInventarios();
            mp1.Text = Convert.ToString(CRUD.inventarios[0]);
            mp2.Text = Convert.ToString(CRUD.inventarios[1]);
            mp3.Text = Convert.ToString(CRUD.inventarios[2]);
            mp4.Text = Convert.ToString(CRUD.inventarios[3]);
            mp5.Text = Convert.ToString(CRUD.inventarios[4]);
            mp6.Text = Convert.ToString(CRUD.inventarios[5]);
            mp7.Text = Convert.ToString(CRUD.inventarios[6]);
            mp8.Text = Convert.ToString(CRUD.inventarios[7]);
            mp9.Text = Convert.ToString(CRUD.inventarios[8]);
        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            CRUD objread = new CRUD();
            dgvProductos.DataSource = objread.Read();
            if (dgvProductos.Rows.Count == 0)
                MessageBox.Show("No hay Datos en la tabla");
        }

        private void btn_precios_Click(object sender, EventArgs e)
        {
            if (btn_precios.Text == "Editar")
            {
                txt_pasta.ReadOnly = false;
                txt_hambur.ReadOnly = false;
                txt_cCompleta.ReadOnly = false;
                txt_Jugo.ReadOnly = false;
                txt_cocaC.ReadOnly = false;
                txt_agua.ReadOnly = false;
                txt_choco.ReadOnly = false;
                txt_pay.ReadOnly = false;
                txt_galletas.ReadOnly = false;
                btn_precios.Text = "Guardar";
            }
            else
            {
                if (txt_pasta.Text == string.Empty)
                    EP.SetError(txt_pasta, "Campo requerido");
                if (txt_hambur.Text == string.Empty)
                    EP.SetError(txt_hambur, "Campo requerido");
                if (txt_cCompleta.Text == string.Empty)
                    EP.SetError(txt_cCompleta, "Campo requerido");
                if (txt_Jugo.Text == string.Empty)
                    EP.SetError(txt_Jugo, "Campo requerido");
                if (txt_cocaC.Text == string.Empty)
                    EP.SetError(txt_cocaC, "Campo requerido");
                if (txt_agua.Text == string.Empty)
                    EP.SetError(txt_agua, "Campo requerido");
                if (txt_choco.Text == string.Empty)
                    EP.SetError(txt_choco, "Campo requerido");
                if (txt_pay.Text == string.Empty)
                    EP.SetError(txt_pay, "Campo requerido");
                if (txt_galletas.Text == string.Empty)
                    EP.SetError(txt_galletas, "Campo requerido");
                if (crd.modPrecios(txt_pasta.Text, txt_hambur.Text, txt_cCompleta.Text, txt_Jugo.Text, txt_cocaC.Text, txt_agua.Text, txt_choco.Text, txt_pay.Text, txt_galletas.Text) == 9)
                {
                    txt_pasta.ReadOnly = true;
                    txt_hambur.ReadOnly = true;
                    txt_cCompleta.ReadOnly = true;
                    txt_Jugo.ReadOnly = true;
                    txt_cocaC.ReadOnly = true;
                    txt_agua.ReadOnly = true;
                    txt_choco.ReadOnly = true;
                    txt_pay.ReadOnly = true;
                    txt_galletas.ReadOnly = true;
                    MessageBox.Show("Modificacion realizada con exito");
                }

                btn_precios.Text = "Editar";
            }
        }

        private void btn_modInven_Click(object sender, EventArgs e)
        {
            if (mp1.Text == string.Empty)
                EP.SetError(mp1, "Campo requerido");
            if (mp2.Text == string.Empty)
                EP.SetError(mp2, "Campo requerido");
            if (mp3.Text == string.Empty)
                EP.SetError(mp3, "Campo requerido");
            if (mp4.Text == string.Empty)
                EP.SetError(mp4, "Campo requerido");
            if (mp5.Text == string.Empty)
                EP.SetError(mp5, "Campo requerido");
            if (mp6.Text == string.Empty)
                EP.SetError(mp6, "Campo requerido");
            if (mp7.Text == string.Empty)
                EP.SetError(mp7, "Campo requerido");
            if (mp8.Text == string.Empty)
                EP.SetError(mp8, "Campo requerido");
            if (mp9.Text == string.Empty)
                EP.SetError(mp9, "Campo requerido");
            if (btn_modInven.Text == "Editar")
            {
                mp1.ReadOnly = false;
                mp2.ReadOnly = false;
                mp3.ReadOnly = false;
                mp4.ReadOnly = false;
                mp5.ReadOnly = false;
                mp6.ReadOnly = false;
                mp7.ReadOnly = false;
                mp8.ReadOnly = false;
                mp9.ReadOnly = false;
                btn_modInven.Text = "Guardar";
            }
            else
            {
                if (crd.modInventario(mp1.Text, mp2.Text, mp3.Text, mp4.Text, mp5.Text, mp6.Text, mp7.Text, mp8.Text, mp9.Text) == 9)
                {
                    mp1.ReadOnly = true;
                    mp2.ReadOnly = true;
                    mp3.ReadOnly = true;
                    mp4.ReadOnly = true;
                    mp5.ReadOnly = true;
                    mp6.ReadOnly = true;
                    mp7.ReadOnly = true;
                    mp8.ReadOnly = true;
                    mp9.ReadOnly = true;
                    MessageBox.Show("Modificacion realizada con exito");
                }

                btn_modInven.Text = "Editar";
            }
        }

        private void btn_modInven_Click_1(object sender, EventArgs e)
        {
            if (mp1.Text == string.Empty)
                EP.SetError(mp1, "Campo requerido");
            if (mp2.Text == string.Empty)
                EP.SetError(mp2, "Campo requerido");
            if (mp3.Text == string.Empty)
                EP.SetError(mp3, "Campo requerido");
            if (mp4.Text == string.Empty)
                EP.SetError(mp4, "Campo requerido");
            if (mp5.Text == string.Empty)
                EP.SetError(mp5, "Campo requerido");
            if (mp6.Text == string.Empty)
                EP.SetError(mp6, "Campo requerido");
            if (mp7.Text == string.Empty)
                EP.SetError(mp7, "Campo requerido");
            if (mp8.Text == string.Empty)
                EP.SetError(mp8, "Campo requerido");
            if (mp9.Text == string.Empty)
                EP.SetError(mp9, "Campo requerido");
            if (btn_modInven.Text == "Editar")
            {
                mp1.ReadOnly = false;
                mp2.ReadOnly = false;
                mp3.ReadOnly = false;
                mp4.ReadOnly = false;
                mp5.ReadOnly = false;
                mp6.ReadOnly = false;
                mp7.ReadOnly = false;
                mp8.ReadOnly = false;
                mp9.ReadOnly = false;
                btn_modInven.Text = "Guardar";
            }
            else
            {
                if (crd.modInventario(mp1.Text, mp2.Text, mp3.Text, mp4.Text, mp5.Text, mp6.Text, mp7.Text, mp8.Text, mp9.Text) == 9)
                {
                    mp1.ReadOnly = true;
                    mp2.ReadOnly = true;
                    mp3.ReadOnly = true;
                    mp4.ReadOnly = true;
                    mp5.ReadOnly = true;
                    mp6.ReadOnly = true;
                    mp7.ReadOnly = true;
                    mp8.ReadOnly = true;
                    mp9.ReadOnly = true;
                    MessageBox.Show("Modificacion realizada con exito");
                }

                btn_modInven.Text = "Editar";
            }
        }
    }
}
