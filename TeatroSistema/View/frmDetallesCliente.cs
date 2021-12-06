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
    public partial class frmDetallesCliente : Form
    {
        

        public frmDetallesCliente()
        {
            InitializeComponent();
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

        private void frmDetallesCliente_Load(object sender, EventArgs e)
        {
            
        }

        public void cargarCliente(int id)
        {
            dgvDetalles.DataSource =  CCliente.Mostrar_DetallesClientes(id);
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
