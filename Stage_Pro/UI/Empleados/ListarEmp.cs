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

namespace UI.Empleados
{
    public partial class ListarEmp : Form
    {
        public ListarEmp()
        {
            InitializeComponent();
        }

        Negocio.NegocioEmpleados nEmp = new NegocioEmpleados();
        Entidades.Empleados emp = new Entidades.Empleados();
        private void ListarEmp_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }


        private string ActivoInactivo()
        {

            string activo;
            if (chbInactivos.Checked == true)
            {
                activo = "no";
            }
            else
            {
                activo = "si";
            }
            return activo;

        }

        private void cargarGrilla()
        {

         dgvEmp.DataSource = null;
         dgvEmp.DataSource= nEmp.ListarEmp(ActivoInactivo());
            dgvEmp.Columns[0].Width = 200;
            dgvEmp.Columns[1].Width = 200;
            dgvEmp.Columns[2].Width = 200;
            dgvEmp.Columns[3].Width = 200;

        }
        string dni="";
        int acciones=0;
        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dni = dgvEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            acciones = 1;
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            acciones = 2;
            if (dni == "")
            {
                MensajeOk mensaje = new MensajeOk();
                mensaje.lblMensaje.Text = "Seleccione un empleado";
                mensaje.Show();
                return;
            }
            LlenarCampos();
            inputHabilitados();
            
            panelDatosPersonales.Visible = true;
          


        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            acciones = 3;
            if (dni == "")
            {
                MensajeOk mensaje = new MensajeOk();
                mensaje.lblMensaje.Text = "Seleccione un empleado";
                mensaje.Show();
                return;
            }
            LlenarCampos();
            inputDesHabilitado();
        
            
            panelDatosPersonales.Visible = true;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dni == "")
            {
                MensajeOk mensaje = new MensajeOk();
                mensaje.lblMensaje.Text = "Seleccione un empleado";
                mensaje.Show();
            }
        }

        private void LlenarCampos()
        {


            emp.dni = dni;

            foreach(DataRow obj in nEmp.empleados(emp,ActivoInactivo()).Rows)
            {

                DateTime fechaN= DateTime.Parse(obj["fecha_de_nacimiento"].ToString());
                DateTime fechaI= DateTime.Parse(obj["fecha_de_ingreso"].ToString());

                tbDni.Text = obj["dni"].ToString();
                tbNombre.Text = obj["nombre"].ToString();
                tbApellido.Text = obj["apellido"].ToString();
                tbSexo1.Text = obj["sexo"].ToString();
                tbFechaN.Text = fechaN.ToString("dd/MM/yyyy");
                tbPuesto.Text = obj["puesto"].ToString();
                tbFechai.Text = fechaI.ToString("dd/MM/yyyy");
                tbPreDep.Text = obj["valor_dia_deposito"].ToString();
                tbPreEve.Text = obj["valor_dia_evento"].ToString();


            }

            
        }


        private void inputHabilitados()
        {
            tbDni.Enabled = true;
            tbNombre.Enabled = true;
            tbApellido.Enabled = true;
            tbSexo1.Enabled = true;
            tbSexo.Enabled = true;
            tbFechaN.Enabled = true;
            tbPuesto.Enabled = true;
            tbFechai.Enabled = true;
            tbPreDep.Enabled = true;
            tbPreEve.Enabled = true;
            pbAbrirCal.Enabled = true;
            pbCal2.Enabled = true;


        }

        private void inputDesHabilitado()
        {
            tbDni.Enabled = false;
            tbNombre.Enabled = false;
            tbApellido.Enabled = false;
            tbSexo1.Enabled = false;
            tbSexo.Enabled = false;
            tbFechaN.Enabled = false;
            tbPuesto.Enabled = false;
            tbFechai.Enabled = false;
            tbPreDep.Enabled = false;
            tbPreEve.Enabled = false;
            pbAbrirCal.Enabled = false;
            pbCal2.Enabled = false;
        }

        private void tbSexo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            tbSexo1.Text = tbSexo.SelectedItem.ToString();
        }

        private void pbAbrirCal_Click(object sender, EventArgs e)
        {
            if (fNac.Visible == false)
            {
                fNac.Visible = true;
            }
            else
            {
                fNac.Visible = false;
            }
        }

        private void pbCal2_Click(object sender, EventArgs e)
        {
            if (fIng.Visible == false)
            {
                fIng.Visible = true;
            }
            else
            {
                fIng.Visible = false;
            }
        }

        private void fNac_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fecha = fNac.SelectionStart;

            tbFechaN.Text = fecha.ToString("dd/MM/yyyy");
            fNac.Visible = false;
        }

        private void fIng_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fecha = fIng.SelectionStart;
            tbFechai.Text = fecha.ToString("dd/MM/yyyy");
            fIng.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelDatosPersonales.Visible = false;
            p1.Visible = true;
            pDir.Visible = false;
            pTel.Visible = false;
            pUser.Visible = false;
            paso1.BackColor = Color.FromArgb(69, 172, 234);
            paso2.BackColor = Color.FromArgb(3, 109, 193);
            paso3.BackColor = Color.FromArgb(3, 109, 193);
            paso4.BackColor = Color.FromArgb(3, 109, 193);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
        }

        private void paso1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void paso1_Click(object sender, EventArgs e)
        {
            paso1.BackColor = Color.FromArgb(69, 172, 234);
            paso2.BackColor = Color.FromArgb(3, 109, 193);
            paso3.BackColor = Color.FromArgb(3, 109, 193);
            paso4.BackColor = Color.FromArgb(3, 109, 193);

            p1.Visible = true;
            pDir.Visible = false;
            pTel.Visible = false;
            pUser.Visible = false;
            btnAtras.Visible = false;
        }

        private void paso2_Click(object sender, EventArgs e)
        {
            paso2.BackColor = Color.FromArgb(69, 172, 234);
            paso1.BackColor = Color.FromArgb(3, 109, 193);
            paso3.BackColor = Color.FromArgb(3, 109, 193);
            paso4.BackColor = Color.FromArgb(3, 109, 193);

            p1.Visible = false;
            pDir.Visible = true;
            pTel.Visible = false;
            pUser.Visible = false;
            btnAtras.Visible = true;


        }

        private void paso3_Click(object sender, EventArgs e)
        {
            paso3.BackColor = Color.FromArgb(69, 172, 234);
            paso2.BackColor = Color.FromArgb(3, 109, 193);
            paso1.BackColor = Color.FromArgb(3, 109, 193);
            paso4.BackColor = Color.FromArgb(3, 109, 193);

            p1.Visible = false;
            pDir.Visible = false;
            pTel.Visible = true;
            pUser.Visible = false;
            btnAtras.Visible = true;

        }

        private void paso4_Click(object sender, EventArgs e)
        {
            paso4.BackColor = Color.FromArgb(69, 172, 234);
            paso2.BackColor = Color.FromArgb(3, 109, 193);
            paso3.BackColor = Color.FromArgb(3, 109, 193);
            paso1.BackColor = Color.FromArgb(3, 109, 193);
            p1.Visible = false;
            pDir.Visible = false;
            pTel.Visible = false;
            pUser.Visible = true;
            btnAtras.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (tbClave.UseSystemPasswordChar == true)
            {
                tbClave.UseSystemPasswordChar = false;
            }
            else
            {
                tbClave.UseSystemPasswordChar = true;
            }
        }
    }
}
