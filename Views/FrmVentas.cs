using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glowish_Fashion_System.Views
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = true;
        }

        private void btnCancelarAndirProveedor_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnNuevaFactura.Enabled = true;
            panelAnadirProveedor.Visible = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = true;
            lblTitle.Text = "Editar una venta";
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = false;
            btnAgregar.Enabled = false;
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnNuevaFactura.Enabled = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnNuevaFactura.Enabled = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = false;
            lblTitle.Text = "Añadir una venta";
        }

        private void txtbCedulaCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtbCedulaCliente.Text.Length == 3)
            {
                txtbCedulaCliente.Text += "-";
                txtbCedulaCliente.SelectionStart = txtbCedulaCliente.Text.Length;
            }
            else if (txtbCedulaCliente.Text.Length == 12)
            {
                txtbCedulaCliente.Text += "-";
                txtbCedulaCliente.SelectionStart = txtbCedulaCliente.Text.Length;
            }
        }

        private void txtbCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Verificar si ya se alcanzó el número máximo de caracteres
            if (txtbCedulaCliente.Text.Length >= 14 && e.KeyChar != '\b') // '\b' representa la tecla de retroceso
            {
                e.Handled = true;
            }
        }
    }
}
