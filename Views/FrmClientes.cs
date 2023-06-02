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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = true;
            lblTitle.Text = "Editar un Cliente";
        }

        private void btnCancelarAndirProveedor_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = false;
            lblTitle.Text = "Añadir un Cliente";
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = false;
        }

        private void txtbProvCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtbProvCedula.Text.Length >= 13)
            {
                // Ignorar la tecla presionada si se ha alcanzado el límite
                e.Handled = true;
            }
        }

        private void txtbProvCedula_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtbProvCedula_KeyUp_1(object sender, KeyEventArgs e)
        {

        }

        private void txtbProvCedula_TextChanged(object sender, EventArgs e)
        {
            if (txtbProvCedula.Text.Length == 3 || txtbProvCedula.Text.Length == 11 )
            {
                txtbProvCedula.Text += '-';
                txtbProvCedula.SelectionStart = txtbProvCedula.Text.Length;
            }
            
        }
    }
}
