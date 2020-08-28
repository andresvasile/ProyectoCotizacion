using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cotizacionMoneda
{
    public class Presentador
    {
        private IVista _vista;
        private Repositorio _repositorio;
        public Presentador(IVista vista)
        {
            _repositorio=new Repositorio();
            _vista = vista;
            _vista.listarMonedas(_repositorio.monedas);
            _vista.listarTipoCotizaciones();
        }

        internal void realizarCalculo(double monto,TipoMoneda tipoMoneda, TipoCotizacion tipoCotizacion)
        {
            var moneda= _repositorio.BuscarTipoMoneda(tipoMoneda);
            var cotizacion = new Cotizacion(moneda,tipoCotizacion);
            _vista.mostrarConversion(tipoMoneda,cotizacion.Conversion(monto));
        }
    }
}
