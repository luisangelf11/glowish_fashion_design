using Guna.UI.WinForms;
using Guna.UI2.WinForms;
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
using System.Web;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AutoCompleteTextBox;
using System.Web.UI.WebControls;
using Nager.Country.Translation;
using Nager.Country;

namespace Glowish_Fashion_System.Views
{
    public partial class FrmProveedores : Form
    {
        int posicionfiltro = 0;
        bool guardar = false;

        List<string> filtros = new List<string>() { "General","ID", "Nombre","Correo", "Pais", "Teléfono", "Plataforma", "Ciudad", "Institución"};
   
       
        

        
        
        

       public List<string> paises = new List<string>()
        {
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "Birmania",
            "Bolivia",
            "Bosnia y Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Ciudad del Vaticano",
            "Colombia",
            "Comoras",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guinea",
            "Guinea-Bisáu",
            "Guinea Ecuatorial",
            "Guyana",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República del Congo",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumania",
            "Rusia",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"
        };
       


        
        public void Evaluate(string accion)
        {
            
            if (accion == "Borrar")
            {
                foreach (System.Windows.Forms.Control control in panelAnadirProveedor.Controls)
                {
                    if(control is Guna2TextBox)
                    { 
                        control.Text = "";
                 
                        guardar = false;

                    }
                   
                    
                }
            }
            else
            {
                if(!(string.IsNullOrEmpty(txtbProvCorreo.Text) || string.IsNullOrEmpty(txtbProvNombre.Text) || string.IsNullOrEmpty(txtbProvEmpresa.Text) || string.IsNullOrEmpty(txtbProvPlataforma.Text) || string.IsNullOrEmpty(txtbProvTelefono.Text) || string.IsNullOrEmpty(cmbbProvCiudad.Text) || string.IsNullOrEmpty(cmbbProvPais.Text)))
                {
                   
                        guardar = true;
                } 
                else
                {
                         guardar = false;
                }
            }

            
        }


        
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
           
            this.Opacity = 0;
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
            string searchTerm = txtbProveedor.Text.ToLower(); 
            bool existe = false;
            foreach (DataGridViewRow row in datagridProveedores.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {
                        existe = true;
                        datagridProveedores.ClearSelection();
                        cell.Selected = true; 
                        datagridProveedores.FirstDisplayedScrollingRowIndex = row.Index; 
                        return;
                    }
                    
                }
            }

            if(!existe)
            {

                MessageBNoProvedor.Show();
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
            lblTitle.Text = "Añadir un proveedor";
        }

        private void btnGuardarproveedor_Click(object sender, EventArgs e)
        {
            Evaluate("");

            if(guardar == true)
            {

                if (guardar && txtbProvCorreo.Text.Contains("@") && (txtbProvCorreo.Text.EndsWith(".com") || txtbProvCorreo.Text.EndsWith(".net")))
                {
                    if(paises.Contains(cmbbProvPais.Text))
                    {
                        datagridProveedores.Rows.Add("--", txtbProvNombre.Text, txtbProvPlataforma.Text, cmbbProvPais.Text, cmbbProvCiudad.Text, txtbProvCorreo.Text, txtbProvTelefono.Text, txtbProvEmpresa.Text);

                        Evaluate("Borrar");
                        panelAnadirProveedor.Visible = false;


                        MessageSuccesss.Show();

                    }
                    else
                    {
                        MessageBPais.Show();
                    }
                    
                }
                else
                {
                    
                    MessageBErroCorreo.Show();
                    
                }
            }
            else
            {
                MesageBCamposVacios.Show();
                
            }

            guardar = false;
            
            lblTitle.Text = "Añadir un proveedor";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelAnadirProveedor.Visible = true;
            lblTitle.Text = "Editar un proveedor";
            if(datagridProveedores.SelectedRows.Count > 0)
            {
                //Codigo para enviar los datos a los textboxs
            }
        }

        private void txtbProvTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void picboxConfirm_Click(object sender, EventArgs e)
        {

        }

       

        private void cmbbProvPais_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btnCambiarFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                posicionfiltro++;
                lblFiltro.Text = filtros[posicionfiltro];
                
            }
            catch
            {

               
                posicionfiltro = 0;
                lblFiltro.Text = filtros[posicionfiltro];          
                
            }
            
            
        }
    }
}
