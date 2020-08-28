using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cotizacionMoneda
{
    public interface IVista
    {
        void listarMonedas(List<Moneda> monedas);
        void listarTipoCotizaciones();
        void mostrarConversion(TipoMoneda tipoMoneda,double v);
    }
}
