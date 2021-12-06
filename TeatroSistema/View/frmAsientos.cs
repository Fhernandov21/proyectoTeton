using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWindm, int wMsg, int wParam, int lParam);

        private void ArrastrarVentana(object sender, MouseEventArgs args)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarVentana(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
