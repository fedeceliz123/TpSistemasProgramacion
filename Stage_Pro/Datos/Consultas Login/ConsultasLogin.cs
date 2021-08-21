using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Datos.Consultas_Login
{
   public class ConsultasLogin:ConexionDB
    {
        public int Acceso(Login login)
        {
            int existe = 0;

            string consulta = "select permiso from login where nombre_usuario='" + login.nombre_usuario + "' and contraseña='" + login.contraseña + "'";

            SqlCommand command = new SqlCommand(consulta, Conetar());
            SqlDataReader leer = command.ExecuteReader();

            if (leer.Read() == true)
            {
                existe = int.Parse(leer["permiso"].ToString());
            }


            return existe;


        }

    }
}
