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
    public partial class FrmClienteV2 : Form
    {
        DataTable dt = new DataTable();
        public FrmClienteV2()
        {
            InitializeComponent();
        }
        public string desde="";
        // PARA ARRASTRAR LA VENTANA

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWindm, int wMsg, int wParam, int lParam);

        private void ArrastrarVentana(object sender, MouseEventArgs args)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarVentana(sender, e);
        }

        private void FrmClienteV2_Load(object sender, EventArgs e)
        {
            
            dt = CCliente.Mostrar_Clientes();
            this.dgvClientes.DataSource = dt;
            dgvClientes.MultiSelect = false;
            dgvClientes.ReadOnly = true;
            if (desde.Equals("")){
                
                btnSelect.Enabled = false;
                btnSelect.Hide();
            }
            else
            {
                btnSelect.Enabled = true;
                btnSelect.Show();
            }
            
            
            

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuBar.Width == 212)
            {
                MenuBar.Width = 0;
                panelTable.Width = 914;
            }
            else
            {
                MenuBar.Width = 212;
                panelTable.Width = 728;
            }
        }

        // BOTÓN PARA SALIR
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // EVENTOS
            //PARA MOSTRAR LOS DETALLES
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

            //MUESTRA CLIENTES JURIDICOS
        private void btnEntidad_Click(object sender, EventArgs e)
        {
            FrmAddEntidad fre = new FrmAddEntidad(this.dgvClientes.Rows.Count);
            fre.enviarEntidadEvent += new FrmAddEntidad.enviarEntidad(recibirEntidad);
            fre.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAddPersona addPersona = new frmAddPersona(this.dgvClientes.Rows.Count);
            addPersona.enviarPersonaEvent += new frmAddPersona.enviarPersona(recibirPersona);
            addPersona.Show();
        }

        private void recibirEntidad(int id, string tipo, string nombre, string direccion, string telefono)
        {
            object[] valoresColumnas = new object[] { id, tipo, nombre, direccion, telefono };
            dt.Rows.Add(valoresColumnas);
            this.dgvClientes.DataSource = dt;
        }
        private void recibirPersona(int id, string tipo, string nombre, string direccion, string telefono)
        {
            object[] valoresColumnas = new object[] { id, tipo, nombre, direccion, telefono };
            dt.Rows.Add(valoresColumnas);
            this.dgvClientes.DataSource = dt;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            enviarClienteEvent(int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString()));
            this.Close();
        }
        public delegate void enviarCliente(int id);
        public event enviarCliente enviarClienteEvent;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
