using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glowish_Fashion_System.Reports
{
    public class Ventas
    {
        public int Id { get; set; }
        public string Cedula_Cliente { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Monto_Producto { get; set; }
        public DateTime Fecha { get; set; }
        public double Descuento { get; set; }
        public double Itebis { get; set; }
        public double SubTotal { get; set; }
        public double Efectivo_Dado { get; set; }
        public double Devuelta { get; set; }
    }
}
