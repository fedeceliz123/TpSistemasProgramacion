using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos.ConsultaEventos
{
   public class ConsultasEventos:ConexionDB
    {
        public void CargarEvento(Eventos ev)
        {
            string consulta = "insert into eventos (id_cliente,fecha_inicio,hora_inicio,fecha_fin,lugar,encargado,total,detalle,activo)values(@cli,@fi,@hora,@ff,@lugar,@enc,@total,@det,'si')";
            SqlCommand cmd = new SqlCommand(consulta, Conetar());

            cmd.Parameters.AddWithValue("@cli",ev.id_cliente);
            cmd.Parameters.AddWithValue("@fi", ev.fecha_inicio);
            cmd.Parameters.AddWithValue("@hora", ev.hora_inicio);
            cmd.Parameters.AddWithValue("@ff", ev.fecha_fin);
            cmd.Parameters.AddWithValue("@lugar", ev.lugar);
            cmd.Parameters.AddWithValue("@enc", ev.encargado);
            cmd.Parameters.AddWithValue("@total", ev.total);
            cmd.Parameters.AddWithValue("@det", ev.detalle);
            

            cmd.ExecuteNonQuery();
        }

        public DataTable ListarEventos(string activo)

        {
            string fecha = (DateTime.Now.AddDays(-1)).ToString("MM/dd/yyyy");

            DataTable dt = new DataTable();
            string consulta = "select e.id,e.lugar as 'Lugar',e.fecha_inicio as 'Fecha',e.hora_inicio as 'Hora',c.nombre+' '+c.apellido as 'Cliente' from eventos e, clientes_cf c where e.activo='"+activo+"' and fecha_inicio>'"+fecha+"' and id_cliente=c.dni";
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];


            return dt;
        }

        public DataTable CargarClientes()
        {
            DataTable dt = new DataTable();
            string consulta = "select dni, nombre+' '+apellido as cliente from clientes_cf where activo='si'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];


            return dt;
        }
        public DataTable CargarEmpleados()
        {
            DataTable dt = new DataTable();
            string consulta = "select dni, nombre+' '+apellido as empleado from empleados where activo='si'";
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];


            return dt;
        }


    }
}
