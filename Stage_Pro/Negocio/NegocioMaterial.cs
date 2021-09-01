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
        public DataTable LlenarMedida(int tipo)
        {
            return Mat.LlenarMedida(tipo);
        }

        public string Ultimo(int tipo ,int modelo)
        {
            return Mat.Ultimo(tipo,modelo);
        }

        public int UltimoModelo(int tipo)
        {
            return Mat.UltimoModelo(tipo);
        }

        public void CargaModelo(int tipo,string modelo)
        {
            Mat.CargaModelo(tipo,modelo);
        }

        public void CargaTipo(string tipo)
        {
            Mat.CargaTipo(tipo);
        }

        public void CargaMedida(int tipo,string medida)
        {
            Mat.CargaMedida(tipo,medida);
        }

        public void CargarMaterial(Material material)
        {
          
            Mat.CargaMaterial(material);

            
        }

    }
}
