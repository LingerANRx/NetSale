using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace NetSale
{
    class ConectarDB
    {
        public static SqlConnection conexion()
        {
            string stringConexion = ConfigurationManager.ConnectionStrings["cadenaCon"].ConnectionString;
            SqlConnection miConexion = new SqlConnection(stringConexion);
            return miConexion;
        }
    }
}
