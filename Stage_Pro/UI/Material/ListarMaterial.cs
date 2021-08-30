using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace UI.Material
{
    public partial class ListarMaterial : Form
    {
        public ListarMaterial()
        {
            InitializeComponent();
        }

        Negocio.NegocioMaterial nMat = new NegocioMaterial(); 
        private void ListarMaterial_Load(object sender, EventArgs e)
        {
            cbTipo.DataSource = nMat.LlenarTipo();
            cbTipo.DisplayMember = "Tipo";
            cbTipo.ValueMember = "id";


        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            panelDatosPersonales.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           if(cbTipo.DroppedDown == false)
            {
                cbTipo.DroppedDown = true;
            }
            else
            {
                cbTipo.DroppedDown = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (cbModelo.DroppedDown == false)
            {
                cbModelo.DroppedDown = true;
            }
            else
            {
                cbModelo.DroppedDown = false;
            }
        }
        int tipo;
      

        private void cbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tipo = int.Parse(cbTipo.SelectedValue.ToString());

            cbModelo.DataSource = nMat.LlenarModelo(tipo);
            cbModelo.DisplayMember = "modelo";
            cbModelo.ValueMember = "id";

        }

        int modelo;
        int numero;
        string codigo;
        private void cbModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            modelo = int.Parse(cbModelo.SelectedValue.ToString());
            if (nMat.Ultimo(tipo, modelo) != "")
            {
            numero = int.Parse(nMat.Ultimo(tipo, modelo));

            }
            else
            {
                numero = 1;
            }

            if (tipo < 10)
            {
                codigo = "0" + tipo.ToString();
            }
            else
            {
                codigo = tipo.ToString();
            }
            if (modelo < 10)
            {
                codigo = codigo + "0" + modelo.ToString();
            }
            else
            {
                codigo = codigo + modelo.ToString();
            }

            
            if (numero < 10)
            {
                codigo = codigo + "0" + numero.ToString();
            }
            else
            {
                codigo = codigo + numero;
            }

            tbCodigo.Text = codigo;


        }
    }
}
