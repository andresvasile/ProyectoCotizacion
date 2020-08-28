using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cotizacionMoneda
{
    public class Cotizacion
    {
        public Moneda Moneda { get; set; }
        public TipoCotizacion TipoCoti { get; set; }
        public Cotizacion(Moneda moneda, TipoCotizacion tipoCoti)
        {
            TipoCoti = tipoCoti;
            Moneda = moneda;
        }
        public double Conversion(double cantidadEnePesos)
        {
            switch (TipoCoti)
            {
                case TipoCotizacion.Compra:
                    return cantidadEnePesos * Moneda.PrecioCompra;
                case TipoCotizacion.Venta:
                    return cantidadEnePesos * Moneda.PrecioVenta;
                default:
                    throw new ArgumentException("Parametro incorrecto");
            }
        }
    }
}
