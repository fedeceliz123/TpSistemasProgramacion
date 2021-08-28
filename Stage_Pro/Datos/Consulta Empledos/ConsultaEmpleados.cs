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
        public DataTable LEmpleaos(Empleados empleado,string activo)
        {
            DataTable dt = new DataTable();

            string consulta = "select * from empleados where dni like '%" + empleado.dni+"%' and activo='"+activo+"'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];

            return dt;

        }
        public DataTable ListarEmpleaos( string activo)
        {
            DataTable dt = new DataTable();

            string consulta = "select dni as 'Dni',nombre as 'Nombre', apellido as 'Apellido',puesto as 'Puesto' from empleados where activo='" + activo + "'";
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

        public void ModificarEmp(Empleados empleados)
        {

            string consulta = "set dateformat dmy UPDATE Empleados set nombre='"+empleados.nombre+"',apellido='"+empleados.apellido+"',sexo='"+empleados.sexo+"',fecha_de_nacimiento='"+empleados.fecha_nacimiento+"',puesto='"+empleados.puesto+"',fecha_de_ingreso='"+empleados.fecha_ingreso+"',valor_dia_deposito="+empleados.valor_dia_deposito+",valor_dia_evento="+empleados.valor_dia_deposito+" where dni='" + empleados.dni+"'";

            SqlCommand cmd = new SqlCommand(consulta,Conetar());




            cmd.ExecuteNonQuery();

        }



    }
}
