using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Empleados
{
    public partial class CargaEmpleados : Form
    {
        public CargaEmpleados()
        {
            InitializeComponent();
        }

        private void pbAbrirSexo_Click(object sender, EventArgs e)
        {
            if (panelSexo.Visible == false)
            {
                panelSexo.Visible = true;
            }
            else
            {
                panelSexo.Visible = false;
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            tbSexo.Texts = "M";
            panelSexo.Visible = false;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            tbSexo.Texts = "F";
            panelSexo.Visible = false;
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
    }
}
