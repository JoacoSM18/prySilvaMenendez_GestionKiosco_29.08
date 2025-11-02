using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;

namespace prySilvaMenendez_EjercicioSemana2
{
    public partial class frmGestionKiosco : Form
    {
        public frmGestionKiosco()
        {
            InitializeComponent();
        }

        int indice = 0;
        struct Producto
        {
            public int codigo;
            public string nombre;
        }
        Producto [] vecProductos = new Producto [100];
        private void frmGestionKiosco_Load(object sender, EventArgs e)
        {
            lblAgregado.Visible = false;
            mskNuevoCodigo.Visible = false;
            lblAgregado2.Visible = false;
            txtNuevoNombre.Visible = false;
            lblAgregado.Enabled = false;
            mskNuevoCodigo.Enabled = false;
            lblAgregado2.Enabled = false;
            txtNuevoNombre.Enabled = false;
        }
        private void btnAgregar_CheckedChanged(object sender, EventArgs e)
        {
            lblAgregado.Enabled = false;
            mskNuevoCodigo.Enabled = false;
            lblAgregado2.Enabled = false;
            txtNuevoNombre.Enabled = false;
        }
        private void btnEliminar_CheckedChanged(object sender, EventArgs e)
        {
            lblAgregado.Enabled = false;
            mskNuevoCodigo.Enabled = false;
            lblAgregado2.Enabled = false;
            txtNuevoNombre.Enabled = false;
        }
        private void btnModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (btnModificar.Checked)
            {
                lblAgregado.Visible = true;
                mskNuevoCodigo.Visible = true;
                lblAgregado2.Visible = true;
                txtNuevoNombre.Visible = true;
                lblAgregado.Enabled = true;
                mskNuevoCodigo.Enabled = true;
                lblAgregado2.Enabled = true;
                txtNuevoNombre.Enabled = true;
            }
            else
            {
                lblAgregado.Enabled = false;
                mskNuevoCodigo.Enabled = false;
                lblAgregado2.Enabled = false;
                txtNuevoNombre.Enabled = false;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Checked)
            {
                if (txtNombre.Text == "" || mskCodigo.Text == "")
                {
                    MessageBox.Show("Por Favor Complete Todos Los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    vecProductos[indice].codigo =  Convert.ToInt32 (mskCodigo.Text);
                    vecProductos[indice].nombre = txtNombre.Text;
                    MessageBox.Show("Producto Agregado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (btnEliminar.Checked)
            {
                if (txtNombre.Text == "" || mskCodigo.Text == "")
                {
                    MessageBox.Show("Por Favor Complete Todos Los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Producto Eliminado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (btnModificar.Checked)
            {

                if (txtNombre.Text == "" || mskCodigo.Text == "" || mskNuevoCodigo.Text == "" || txtNuevoNombre.Text == "")
                {
                    MessageBox.Show("Por Favor Complete Todos Los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Producto Editado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void mskCodigo_Click(object sender, EventArgs e)
        {
            mskCodigo.Select(0, 0);
        }

        private void mskNuevoCodigo_Click(object sender, EventArgs e)
        {
            mskNuevoCodigo.Select(0, 0);
        }
    }
}

