using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cotizacionMoneda
{
    public class Moneda
    {
        public TipoMoneda Tipo { get; set; }
        public string Simbolo { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioCompra { get; set; }
       
    }
}
