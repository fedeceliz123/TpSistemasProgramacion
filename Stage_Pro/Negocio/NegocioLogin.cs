using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NegocioLogin
    {
        Datos.Consultas_Login.ConsultasLogin conLog = new Datos.Consultas_Login.ConsultasLogin();
        public int ingresar(Login login)
        {

            return conLog.Acceso(login);

        }
    }
}
