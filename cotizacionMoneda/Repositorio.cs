using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cotizacionMoneda
{
    public class Repositorio
    {
        public List<Cotizacion> cotizaciones;
        public List<Moneda> monedas { get; set; }
        public Repositorio()
        {
            monedas = new List<Moneda>()
            {
                new Moneda()
                {
                    PrecioCompra = 73.03,
                    PrecioVenta = 78.02,
                    Tipo = TipoMoneda.Dolar,
                    Simbolo = "U$S"
                    
                },
                new Moneda()
                {
                    PrecioCompra = 80.42,
                    PrecioVenta = 85.39,
                    Tipo = TipoMoneda.Euro,
                    Simbolo = "€"
                },
                new Moneda()
                {
                    PrecioCompra = 12.43,
                    PrecioVenta = 13.94,
                    Tipo = TipoMoneda.Real,
                    Simbolo = "R$"
                }
            };
        }

        internal Moneda BuscarTipoMoneda(TipoMoneda tipoMoneda)
        {
            return monedas.Find(m => m.Tipo == tipoMoneda); 
        }
    }
}
