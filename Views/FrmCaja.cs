using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class FrmCaja : Form
    {
        public FrmCaja()
        {
            InitializeComponent();
        }

        public void generategraphic()
        {
            LineSeries series1 = new LineSeries
            {
                Title = "Entradas",
                Values = new ChartValues<double> { 100, 20, 3000, 150, 300, 100 },
                LineSmoothness = 1.0,
                PointGeometrySize = 10,
                PointForeground = System.Windows.Media.Brushes.Crimson
            };
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis { Labels = new[] { DateTime.Now.ToShortDateString()} });
            cartesianChart1.Series.Add(series1);

            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis { Title = "Fecha" });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis { Title = "Entradas" });


        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            generategraphic();
            Opacity = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1) Opacity += 0.05;
            if (Opacity == 1) timer1.Stop();
        }
    }
}
