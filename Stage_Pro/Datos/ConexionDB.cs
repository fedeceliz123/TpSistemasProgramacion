using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionDB
    {
        private SqlConnection Conexion = new SqlConnection();
        private string cadena = "Data Source=FEDE\\SQLEXPRESS;Initial Catalog=stage pro; Integrated Security=True";


        public SqlConnection Conetar()
        {

            try
            {

                Conexion = new SqlConnection(cadena);

                if (Conexion.State.Equals(ConnectionState.Open))
                {
                    Conexion.Close();
                }
                else
                {
                    Conexion.Open();
                }


            }
            catch
            {






            }

            return Conexion;

        }
    }
}
