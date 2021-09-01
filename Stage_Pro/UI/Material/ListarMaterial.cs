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
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;

namespace UI.Material
{
    public partial class ListarMaterial : Form
    {
        public ListarMaterial()
        {
            InitializeComponent();
        }


        Entidades.Material mat = new Entidades.Material();
        private void CrearQR()
        {
            QrEncoder qr = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode code = new QrCode();
            qr.TryEncode(tbCodigo.Text,out code);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize( 400,QuietZoneModules.Zero),Brushes.Black,Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(code.Matrix, System.Drawing.Imaging.ImageFormat.Png, ms);
            var imagenTemp = new Bitmap(ms);
            var imagen = new Bitmap(imagenTemp, new Size(new Point(200, 200)));
            pbQR.Image = imagen;

            if (tbCodigo.Text.Length == 0)
            {
                pbQR.Image = UI.Properties.Resources.qr;
            }


        }

        Negocio.NegocioMaterial nMat = new NegocioMaterial(); 
        private void ListarMaterial_Load(object sender, EventArgs e)
        {
            
            cbTipo.DataSource = null;
            cbTipo.DataSource = nMat.LlenarTipo();
            cbTipo.DisplayMember = "Tipo";
            cbTipo.ValueMember = "id";


        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            pStock.Visible = false;
            pDisp.Visible = false;
            lblDisp.Visible = false;
            lblStock.Visible = false;

            panelDatosPersonales.Visible = true;
            Habilitar();
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

            cbModelo.DataSource = null;
            cbModelo.DataSource = nMat.LlenarModelo(tipo);
            cbModelo.DisplayMember = "modelo";
            cbModelo.ValueMember = "id";

            cbMedida.DataSource = null;
            cbMedida.DataSource = nMat.LlenarMedida(tipo);
            cbMedida.DisplayMember = "medida";
            cbMedida.ValueMember = "id";

            pbModelo.Enabled = true;
            pbMedida.Enabled = true;


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

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            CrearQR();
        }

        int agregar = 0;

        private void pbTipo_Click(object sender, EventArgs e)
        {
            agregar = 1;

            tbNuevoCampo.Text = "";
            pNuevo.Visible = true;
            lblCarga.Text = "Ingrese el nombre del nuevo tipo:";
            lblCarga.Visible = true;
            btnAceptar2.Visible = true;
            btnCancelar2.Visible = true;
        }

        private void pbModelo_Click(object sender, EventArgs e)
        {
            agregar = 2;
            tbNuevoCampo.Text = "";
            pNuevo.Visible = true;
            lblCarga.Text = "Ingrese el nombre del nuevo modelo:";
            lblCarga.Visible = true;
            btnAceptar2.Visible = true;
            btnCancelar2.Visible = true;

        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            if (agregar == 1)
            {
                nMat.CargaTipo(tbNuevoCampo.Text);
            }
            else if (agregar == 2)
            {
                nMat.CargaModelo(tipo, tbNuevoCampo.Text);
            }
            else if (agregar == 3)
            {
                nMat.CargaMedida(tipo, tbNuevoCampo.Text);
            }

            pNuevo.Visible = false;
            lblCarga.Text = "";
            lblCarga.Visible = false;

            btnAceptar2.Visible = false;
            btnCancelar2.Visible = false;

            agregar = 0;
            pbModelo.Enabled = pbModelo.Enabled = true;
            pbMedida.Enabled = false; 
            pbMedida.Enabled = false;

            cbTipo.DataSource = null;
            cbTipo.DataSource = nMat.LlenarTipo();
            cbTipo.DisplayMember = "Tipo";
            cbTipo.ValueMember = "id";
            cbModelo.DataSource = null;
            cbMedida.DataSource = null;
            cbMedida.Enabled = false;
            cbModelo.Enabled = false;

        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {

            pNuevo.Visible = false;
            lblCarga.Text = "";
            lblCarga.Visible = false;

            btnAceptar2.Visible = false;
            btnCancelar2.Visible = false;
            agregar = 0;
            pbModelo.Enabled = false;
            pbMedida.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            pStock.Visible = true;
            pDisp.Visible = true;
            lblDisp.Visible = true;
            lblStock.Visible = true;
            panelDatosPersonales.Visible = true;
            Habilitar();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            pStock.Visible = true;
            pDisp.Visible = true;
            lblDisp.Visible = true;
            lblStock.Visible = true;
            panelDatosPersonales.Visible = true;
            Deshabilitar();

        }


        private void Habilitar()
        {
            cbModelo.Enabled = true;
            cbTipo.Enabled = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
          
            tbNombre.Enabled = true;
            tbStock.Enabled = true;
            tbDisp.Enabled = true;
        }
        private void Deshabilitar()
        {
            cbModelo.Enabled = false;
            cbTipo.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
          
            tbNombre.Enabled = false;
            tbStock.Enabled = false;
            tbDisp.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (cbMedida.DroppedDown == false)
            {
                cbMedida.DroppedDown = true;
            }
            else
            {
                cbMedida.DroppedDown = false;
            }

        }

        private void pbMedida_Click(object sender, EventArgs e)
        {
            agregar = 3;
            tbNuevoCampo.Text = "";
            pNuevo.Visible = true;
            lblCarga.Text = "Ingrese la medida:";
            lblCarga.Visible = true;
            btnAceptar2.Visible = true;
            btnCancelar2.Visible = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            LlenarEntidad();

            nMat.CargarMaterial(mat);


        }

        private void LlenarEntidad()
        {
            mat.tipo = int.Parse(cbTipo.SelectedValue.ToString());
            mat.modelo = int.Parse(cbModelo.SelectedValue.ToString());
            mat.medida = int.Parse(cbMedida.SelectedValue.ToString());
            mat.numero = numero;
            mat.codigo = tbCodigo.Text;
            mat.nombre = tbNombre.Text;
            if (tbStock.Text != "")
            {
            mat.stock_general =int.Parse( tbStock.Text);

            }
            if (tbDisp.Text != "")
            {
            mat.disponobilidad = int.Parse(tbDisp.Text);

            }
            // pasar imagen
            MemoryStream MS = new System.IO.MemoryStream();
            
            pbQR.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);

            mat.codigo_qr = MS;
            limpiar();

        }

        private void limpiar()
        {
            tbCodigo.Text = "";
            tbDisp.Text = "";
            tbStock.Text = "";
            tbNombre.Text = "";
            cbMedida.DataSource = null;
            cbModelo.DataSource = null;
            cbModelo.Enabled = false;
            cbMedida.Enabled = false;


        }
    }
}
