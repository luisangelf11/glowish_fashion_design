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
    public partial class FrmWelcome : Form
    {
        public FrmWelcome(string user)
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar.Value += 1;
            if(progressBar.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 1;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }
    }
}
