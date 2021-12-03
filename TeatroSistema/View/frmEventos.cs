using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatroSistema.Controller;

namespace TeatroSistema.View
{
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date = calendario.SelectionStart.Year + "-" +
                          calendario.SelectionStart.Month + "-" +
                          calendario.SelectionStart.Day;
            dgvEventosPendientes.DataSource = CEvento.Mostrar_EventosPendientes(date);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
