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
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }


        private void AddDataExample()
        {
            datagridFacturas.Rows.Add("01", "14567", "Crop Top", "2", "2500", "5000");
            datagridFacturas.Rows.Add("02", "14447", "Pantalon", "2", "2000", "4000");
            datagridFacturas.Rows.Add("03", "14567", "Chaqueta", "1", "1500", "1500");
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            AddDataExample();
        }
    }
}
