using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glowish_Fashion_System.Notifications
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            if (this.Opacity == 1) timer2.Stop();
        }
        private void AbrirAplicacion(string rutaAplicacion)
        {
            try
            {
                Process.Start(rutaAplicacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la aplicación. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBlocNotas_Click(object sender, EventArgs e)
        {
            AbrirAplicacion("notepad.exe");
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            AbrirAplicacion("calc.exe");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            AbrirAplicacion("winword.exe");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            AbrirAplicacion("excel.exe");
        }
    }
}
