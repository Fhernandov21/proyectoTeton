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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void cargarEventos()
        {           
            dgvEventos.DataSource = CEvento.Mostrar_EventosPendientes(DateTime.Now.ToString());
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            
            cargarEventos();
            string nombreSalon = dgvEventos.SelectedRows[0].Cells[2].Value.ToString();


        }

        private void btnAddBoleto_Click(object sender, EventArgs e)
        {

        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPrecio.Text = dgvEventos.SelectedRows[0].Cells[0].Value.ToString();       
        }

        private void dgvEventos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtPrecio.Text = dgvEventos.Rows[e.RowIndex].Cells[0].Value.ToString();

        }
    }
}
