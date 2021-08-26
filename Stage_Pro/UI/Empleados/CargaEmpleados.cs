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
    public partial class CargaEmpleados : Form
    {
        Entidades.Empleados empleados = new Entidades.Empleados();
        Negocio.NegocioEmpleados nEmp = new NegocioEmpleados();
        public CargaEmpleados()
        {
            InitializeComponent();
        }

       

        private void pbAbrirCal_Click(object sender, EventArgs e)
        {
            if (calendario.Visible == false)
            {
                calendario.Visible = true;
            }
            else
            {
                calendario.Visible = false;
            }
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            tbFecha.Texts = calendario.SelectionStart.ToString("dd/MM/yyyy");
            calendario.Visible = false;
        }

        private void pbCal2_Click(object sender, EventArgs e)
        {
            if (calendario2.Visible == false)
            {
                calendario2.Visible = true;

            }
            else
            {
                calendario2.Visible = false;
            }
        }

        private void calendario2_DateSelected(object sender, DateRangeEventArgs e)
        {
            tbFechaIng.Texts= calendario2.SelectionStart.ToString("dd/MM/yyyy");
            calendario2.Visible = false;
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarimagen = new OpenFileDialog();
            //buscarimagen.Filter = "Archivos de imagen|*.png";

            buscarimagen.InitialDirectory = "C:\\";

            if (buscarimagen.ShowDialog() == DialogResult.OK)
            {
                
                rjCircularPictureBox1.ImageLocation = buscarimagen.FileName;
                rjCircularPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargaEmpleados_Load(object sender, EventArgs e)
        {
            ComboSexo.SelectedIndex = 0;
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            empleados.dni = tbDni.Texts;

            dgvEmp.DataSource = null;
            dgvEmp.DataSource = nEmp.empleados(empleados);

            empdgv();

            
            
        }

        private void empdgv()
        {


            dgvEmp.Columns[3].Visible = false;
            dgvEmp.Columns[4].Visible = false;
            dgvEmp.Columns[5].Visible = false;

            dgvEmp.Columns[6].Visible = false;
            dgvEmp.Columns[7].Visible = false;
            dgvEmp.Columns[8].Visible = false;
            dgvEmp.Columns[9].Visible = false;
            dgvEmp.Columns[10].Visible = false;
            dgvEmp.Columns[11].Visible = false;

            dgvEmp.Columns[0].Width = 110;
            dgvEmp.Columns[1].Width = 110;
            dgvEmp.Columns[2].Width = 110;

        }

        private void dirdgv()
        {
            dgvDir.Columns[0].Visible = false;
            dgvDir.Columns[1].Visible = false;
            dgvDir.Columns[2].Visible = false;
            dgvDir.Columns[3].Visible = false;
            dgvDir.Columns[5].Visible = false;
            dgvDir.Columns[8].Visible = false;
            dgvDir.Columns[9].Visible = false;
            dgvDir.Columns[10].Visible = false;
            dgvDir.Columns[11].Visible = false;
            dgvDir.Columns[12].Visible = false;

            dgvDir.Columns[4].Width = 110;
            dgvDir.Columns[6].Width = 110;
            dgvDir.Columns[7].Width = 110;

        }

        private void teldgv()
        {
            dgvTel.Columns[0].Visible = false;
            dgvTel.Columns[1].Visible = false;

            dgvTel.Columns[2].Width = 165;
            dgvTel.Columns[3].Width = 165;
        }

        private void maildgv()
        {
            dgvMail.Columns[0].Visible = false;
            dgvMail.Columns[1].Visible = false;

            dgvMail.Columns[2].Width = 330;
        }


        private void cargarCamposEmplesdos(DataGridViewCellEventArgs e)
        {
            DateTime fn = DateTime.Parse(dgvEmp.Rows[e.RowIndex].Cells[4].Value.ToString());
            DateTime fe = DateTime.Parse(dgvEmp.Rows[e.RowIndex].Cells[6].Value.ToString());

            tbDni.Texts= dgvEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNombre.Texts = dgvEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbApellido.Texts = dgvEmp.Rows[e.RowIndex].Cells[2].Value.ToString();
            ComboSexo.Texts = dgvEmp.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbFecha.Texts = fn.ToString("dd/MM/yyyy");
            tbPuesto.Texts = dgvEmp.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbFechaIng.Texts = fe.ToString("dd/MM/yyyy");
            tbPreDep.Texts = dgvEmp.Rows[e.RowIndex].Cells[8].Value.ToString();
            tbPreEve.Texts = dgvEmp.Rows[e.RowIndex].Cells[9].Value.ToString();
           
           


        }

        string dni="";
        int idTel=0;
        int idDir=0;
        int idMail=0;
        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                dni= empleados.dni = dgvEmp.Rows[e.RowIndex].Cells[0].Value.ToString();

                dgvDir.DataSource = null;
                dgvDir.DataSource = nEmp.direccionE(empleados);

                dirdgv();

                dgvMail.DataSource = null;
                dgvMail.DataSource = nEmp.mailE(empleados);
                maildgv();

                dgvTel.DataSource = null;
                dgvTel.DataSource = nEmp.telefonoE(empleados);
                teldgv();

                cargarCamposEmplesdos(e);

            }
            catch
            {

            }
        }

        private void dgvDir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idDir=int.Parse(dgvDir.Rows[e.RowIndex].Cells[0].Value.ToString());

                tnPais.Texts = dgvDir.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbProvincia.Texts = dgvDir.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbLocalidad.Texts = dgvDir.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbCP.Texts = dgvDir.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbBarrio.Texts = dgvDir.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbCalle.Texts = dgvDir.Rows[e.RowIndex].Cells[7].Value.ToString();
                tbN.Texts = dgvDir.Rows[e.RowIndex].Cells[8].Value.ToString();
                tbPiso.Texts = dgvDir.Rows[e.RowIndex].Cells[9].Value.ToString();
                tbDpto.Texts = dgvDir.Rows[e.RowIndex].Cells[10].Value.ToString();
                tbManzana.Texts = dgvDir.Rows[e.RowIndex].Cells[11].Value.ToString();
                tbLote.Texts = dgvDir.Rows[e.RowIndex].Cells[12].Value.ToString();

            }
            catch
            {

            }
        }

        private void dgvTel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idTel = int.Parse(dgvTel.Rows[e.RowIndex].Cells[0].Value.ToString());




            }
            catch
            {

            }
        }

        private void dgvMail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idMail = int.Parse(dgvMail.Rows[e.RowIndex].Cells[0].Value.ToString());



            }
            catch
            {

            }
        }
    }
}
