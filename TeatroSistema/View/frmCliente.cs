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
    public partial class frmCliente : Form
    {
        DataTable dt = new DataTable();
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAddPersona addPersona = new frmAddPersona(this.dgvClientes.Rows.Count);
            addPersona.enviarPersonaEvent += new frmAddPersona.enviarPersona(recibirPersona);
            addPersona.Show();
            
        }

        private void btnEntidad_Click(object sender, EventArgs e)
        {
            FrmAddEntidad fre = new FrmAddEntidad(this.dgvClientes.Rows.Count);
            fre.enviarEntidadEvent += new FrmAddEntidad.enviarEntidad(recibirEntidad);
            fre.Show();


        }

        private void recibirPersona(int id, string tipo, string nombre, string direccion, string telefono)
        {             
            object[] valoresColumnas = new object[] { id, tipo, nombre, direccion, telefono };
            dt.Rows.Add(valoresColumnas);
            this.dgvClientes.DataSource = dt;
        }

        private void Entidades_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            dt = CCliente.Mostrar_Clientes();
            this.dgvClientes.DataSource = dt;
            
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una única fila", "Sistema Teatro", MessageBoxButtons.OK);
                return;
            }
            frmDetallesCliente fdet = new frmDetallesCliente();
            int.TryParse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString(), out int id);
            
            fdet.cargarCliente(id);
            fdet.Show();
            
            
            
        }

        

        private void recibirEntidad(int id, string tipo, string nombre, string direccion, string telefono)
        {
            object[] valoresColumnas = new object[] { id, tipo, nombre, direccion, telefono };
            dt.Rows.Add(valoresColumnas);
            this.dgvClientes.DataSource = dt;
        }
    }
}
