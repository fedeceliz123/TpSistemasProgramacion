using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Datos;

namespace Negocio
{
   public class NegocioEmpleados
    {
        Datos.Consulta_Empledos.ConsultaEmpleados emp = new Datos.Consulta_Empledos.ConsultaEmpleados();
       

        public DataTable empleados(Empleados empleados)
        {


            return emp.LEmpleaos(empleados);


        }

        public DataTable telefonoE(Empleados empleados)
        {
            return emp.telEmpleados(empleados);
        }
        public DataTable direccionE(Empleados empleados)
        {
            return emp.dirEmpleados(empleados);
        }
        public DataTable mailE(Empleados empleados)
        {
            return emp.mailEmpleados(empleados);
        }

    }
}
