using LiveCharts.Wpf;
using LiveCharts;
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
using System.Windows.Media;



namespace Glowish_Fashion_System
{
    public partial class FrmMenuPrincipal : Form
    {

        public void generategraphic()
        {
            LineSeries series1 = new LineSeries
            {
                Title = "Ventas",
                Values = new ChartValues<double> { 10, 60, 30, 50, 30, 100 },
                LineSmoothness = 1.0,
                PointGeometrySize = 10,
                PointForeground = System.Windows.Media.Brushes.Crimson
            };
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis { Labels = new[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo","Junio" } });
            cartesianChart1.Series.Add(series1);

            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis { Title = "Fecha" });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis { Title = "Ventas" });
            
            
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

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Minimizarbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Ayuda fayuda = new Ayuda();

            fayuda.ShowDialog();
        }

        private void guna2HtmlLabel9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
