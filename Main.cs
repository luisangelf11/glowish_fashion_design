﻿using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

      

        private void btnAbrirLogin_Click(object sender, EventArgs e)
        {
            FrmLogin flogin = new FrmLogin();
            flogin.Show();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            FrmAyuda fayuda = new FrmAyuda();
            fayuda.Show();
        }
    }
}
