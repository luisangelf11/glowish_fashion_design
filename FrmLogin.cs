using Glowish_Fashion_System.Notifications;
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
            this.Opacity = 0;
            timer1.Start();
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

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            if(txtbUsaurio.Text != "" && txtbClave.Text != "")
            {
                this.Hide();
                FrmWelcome welcome = new FrmWelcome(txtbUsaurio.Text);
                welcome.ShowDialog();
                FrmMenu menu = new FrmMenu();
                menu.Show();
                menu.FormClosed += CloseForm;
            }
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            txtbClave.Text = "";
            txtbUsaurio.Text = "";
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(this.Opacity < 1) this.Opacity += 0.05;
            if (this.Opacity == 1) timer1.Stop();
        }
    }
}
