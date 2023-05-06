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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void generateGrafic()
        {
            string[] series = { "Blusa (0001)", "Pantalon de pinza (1012)", "Traje de baño (1245)", "Abrigo de piel (4789)", "Chaqueta (4780)" };
            int[] puntos = { 100, 50, 35, 250, 45};

            chartVentas.Palette = ChartColorPalette.SemiTransparent;

            chartVentas.Titles.Add("Unidades Vendidas");

            for(int i =0; i < series.Length; i++)
            {
                Series s = chartVentas.Series.Add(series[i]);
                s.Points.Add(puntos[i]);
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Start();
            generateGrafic();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            //else if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartVentas_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
