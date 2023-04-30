using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glowish_Fashion_System
{
    public partial class FrmLogin : Form
    {
        

        public FrmLogin()
        {
             InitializeComponent();
        }

        private void gbtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Ayuda fayuda = new Ayuda();
            fayuda.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void txtbUsaurio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
