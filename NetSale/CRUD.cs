using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NetSale
{
    class CRUD
    {
        SqlConnection conSQL = ConectarDB.conexion();
        SqlCommand cmdSQL;
        SqlDataReader lectura;
        SqlDataAdapter datos;
        public int validacion(string user, string password)
        {
            int Val = 0;
            DataTable tablaDatos = new DataTable();
            conSQL.Close();
            conSQL.Open();
            datos = new SqlDataAdapter("SELECT Nombre, Pass FROM Usuarios", conSQL);
            datos.Fill(tablaDatos);
            foreach (DataRow dr in tablaDatos.Rows)
            {
                if (dr.Field<string>("Nombre") == user && dr.Field<string>("Pass") == password) //your condition
                {
                    Val = 1;
                    break;
                }
            }
            conSQL.Close();
            return Val;
        }
    }
}
