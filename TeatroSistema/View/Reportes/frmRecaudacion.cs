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
    public partial class frmRecaudacion : Form
    {
        public frmRecaudacion()
        {
            InitializeComponent();
        }

        private void frmRecaudacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtRecaudacion.RecaudacionVentasDetalles' Puede moverla o quitarla según sea necesario.
            this.RecaudacionVentasDetallesTableAdapter.Fill(this.dtRecaudacion.RecaudacionVentasDetalles);
            // TODO: esta línea de código carga datos en la tabla 'dtRecaudacion.RecaudacionVentasTotales' Puede moverla o quitarla según sea necesario.
            this.RecaudacionVentasTotalesTableAdapter.Fill(this.dtRecaudacion.RecaudacionVentasTotales);

            this.reportViewer1.RefreshReport();
        }
    }
}
