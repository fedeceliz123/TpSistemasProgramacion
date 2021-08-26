using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Datos.Consulta_Empledos
{
   public class ConsultaEmpleados:ConexionDB
    {
        public DataTable LEmpleaos(Empleados empleado)
        {
            DataTable dt = new DataTable();

            string consulta = "select * from empleados where dni like '%" + empleado.dni+"%'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];

            return dt;

        }

        public DataTable telEmpleados(Empleados empleado)
        {
            DataTable dt = new DataTable();

            string consulta = "select * from telefonos where id_persona='" + empleado.dni + "'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];

            return dt;

        }

        public DataTable dirEmpleados(Empleados empleado)
        {
            DataTable dt = new DataTable();

            string consulta = "select * from direcciones where id_persona='" + empleado.dni + "'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];

            return dt;

        }

        public DataTable mailEmpleados(Empleados empleado)
        {
            DataTable dt = new DataTable();

            string consulta = "select * from emails where id_persona='" + empleado.dni + "'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];

            return dt;

        }



    }
}
