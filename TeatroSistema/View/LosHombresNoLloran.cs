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
using TeatroSistema.Data;

namespace TeatroSistema.View
{
    public partial class LosHombresNoLloran : Form
    {
        float totalServicios = 0;
        DataTable serviciosReservados = new DataTable();

        public LosHombresNoLloran()
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
        private void cargarCmbs()
        {
            object[] horas = new object[12];
            object[] minutos = new object[60];
            for(int i = 1; i<=12; i++)
            {
                horas[i - 1] = i;
            }
            cmbHoraInicio.Items.AddRange(horas);
            
            for (int i = 0; i<60; i++)
            {
                minutos[i] = i;
            }
            cmbMinutoInicio.Items.AddRange(minutos);
            object[] ampm = new object[] { "am", "pm" };
            cmbAMPMInicio.Items.AddRange(ampm);

            cmbHoraInicio.SelectedIndex = 11;
            cmbMinutoInicio.SelectedIndex = 59;
            cmbAMPMInicio.SelectedIndex = 0;
            txtDuracion.ForeColor = Color.Gray;
            txtDuracion.Text = "HH:MM:SS";
            
        }
       

        private void LosHombresNoLloran_Load(object sender, EventArgs e)
        {
            cargarItinerario();
            calendario.MaxSelectionCount = 1;
            cargarCmbs();
            DataTable dtServicios = CServicio.Mostrar_Servicios();
            dtServicios.Columns.Remove("Codigo"); dtServicios.Columns.Remove("Estado");
            dgvServicios.DataSource = dtServicios;

            dgvServicios.MultiSelect = false; dgvServicios.ReadOnly = true;
            
            dgvItinerario.MultiSelect = false; dgvItinerario.ReadOnly = true;
            
            dgvCliente.MultiSelect = false; dgvCliente.ReadOnly = true;

            dgvServiciosReservados.MultiSelect = false; dgvServiciosReservados.ReadOnly = true;

            serviciosReservados.Columns.Add("Descripcion");
            serviciosReservados.Columns.Add("Precio");
            serviciosReservados.Columns.Add("Cantidad");
            serviciosReservados.Columns.Add("SubTotal");
            dgvServiciosReservados.DataSource = serviciosReservados;
            DataTable salones = new DataTable();
            salones = CSalon.MostrarSalones();
            foreach (DataRow row in salones.Rows)
            {
                cmbSalon.Items.Add(row[1].ToString());
            }
            cmbSalon.SelectedIndex = 0;
        }

        

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void calendario_DateSelected(object sender, DateRangeEventArgs e)
        {

            cargarItinerario();
            
        }

        private void btnSearchCliente_Click(object sender, EventArgs e)
        {
            FrmClienteV2 frmClientes = new FrmClienteV2();
            frmClientes.enviarClienteEvent += new FrmClienteV2.enviarCliente(recibirCliente);
            //frmClientes.btnMenu.Enabled = false;
            //frmClientes.btnDetalles.Hide();
            //frmClientes.btnEntidad.Hide();
            //frmClientes.btnNuevo.Hide();
            //frmClientes.btnMenu.Hide();
            frmClientes.desde = "aqui";
            frmClientes.ShowDialog();
        }

        private void recibirCliente(int id)
        {
           dgvCliente.DataSource =  CCliente.Buscar_Cliente(id);
           
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmAddPersona frmadd = new frmAddPersona(CCliente.Mostrar_Clientes().Rows.Count);
            //frmadd.enviarClienteEvent += new FrmClienteV2.enviarCliente(recibirCliente);
        }

        private void btnSeleccionarEmpleado_Click(object sender, EventArgs e)
        {
            //necesito el catálogo de empleados
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            float precio;
            int cantidad;

            precio = float.Parse(dgvServicios.CurrentRow.Cells[2].Value.ToString());
            cantidad = (int)spnCantidad.Value;

            if (cantidad > int.Parse(dgvServicios.CurrentRow.Cells[2].Value.ToString()))
            {
                MessageBox.Show("Cantidad insuficiente", "Mensaje del sistema", MessageBoxButtons.OK);
                return;
            }
            if(cantidad == 0)
            {
                return;
            }
            string descripcion = dgvServicios.CurrentRow.Cells[0].Value.ToString();
            
            foreach(DataGridViewRow row in dgvServiciosReservados.Rows)
            {
                if (descripcion.Equals(row.Cells[0].Value.ToString()))
                {
                    row.Cells[2].Value = (int.Parse(row.Cells[2].Value.ToString())+cantidad);
                    row.Cells[3].Value = int.Parse(row.Cells[2].Value.ToString()) * precio;
                    dgvServicios.CurrentRow.Cells[2].Value = (int.Parse(dgvServicios.CurrentRow.Cells[2].Value.ToString()) - cantidad);
                    return;
                }
                else
                {
                    continue;
                }
                
            }


            float subtotal = precio * cantidad;
            serviciosReservados.Rows.Add(new object[]{
                dgvServicios.CurrentRow.Cells[0].Value.ToString(),
                precio,
                cantidad,
                subtotal
            });

            dgvServicios.CurrentRow.Cells[2].Value = (int.Parse(dgvServicios.CurrentRow.Cells[2].Value.ToString()) - cantidad);
        }

        private void txtDuracion_Enter(object sender, EventArgs e)
        {
            entrando(txtDuracion, "HH:MM:SS");
        }

        private void txtDuracion_Leave(object sender, EventArgs e)
        {
            saliendo(txtDuracion, "HH:MM:SS");
        }

        public void entrando(TextBox txt, string v)
        {
            if (txt.Text.Equals(v))
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        public void saliendo(TextBox txt, string v)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = v;
                txt.ForeColor = Color.Gray;
            }
            else
            {
                return;
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            string descripcion = dgvServiciosReservados.SelectedRows[0].Cells[0].Value.ToString();
            int cantidad = int.Parse(dgvServiciosReservados.SelectedRows[0].Cells[2].Value.ToString());
            foreach (DataGridViewRow row in dgvServicios.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(descripcion))
                {
                    row.Cells[2].Value = int.Parse(row.Cells[2].Value.ToString()) + cantidad;
                    serviciosReservados.Rows.RemoveAt(dgvServiciosReservados.CurrentCell.RowIndex);
                }
            }
            

        }

       
        private void cargarItinerario()
        {
            string date = calendario.SelectionStart.Year + "-" +
                          calendario.SelectionStart.Month + "-" +
                          calendario.SelectionStart.Day;
            int NoSalon = cmbSalon.SelectedIndex+1;
            dgvItinerario.DataSource = CEvento.Horas_Ocupadas(date, NoSalon);
        }
        private void cmbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarItinerario(); 
            DataTable salones = new DataTable();
            salones = CSalon.MostrarSalones();
            lblPrecioSalon.Text = "Precio: "+salones.Rows[cmbSalon.SelectedIndex]["Precio"].ToString();
            lblCapacidadSalon.Text = "Capacidad: "+salones.Rows[cmbSalon.SelectedIndex]["CapacidadPersonas"].ToString()+" Personas";
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarVentana(sender, e);
        }

        private void btnCancelarProgramacion_Click(object sender, EventArgs e)
        {
            var verificacion = MessageBox.Show("¿Desea cancelar la Programación del evento?", "Mensje del sistema",
                MessageBoxButtons.YesNo);
            if (verificacion == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnProgramarEvento_Click(object sender, EventArgs e)
        {
            var verificacion = MessageBox.Show("¿Desea realizar la Programación del evento?", "Mensje del sistema",
                MessageBoxButtons.YesNo);
            if (verificacion == DialogResult.Yes)
            {
                //generar evento y factura
            }
            else
            {
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
