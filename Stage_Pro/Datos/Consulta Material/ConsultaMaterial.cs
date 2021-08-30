using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Consulta_Matrial
{
   public class ConsultaMaterial:ConexionDB
    {

        public DataTable LlenarTipo()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from tipo_material";
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];


            return dt;

        }

        public DataTable LlenarModelo(int tipo)
        {
            DataTable dt = new DataTable();
            string consulta = "select id,modelo from modelo_material where id_tipo="+tipo;
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conetar());
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt = ds.Tables[0];


            return dt;

        }

        public string Ultimo(int tipo,int modelo)
        {
            string ultimo;
            DataTable dt = new DataTable();
            string consulta = "select MAX(numero+1) as 'num' from material where tipo='" + tipo +"' and modelo='"+modelo+"'" ;
            SqlCommand Comando = new SqlCommand(consulta, Conetar());
            SqlDataReader lector = Comando.ExecuteReader();
            if (lector.Read() == true)
            {
                if(lector["num"].ToString() != "")
                {
                    ultimo = lector["num"].ToString();
                    return ultimo;
                }
                else
                {
                    ultimo = "";
                    return ultimo;
                }
            }
            else
            {
                ultimo = "";
                return ultimo;
            }



            

        }




    }
}
