using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace UI.Empleados
{
    public partial class ListarEmpleados : Form
    {
        Entidades.Empleados empleados = new Entidades.Empleados();
        Negocio.NegocioEmpleados nEmp = new NegocioEmpleados();
        public ListarEmpleados()
        {
            InitializeComponent();
        }

        private void ListarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            empleados.dni = tbBuscar.Texts;

            dgvEmp.DataSource = null;
            dgvEmp.DataSource= nEmp.empleados(empleados);

            dgvEmp.Columns[6].Visible = false;
            dgvEmp.Columns[7].Visible = false;
            dgvEmp.Columns[8].Visible = false;
            dgvEmp.Columns[9].Visible = false;
            dgvEmp.Columns[10].Visible = false;
            dgvEmp.Columns[11].Visible = false;


            dgvDir.DataSource = null;
            dgvDir.DataSource = nEmp.direccionE(empleados);
            dgvDir.Columns[0].Visible = false;
            dgvDir.Columns[1].Visible = false;

            dgvMail.DataSource = null;
            dgvMail.DataSource = nEmp.mailE(empleados);
            dgvMail.Columns[0].Visible = false;
            dgvMail.Columns[1].Visible = false;

            dgvTel.DataSource = null;
            dgvTel.DataSource = nEmp.telefonoE(empleados);
            dgvTel.Columns[0].Visible = false;
            dgvTel.Columns[1].Visible = false;
        }
    }
}
