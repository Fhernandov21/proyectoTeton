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
    public partial class FrmCatalogo : Form
    {
        Panel Content;
        public FrmCatalogo(Panel content)
        {
            InitializeComponent();
            Content = content;
        }

        public void SeleccionandoBoton(Button sender)
        {
            btnClientes.ForeColor = Color.White;
            btnEmpleado.ForeColor = Color.White;
            btnEmpMantenimiento.ForeColor = Color.White;
            btnMantenimiento.ForeColor = Color.White;
            btnSalon.ForeColor = Color.White;
            btnServicios.ForeColor = Color.White;

            sender.Enabled = true;
            if (sender.Enabled)
            {
                sender.ForeColor = Color.FromArgb(0, 122, 204);
            }

        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button) sender);
            FrmMain.MostrarFrames(Content,new FrmClienteV2());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            FrmMain.MostrarFrames(Content, new FrmSalonesV2());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            FrmMain.MostrarFrames(Content, new FrmServiciosV2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            FrmMain.MostrarFrames(Content, new FrmEmpresasMan());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            FrmMain.MostrarFrames(Content, new FrmRepresentates());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            FrmMain.MostrarFrames(Content, new FrmEmpleadoV2());
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            FrmMain.MostrarFrames(Content, new FrmEventosV2());
        }
    }
}
