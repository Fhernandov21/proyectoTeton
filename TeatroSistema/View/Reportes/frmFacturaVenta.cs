using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatroSistema.View.Reportes
{
    public partial class frmFacturaVenta : Form
    {
        int fact;
        public frmFacturaVenta(int NoFactura)
        {
            InitializeComponent();

            this.fact = NoFactura;
        }

        private void frmFacturaVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtVentas.Mostrar_FacturaVenta' Puede moverla o quitarla según sea necesario.
            this.Mostrar_FacturaVentaTableAdapter.Fill(this.dtVentas.Mostrar_FacturaVenta, this.fact);
            // TODO: esta línea de código carga datos en la tabla 'dtVentas.MostrarDetalle_FacturaVenta' Puede moverla o quitarla según sea necesario.
            this.MostrarDetalle_FacturaVentaTableAdapter.Fill(this.dtVentas.MostrarDetalle_FacturaVenta, this.fact);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
