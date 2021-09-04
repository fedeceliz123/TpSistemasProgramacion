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


namespace UI.Eventos
{
    public partial class ListarEventos : Form
    {
        public ListarEventos()
        {
            InitializeComponent();
        }

        Negocio.NegocioEventos nEven = new NegocioEventos();
        Entidades.Eventos eve = new Entidades.Eventos();

        int accion = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dtpFechaI.Focus();
            SendKeys.Send("{F4}");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            accion = 1;
            HabilitarCampo();
            panelDatosPersonales.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            dtpFechaF.Focus();
            SendKeys.Send("{F4}");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (cbEncargado.DroppedDown == false)
            {
                cbEncargado.DroppedDown = true;
            }
            else
            {
                cbEncargado.DroppedDown = false;
            }

            cbEncargado.DataSource = null;
            cbEncargado.DataSource = nEven.CargarEmpleados();
            cbEncargado.ValueMember = "dni";
            cbEncargado.DisplayMember = "empleado";


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (cbCliente.DroppedDown == false)
            {
                cbCliente.DroppedDown = true;
            }
            else
            {
                cbCliente.DroppedDown = false;
            }


            cbCliente.DataSource = null;
            cbCliente.DataSource = nEven.CargarClientes();
            cbCliente.ValueMember = "dni";
            cbCliente.DisplayMember = "cliente";
        }

        private void pbModelo_Click(object sender, EventArgs e)
        {
            Empleados.ListarEmp Emp = new Empleados.ListarEmp();

            Emp.pbX.Visible = true;

            Emp.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Clientes.ListarClientes Cli = new Clientes.ListarClientes();
            Cli.pbX.Visible = true;
            Cli.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = 2;
            HabilitarCampo();
            panelDatosPersonales.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (accion == 1)
            {
                CargarEntidad();
                nEven.CargarEvento(eve);
            }
                CargarGrilla(nEven.ListarEventos(activo));
        }

        string activo = "si";
        private void CargarEntidad()
        {
            eve.lugar = tbLugar.Text;
            eve.hora_inicio = tbHora.Text;
            eve.total = int.Parse(tbTotal.Text);
            eve.detalle = tbDetalle.Text;
            eve.encargado = cbEncargado.SelectedValue.ToString();
            eve.id_cliente = cbCliente.SelectedValue.ToString();
            eve.fecha_inicio = dtpFechaI.Value.ToString();
            eve.fecha_fin = dtpFechaF.Value.ToString();

        }

        private void CargarGrilla(DataTable dt)
        {
            dgvEmp.DataSource = null;
            dgvEmp.DataSource = dt;
            dgvEmp.Columns[0].Visible = false;
            dgvEmp.Columns[1].Width = 250;
            dgvEmp.Columns[2].Width = 150;
            dgvEmp.Columns[3].Width = 150;
            dgvEmp.Columns[4].Width = 250;


        }

        private void ListarEventos_Load(object sender, EventArgs e)
        {
            CargarGrilla(nEven.ListarEventos(activo));
        }

        private void HabilitarCampo()
        {
            tbLugar.Enabled = true;
            tbHora.Enabled = true;
            tbTotal.Enabled = true;
            tbDetalle.Enabled = true;
            cbEncargado.Enabled = true;
            cbCliente.Enabled = true;
            dtpFechaF.Enabled = true;
            dtpFechaI.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox5.Enabled = true;
            pbCli.Enabled = true;
            pbEnc.Enabled = true;
        }
        private void DeshabilitarCampo()
        {
            tbLugar.Enabled = false;
            tbHora.Enabled = false;
            tbTotal.Enabled = false;
            tbDetalle.Enabled = false;
            cbEncargado.Enabled = false;
            cbCliente.Enabled = false;
            dtpFechaF.Enabled = false;
            dtpFechaI.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox5.Enabled = false;
            pbCli.Enabled = false;
            pbEnc.Enabled = false;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            DeshabilitarCampo();
            panelDatosPersonales.Visible = true;

        }
        int id;
        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvEmp.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
