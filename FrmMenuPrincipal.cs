using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Glowish_Fashion_System
{
    public partial class FrmMenuPrincipal : Form
    {

        public void generategraphic()
        {
            
        }


        public FrmMenuPrincipal()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Start();
            generategraphic();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            if (this.Opacity == 1) timer1.Stop();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {

        }
    }
}
