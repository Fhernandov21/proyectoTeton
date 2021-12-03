using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatroSistema.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usuariosWin_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Any(child => child is frmUsuario))
            {
                return;
            }
            else
            {
                frmUsuario fUser = new frmUsuario();
                fUser.MdiParent = this;
                fUser.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Any(child => child is frmCliente))
            {
                return;
            }

            frmCliente fCliente = new frmCliente();
            fCliente.MdiParent = this;
            fCliente.Show();
            
        }
    }
}
