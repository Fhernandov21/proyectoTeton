using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatroSistema.View.Subframes
{
    public partial class FrmOperaciones : Form
    {
        Panel Content;
        DataTable Empleado = new DataTable();
        public FrmOperaciones(Panel content, DataTable empleado)
        {
            InitializeComponent();
            Content = content;
            Empleado = empleado;
        }

        public void SeleccionandoBoton(Button sender)
        {
            btnProgramarEvento.ForeColor = Color.White;

            sender.Enabled = true;
            if (sender.Enabled)
            {
                sender.ForeColor = Color.FromArgb(0, 122, 204);
            }

        }

        private void btnProgramarEvento_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            FrmMain.MostrarFrames(Content, new LosHombresNoLloran(Empleado));
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            FrmMain.MostrarFrames(Content, new frmVentas(Empleado));
        }
    }
}
