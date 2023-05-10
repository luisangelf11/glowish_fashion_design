using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glowish_Fashion_System.Notifications
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
           
            

        }
        
        int r = 255;
        int g = 255;
        int b = 255;
        int step = 5;
        
        private void Loader_Load(object sender, EventArgs e)
        {
            btnBienvenido.ForeColor = Color.FromArgb(r,g, b);
            btnBienvenido.FillColor = Color.Transparent;
            timer1.Interval = 50; 

            timer1.Start();
            this.Opacity = 0;
            timer2.Start();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r = Math.Max(0, r - step);
            g = Math.Max(0, g - step);
            b = Math.Max(0, b - step);

            // actualiza el color de fondo del formulario
            btnBienvenido.ForeColor = Color.FromArgb(r, g, b);
            btnBienvenido.FillColor = Color.Transparent;


            // detiene el temporizador si se ha alcanzado el negro
            if (r == 0 && g == 0 && b == 0)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            if (this.Opacity == 1) timer2.Stop();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
