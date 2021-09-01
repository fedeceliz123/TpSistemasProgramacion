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
        public DataTable LlenarMedida(int tipo)
        {
            DataTable dt = new DataTable();
            string consulta = "select id,medida from medida_material where id_tipo=" + tipo;
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

        public int UltimoModelo(int tipo)
        {
            int ultimo;
            DataTable dt = new DataTable();
            string consulta = "select COUNT(id) as 'num' from modelo_material where id_tipo='" + tipo + "'";
            SqlCommand Comando = new SqlCommand(consulta, Conetar());
            SqlDataReader lector = Comando.ExecuteReader();
            if (lector.Read() == true)
            {
                if (int.Parse(lector["num"].ToString()) != 0)
                {
                    ultimo = int.Parse(lector["num"].ToString())+1;
                    return ultimo;
                }
                else
                {
                    ultimo = 1;
                    return ultimo;
                }
            }
            else
            {
                ultimo = 1;
                return ultimo;
            }


        }

        public void CargaModelo(int tipo, string modelo)
        {
            string consulta = "insert into modelo_material (id,id_tipo,modelo)values('"+UltimoModelo(tipo)+"','" + tipo + "','"+modelo+"')";
            SqlCommand cmd = new SqlCommand(consulta, Conetar());
            cmd.ExecuteNonQuery();
        }
        public void CargaTipo(string tipo)
        {
            string consulta = "insert into tipo_material (tipo)values('"+tipo+"')";
            SqlCommand cmd = new SqlCommand(consulta,Conetar());
            cmd.ExecuteNonQuery();
        }

        public void CargaMedida(int tipo, string medida)
        {
            string consulta = "insert into medida_material (id_tipo,medida)values('" + tipo + "','"+medida+"')";
            SqlCommand cmd = new SqlCommand(consulta, Conetar());
            cmd.ExecuteNonQuery();
        }

        public void CargaMaterial(Material material)
        {
            string consulta = "insert into material (tipo,modelo,numero,codigo,medida,nombre,codigo_qr,activo)values(@tipo,@modelo,@num,@cod,@medida,@nombre,@qr,'si')";
            SqlCommand cmd = new SqlCommand(consulta, Conetar());

            cmd.Parameters.AddWithValue("@tipo", material.tipo);
            cmd.Parameters.AddWithValue("@modelo", material.modelo);
            cmd.Parameters.AddWithValue("@num", material.numero);
            cmd.Parameters.AddWithValue("@cod", material.codigo);
            cmd.Parameters.AddWithValue("@medida", material.medida);
            cmd.Parameters.AddWithValue("@nombre", material.nombre);
            cmd.Parameters.AddWithValue("@qr", material.codigo_qr);

            cmd.ExecuteNonQuery();
        }
    }




    }

