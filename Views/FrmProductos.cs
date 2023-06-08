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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = true;
            lblTitle.Text = "Añadir un Producto";
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = false;
        }

        private void btnCancelarAndirProveedor_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = false;
            lblTitle.Text = "Añadir un Producto";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            panelAnadirProveedor.Visible = true;
            lblTitle.Text = "Editar un Producto";
        }
    }
}
