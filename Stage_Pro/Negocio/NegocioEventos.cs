using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Negocio
{
    


    public class NegocioEventos
    {
        Eventos even = new Eventos();
        Datos.ConsultaEventos.ConsultasEventos cEven = new Datos.ConsultaEventos.ConsultasEventos();

        public void CargarEvento(Eventos even)
        {
            cEven.CargarEvento(even);
        }
        public DataTable ListarEventos(string activo)
        {
            return cEven.ListarEventos(activo);
        }

        public DataTable CargarClientes()
        {
            return cEven.CargarClientes();
        }
        public DataTable CargarEmpleados()
        {
            return cEven.CargarEmpleados();
        }


    }
}
