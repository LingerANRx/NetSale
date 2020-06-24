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
        public static decimal[] precios = new decimal[10];
        public static string[] inventarios = new string[10];

        public int validacion(string user, string password)
        {
            int Val = 0;
            DataTable tablaDatos = new DataTable();
            DataTable tablaAdmin = new DataTable();
            conSQL.Close();
            conSQL.Open();
            datos = new SqlDataAdapter("SELECT Nombre, Pass FROM Usuarios", conSQL);
            datos.Fill(tablaDatos);
            foreach (DataRow dr in tablaDatos.Rows)
            {   
                if (dr.Field<string>("Nombre") == user && dr.Field<string>("Pass") == password) 
                {
                    Val = 1;
                    break;
                }
            }
            datos = new SqlDataAdapter("SELECT Nombre, Pass FROM Administrador", conSQL);
            datos.Fill(tablaAdmin);
            foreach (DataRow dr in tablaAdmin.Rows)
            {
                if (dr.Field<string>("Nombre") == user && dr.Field<string>("Pass") == password)
                {
                    Val = 11;
                    break;
                }
            }
            conSQL.Close();
            return Val;
        }

        //public int validacionAdmin(string user, string password)
        //{
        //    int Val = 0;
        //    DataTable tablaAdmin = new DataTable();
        //    conSQL.Close();
        //    conSQL.Open();
        //    datos = new SqlDataAdapter("SELECT Nombre, Pass FROM Administrador", conSQL);
        //    datos.Fill(tablaAdmin);
        //    foreach (DataRow dr in tablaAdmin.Rows)
        //    {
        //        if (dr.Field<string>("Nombre") == user && dr.Field<string>("Pass") == password)
        //        {
        //            Val = 1;
        //            break;
        //        }
        //    }
        //    conSQL.Close();
        //    return Val;
        //}

        public int modPrecios(string P1, string P2, string P3, string P4, string P5, string P6, string P7, string P8, string P9)
        {
            int ok = 0;
            conSQL.Open();
            string comando = string.Format("UPDATE Productos SET [Precio]='{0}' WHERE [Producto]='Pasta'; " +
                "UPDATE Productos SET [Precio]='{1}' WHERE [Producto]='Hamburguesa';" +
                "UPDATE Productos SET [Precio]='{2}' WHERE [Producto]='Comida completa';" +
                "UPDATE Productos SET [Precio]='{3}' WHERE [Producto]='Del valle';" +
                "UPDATE Productos SET [Precio]='{4}' WHERE [Producto]='Coca cola';" +
                "UPDATE Productos SET [Precio]='{5}' WHERE [Producto]='Bonafont';" +
                "UPDATE Productos SET [Precio]='{6}' WHERE [Producto]='Pastel chocolate';" +
                "UPDATE Productos SET [Precio]='{7}' WHERE [Producto]='Pay limon';" +
                "UPDATE Productos SET [Precio]='{8}' WHERE [Producto]='Galletas';", 
                Convert.ToDecimal(P1), Convert.ToDecimal(P2), Convert.ToDecimal(P3), 
                Convert.ToDecimal(P4), Convert.ToDecimal(P5), Convert.ToDecimal(P6), 
                Convert.ToDecimal(P7), Convert.ToDecimal(P8), Convert.ToDecimal(P9)); 
            cmdSQL = new SqlCommand(comando, conSQL);
            ok = cmdSQL.ExecuteNonQuery();
            conSQL.Close();
            return ok;
        }

        public void llenarPrecios()
        {
            DataTable tablaPrecios = new DataTable();
            conSQL.Open();
            datos = new SqlDataAdapter("SELECT Precio FROM Productos", conSQL);
            datos.Fill(tablaPrecios);
            int i = 0;
            foreach (DataRow dr in tablaPrecios.Rows)
            {
                precios[i] = dr.Field<decimal>("Precio");
                i++;
            }
            conSQL.Close();
        }

        public int modInventario(string P1, string P2, string P3, string P4, string P5, string P6, string P7, string P8, string P9)
        {
            int inv = 0;
            conSQL.Open();
            string comando = string.Format("UPDATE Productos SET [Cantidad]='{0}' WHERE [Producto]='Pasta'; " +
                "UPDATE Productos SET [Cantidad]='{1}' WHERE [Producto]='Hamburguesa';" +
                "UPDATE Productos SET [Cantidad]='{2}' WHERE [Producto]='Comida completa';" +
                "UPDATE Productos SET [Cantidad]='{3}' WHERE [Producto]='Del valle';" +
                "UPDATE Productos SET [Cantidad]='{4}' WHERE [Producto]='Coca cola';" +
                "UPDATE Productos SET [Cantidad]='{5}' WHERE [Producto]='Bonafont';" +
                "UPDATE Productos SET [Cantidad]='{6}' WHERE [Producto]='Pastel chocolate';" +
                "UPDATE Productos SET [Cantidad]='{7}' WHERE [Producto]='Pay limon';" +
                "UPDATE Productos SET [Cantidad]='{8}' WHERE [Producto]='Galletas';",
                int.Parse(P1), int.Parse(P2), int.Parse(P3),
                int.Parse(P4), int.Parse(P5), int.Parse(P6),
                int.Parse(P7), int.Parse(P8), int.Parse(P9));
            cmdSQL = new SqlCommand(comando, conSQL);
            inv = cmdSQL.ExecuteNonQuery();
            conSQL.Close();
            return inv;
        }

        public void llenarInventarios()
        {
            DataTable tablaInventarios = new DataTable();
            conSQL.Open();
            datos = new SqlDataAdapter("SELECT Cantidad FROM Productos", conSQL);
            datos.Fill(tablaInventarios);
            int j = 0;
            foreach (DataRow dr in tablaInventarios.Rows)
            {
                inventarios[j] = Convert.ToString(dr.Field<decimal>("Cantidad"));
                j++;
            }
            conSQL.Close();
        }

        public DataTable Read()
        {
            DataTable tablaDatos = new DataTable();
            try
            {
                using (conSQL)
                {
                    conSQL.Open();
                    datos = new SqlDataAdapter("SELECT * FROM Productos", conSQL);
                    datos.Fill(tablaDatos);
                    conSQL.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: {0}", ex.Message);
            }
            return tablaDatos;
        }

        public DataTable ReadUsers()
        {
            DataTable tablaDatos = new DataTable();
            try
            {
                using (conSQL)
                {
                    conSQL.Open();
                    datos = new SqlDataAdapter("SELECT * FROM Usuarios", conSQL);
                    datos.Fill(tablaDatos);
                    conSQL.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: {0}", ex.Message);
            }
            return tablaDatos;
        }

        public int editarAdmin(string anterior, string nuevo, string password)
        {
            int val = 0;
            conSQL.Open();
            string comando =  string.Format("UPDATE Administrador SET [Nombre]='{0}', [Pass]='{1}' WHERE [Nombre]='{2}'", nuevo, password, anterior);
            cmdSQL = new SqlCommand(comando, conSQL);
            val = cmdSQL.ExecuteNonQuery();
            return val;
        }

        public int Create(string usuario, string password)
        {
            int correcto = 0;
            try
            {
                using (conSQL)
                {
                    conSQL.Open();
                    cmdSQL = new SqlCommand(string.Format("INSERT INTO Usuarios(Nombre, Pass) VALUES ('{0}', '{1}')", usuario, password), conSQL);
                    correcto = cmdSQL.ExecuteNonQuery();
                    conSQL.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: {0}", ex.Message);
            }
            return correcto;
        }

        public void reducirInventario(string producto, int cantidad)
        {
            conSQL.Open();
            string comando = string.Format("UPDATE Productos SET [Cantidad]=Cantidad - {0} WHERE [Producto]='{1}';", cantidad, producto);
            cmdSQL = new SqlCommand(comando, conSQL);
            cmdSQL.ExecuteNonQuery();
            conSQL.Close();
        }

        public string Delete(string nombre)
        {
            string ok = "INFO: Registro eliminado con exito";
            try
            {
                using (conSQL)
                {
                    conSQL.Open();
                    cmdSQL = new SqlCommand(string.Format("DELETE FROM Usuarios WHERE Nombre='{0}'", nombre), conSQL);
                    cmdSQL.ExecuteNonQuery();
                    conSQL.Close();
                }
                return ok;
            }
            catch (Exception ex)
            {
                return ok = "ERROR: No se ha podido completar la operacion Ex: " + ex;
            }
        }
    }
}
