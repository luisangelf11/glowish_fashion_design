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
    }
}
