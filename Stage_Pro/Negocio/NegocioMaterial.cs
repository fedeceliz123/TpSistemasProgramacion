using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;

namespace Negocio
{
    public class NegocioMaterial
    {
        Datos.Consulta_Matrial.ConsultaMaterial Mat = new Datos.Consulta_Matrial.ConsultaMaterial();
        public DataTable LlenarTipo()
        {
            return Mat.LlenarTipo();
        }


        public DataTable LlenarModelo(int tipo)
        {
            return Mat.LlenarModelo(tipo);
        }

        public string Ultimo(int tipo ,int modelo)
        {
            return Mat.Ultimo(tipo,modelo);
        }

    }
}
