using Glowish_Fashion_System.ModeloFactura;
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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = true;
        }

        private void btnCancelarAndirProveedor_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnNuevaFactura.Enabled = true;
            panelAnadirProveedor.Visible = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = true;
            lblTitle.Text = "Editar una venta";
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = false;
            btnAgregar.Enabled = false;
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnNuevaFactura.Enabled = false;
        }
        private void GenerateTicket()
        {
            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

            Ticket1.TextoCentro("GLOWISH FASHION LV"); //imprime una linea de descripcion
            clsFactura.CreaTicket.LineasGuion();

            Ticket1.TextoIzquierda("Dirc: Calle 5 S/N, La Vega Rep.Dom.");
            Ticket1.TextoIzquierda("Tel: 829-915-7769");
            Ticket1.TextoIzquierda("Correo: GlowishFashion@hotmail.com");
            Ticket1.TextoIzquierda("Rnc: xxxx");
            Ticket1.TextoIzquierda("Cliente: " + "Luis Angel");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("FACTURA DE VENTA"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda($"Le Atendio: Maryelis Almonte");
            Ticket1.TextoIzquierda("");
            clsFactura.CreaTicket.LineasGuion();

            clsFactura.CreaTicket.EncabezadoVenta();
            clsFactura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in datagridProveedores.Rows)
            {
                string nombre = Convert.ToString(r.Cells[1].Value);
                double precio = Convert.ToDouble(r.Cells[3].Value);
                int cantidad = Convert.ToInt32(r.Cells[2].Value);
                double subtotal = Convert.ToDouble(r.Cells[4].Value);
                Ticket1.AgregaArticulo(nombre, precio, cantidad, subtotal);
            }

            double monto, dineroDado;
            monto = 0;
            dineroDado = 0;
            //GET MONTO FOR ROWS
            foreach (DataGridViewRow row in datagridProveedores.Rows)
            {
                monto += Convert.ToDouble(row.Cells[4].Value);
            }

            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total:", monto); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", dineroDado);
            Ticket1.AgregaTotales("Efectivo Devuelto:", dineroDado - monto);


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");
            Ticket1.TextoCentro("*     @GlowishFashion.LV    *");
            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            //Message
            MessageBox.Show("El ticket se guardó en la carpeta de documentos", "TICKET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnNuevaFactura.Enabled = true;
            GenerateTicket();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = false;
            lblTitle.Text = "Añadir una venta";
        }

        private void txtbCedulaCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtbCedulaCliente.Text.Length == 3)
            {
                txtbCedulaCliente.Text += "-";
                txtbCedulaCliente.SelectionStart = txtbCedulaCliente.Text.Length;
            }
            else if (txtbCedulaCliente.Text.Length == 12)
            {
                txtbCedulaCliente.Text += "-";
                txtbCedulaCliente.SelectionStart = txtbCedulaCliente.Text.Length;
            }
        }

        private void txtbCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Verificar si ya se alcanzó el número máximo de caracteres
            if (txtbCedulaCliente.Text.Length >= 14 && e.KeyChar != '\b') // '\b' representa la tecla de retroceso
            {
                e.Handled = true;
            }
        }
    }
}
