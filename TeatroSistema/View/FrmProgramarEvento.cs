using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatroSistema.Controller;

namespace TeatroSistema.View
{
    public partial class FrmProgramarEvento : Form
    {
        public FrmProgramarEvento()
        {
            InitializeComponent();
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(fechaSeleccionada(), "soy la fecha jeje", MessageBoxButtons.OK);
        }

        private string fechaSeleccionada()
        {
            return calendario.SelectionStart.Date.Year.ToString() + "-" +
                            calendario.SelectionStart.Date.Month.ToString() + "-" +
                            calendario.SelectionStart.Date.Day.ToString();
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {

        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblItinerario.Text = "Itinerario del día " + fechaSeleccionada();
            dgvItinerario.DataSource =  CEvento.Horas_Ocupadas(fechaSeleccionada(), cmbSalon.SelectedIndex);
        }
    }
}
