using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatroSistema.View;

namespace TeatroSistema.View.Subframes
{
    public partial class FrmSeguridad : Form
    {
        Panel Content;
        public FrmSeguridad(Panel content)
        {
            InitializeComponent();
            Content = content;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmMain.MostrarFrames(Content,new FrmUsuarioV2());
        }

    }
}
