using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cotizacionMoneda
{
    public partial class VistaCotizacion : Form, IVista
    {
        private Presentador _presentador;
        
        public VistaCotizacion()
        {
            InitializeComponent();
            _presentador=new Presentador(this);
        }

        public void listarMonedas(List<Moneda> monedas)
        {
            monedaBindingSource.DataSource = monedas;
        }

        public void listarTipoCotizaciones()
        {
            rbtnCompra.Text = TipoCotizacion.Compra.ToString();
            rbtnVenta.Text = TipoCotizacion.Venta.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var monto = double.Parse(txtMonto.Text);
            var tipoMoneda = (TipoMoneda)Enum.Parse(typeof(TipoMoneda),lbxMonedas.Text);
            TipoCotizacion tipoCoti=TipoCotizacion.Compra;
            
            tipoCoti = EsCompraOVenta(tipoCoti);
            _presentador.realizarCalculo(monto, tipoMoneda,tipoCoti);

        }

        private TipoCotizacion EsCompraOVenta(TipoCotizacion tipoCoti)
        {
            if (rbtnCompra.Checked)
            {
                tipoCoti = TipoCotizacion.Compra;
            }
            else if (rbtnVenta.Checked)
            {
                tipoCoti = TipoCotizacion.Venta;
            }

            return tipoCoti;
        }

        public void mostrarConversion(TipoMoneda tipoMoneda,double conversion)
        {
            lblConversion.Text = $"El valor en {tipoMoneda} es de: {conversion.ToString()}";
        }

    }
}
