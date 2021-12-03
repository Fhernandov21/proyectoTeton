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
    public partial class FrmReportes : Form
    {
        Panel Content;
        public FrmReportes(Panel content)
        {
            InitializeComponent();
            Content = content;
        }

        public void SeleccionandoBoton(Button sender)
        {
            btnFacturarEvento.ForeColor = Color.White;
           

            sender.Enabled = true;
            if (sender.Enabled)
            {
                sender.ForeColor = Color.FromArgb(0, 122, 204);
            }

        }

        private void btnFacturarEvento_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            FrmMain.MostrarFrames(Content, new FrmFacturarEvento());
        }
    }
}
