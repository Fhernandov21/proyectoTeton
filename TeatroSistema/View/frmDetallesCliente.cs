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
    public partial class frmDetallesCliente : Form
    {
        

        public frmDetallesCliente()
        {
            InitializeComponent();
        }

        private void frmDetallesCliente_Load(object sender, EventArgs e)
        {
            
        }

        public void cargarCliente(int id)
        {
            dgvDetalles.DataSource =  CCliente.Mostrar_DetallesClientes(id);
        }
    }
}
