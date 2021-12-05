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
    
    public partial class frmAsientos : Form
    {

        public int asiento;
        private string salon;
        public frmAsientos(string salon)
        {
            InitializeComponent();
            this.salon = salon;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            asiento = int.Parse(dgvAsientosDisponibles.CurrentCell.Value.ToString());
            int fila = dgvAsientosDisponibles.CurrentCell.RowIndex;
            int columna = dgvAsientosDisponibles.CurrentCell.ColumnIndex;
            
            if (CVenta.Verificar_Asiento(asiento, this.salon) == 0)
            {
                MessageBox.Show("Asiento ocupado", "Mensaje del sistema");
                return;
            }
            this.Close();
        }

        private void frmAsientos_Load(object sender, EventArgs e)
        {
            lblSalon.Text = "Asientos del salón " + this.salon;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
