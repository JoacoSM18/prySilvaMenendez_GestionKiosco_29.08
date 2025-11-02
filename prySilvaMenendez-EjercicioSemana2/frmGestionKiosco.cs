using System.Diagnostics.Eventing.Reader;

namespace prySilvaMenendez_EjercicioSemana2
{
    public partial class frmGestionKiosco : Form
    {
        public frmGestionKiosco()
        {
            InitializeComponent();
        }

        private void frmGestionKiosco_Load(object sender, EventArgs e)
        {
            lblAgregado.Visible = false;
            txtAgregado.Visible = false;
            lblAgregado.Enabled = false;
            txtAgregado.Enabled = false;
        }
        private void btnAgregar_CheckedChanged(object sender, EventArgs e)
        {
            lblAgregado.Enabled = false;
            txtAgregado.Enabled = false;
        }
        private void btnEliminar_CheckedChanged(object sender, EventArgs e)
        {
            lblAgregado.Enabled = false;
            txtAgregado.Enabled = false;
        }
        private void btnModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (btnModificar.Checked)
            {
                lblAgregado.Enabled = true;
                txtAgregado.Enabled = true;
                lblAgregado.Visible = true; 
                txtAgregado.Visible = true;
            }
            else
            {
                lblAgregado.Enabled = false;
                txtAgregado.Enabled = false;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Checked)
            {
                if (txtNombre.Text == "" || txtCodigo.Text == "")
                {
                    MessageBox.Show("Por Favor Complete Todos Los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Producto Agregado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (btnEliminar.Checked)
            {
                if (txtNombre.Text == "" || txtCodigo.Text == "")
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

                if (txtNombre.Text == "" || txtCodigo.Text == "" || txtAgregado.Text == "")
                {
                    MessageBox.Show("Por Favor Complete Todos Los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Producto Editado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

