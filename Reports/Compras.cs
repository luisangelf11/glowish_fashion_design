using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glowish_Fashion_System.Reports
{
    public class Compras
    {
        public int Id { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public double Descuento { get;set;}
        public double Monto { get; set; }
        public int Id_Proveedor { get; set; }

        public DateTime Fecha { get; set; }
    }
}
