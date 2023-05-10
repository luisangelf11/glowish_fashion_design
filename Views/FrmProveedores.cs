using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Glowish_Fashion_System.Views
{
    public partial class FrmProveedores : Form
    {
        
        public FrmProveedores()
        {
            InitializeComponent();
            AgregarDTG();
        }

        public void AgregarDTG()
        {
            
            datagridProveedores.Rows.Add("01", "Ricardo Cruz", "AExpress", "Cuba", "Habana", "RicardoC@aexpress.com", "902-900-4478", "AExpress.inc");
            datagridProveedores.Rows.Add("02", "Elena Garza", "ALZAT", "México", "Oaxaca", "ElenaGarza04@gmail.com", "052-32323-4579","MexPort");



        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
           
            
            rellenogirdview.FillColor = datagridProveedores.ColumnHeadersDefaultCellStyle.BackColor;
            
            Opacity = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1) Opacity += 0.05;
            if (Opacity == 1) timer1.Stop();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string searchTerm = txtbProveedor.Text.ToLower(); // Get the search term from the TextBox

            foreach (DataGridViewRow row in datagridProveedores.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {
                        datagridProveedores.ClearSelection();
                        cell.Selected = true; // Select the cell if it contains the search term
                        datagridProveedores.FirstDisplayedScrollingRowIndex = row.Index; // Scroll to the selected row
                        return;
                    }
                }
            }
        }

        private void txtbProveedor_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = true;
        }

        private void btnCancelarAndirProveedor_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = false;
        }

        private void btnGuardarproveedor_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = false;
        }
    }
}
