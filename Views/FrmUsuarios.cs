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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cbRol.SelectedIndex = 0;
            panelAnadirProveedor.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = true;
        }

        private void btnCancelarAndirProveedor_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = false;
            lblTitle.Text = "Añadir un Usuario";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = true;
            lblTitle.Text = "Editar un Usuario";
        }
    }
}
