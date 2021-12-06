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
    public partial class frmVentas : Form
    {

        DataTable Empleado = new DataTable();
        public frmVentas(DataTable empleado)
        {
            InitializeComponent();
            Empleado = empleado;
        }

        private void cargarEventos()
        {
            dgvEventos.DataSource = CEvento.Mostrar_EventosPendientes(DateTime.Now.ToString());
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cargarEventos();
            dgvAsientos.Columns.Add("Asiento", "Asiento");
            dgvAsientos.Columns.Add("Precio", "Precio");
            dgvAsientos.Columns.Add("Salon", "Salon");
            lblID.Text = Empleado.Rows[0].ItemArray[0].ToString();
        }

        private void btnAddBoleto_Click(object sender, EventArgs e)
        {
            dgvAsientos.Rows.Add(new object[] { dgvEventos.SelectedRows[0].Cells[2].Value.ToString(), });
        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPrecio.Text = dgvEventos.SelectedRows[0].Cells[6].Value.ToString();
            string imgEventoaux = dgvEventos.Rows[e.RowIndex].Cells[1].Value.ToString();
            //pictureBox1.Image = Image.FromFile(@"C:\Users\fherv\OneDrive\Escritorio\otra vex\TeatroSistema\Imagen\" +
            //    imgEventoaux.Replace(" ", string.Empty) + ".jfif"
            //);
        }

        private void dgvEventos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtPrecio.Text = dgvEventos.Rows[e.RowIndex].Cells[6].Value.ToString();
            dgvAsientos.Rows.Clear();
            string imgEventoaux = dgvEventos.Rows[e.RowIndex].Cells[1].Value.ToString();
            //pictureBox1.Image = Image.FromFile(@"C:\Users\fherv\OneDrive\Escritorio\otra vex\TeatroSistema\Imagen\" +
            //    imgEventoaux.Replace(" ", string.Empty) + ".jfif"
            //);

        }

        private void btnVerAsientos_Click(object sender, EventArgs e)
        {
            int idEvento = int.Parse(dgvEventos.SelectedRows[0].Cells[0].Value.ToString());
            string salon = dgvEventos.SelectedRows[0].Cells[2].Value.ToString();
            object[] asientos = new object[10];
            frmAsientos fa = new frmAsientos(salon, idEvento);
            for (int i = 0; i < 10; i++)
            {
                fa.dgvAsientosDisponibles.Columns.Add(i.ToString(), (i + 1).ToString());
            }
            for (int i = 0; i < CVenta.CargarAsientos(salon) / 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    asientos[j] = (i * 10) + j + 1;

                }
                fa.dgvAsientosDisponibles.Rows.Add(asientos);

            }


            fa.ShowDialog();
            int asiento = fa.asiento;
            float precio = float.Parse(txtPrecio.Text);

            foreach (DataGridViewRow row in dgvAsientos.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(asiento.ToString()))
                {
                    MessageBox.Show("Asiento ocupado", "Mensaje del sistema");
                    return;
                }
            }
            if (asiento == 0)
            {
                return;
            }

            dgvAsientos.Rows.Add(new object[] { asiento, precio, salon });
        }

        private void btnEliminarBoleto_Click(object sender, EventArgs e)
        {
            if (dgvAsientos.Rows.Count == 0)
            {
                return;
            }
            dgvAsientos.Rows.RemoveAt(dgvAsientos.CurrentCell.RowIndex);

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            var verificacion = MessageBox.Show("¿Desea realizar la Venta?", "Mensje del sistema",
                MessageBoxButtons.YesNo);
            if (verificacion == DialogResult.No)
            {
                return;
            }
            
            if (dgvAsientos.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                return;
            }
            var seed = Environment.TickCount;
            var random = new Random(seed);
            int hola = (int)txtNombre.Text[0];
            string salon = dgvEventos.SelectedRows[0].Cells[2].Value.ToString();


            int numeroVenta = (int)random.Next(0, 150000000) / hola;


            string okkkk = CVenta.Realizar_Venta(numeroVenta, int.Parse(dgvEventos.SelectedRows[0].Cells[0].Value.ToString()),
                DateTime.Now.ToString(), int.Parse(txtID.Text), int.Parse(lblID.Text), txtNombre.Text, txtCedula.Text);

            foreach (DataGridViewRow row in dgvAsientos.Rows)
            {
                //int numVenta, float costoAsiento, float pt, int asiento, string noSalon
                string okkk = CVenta.Insertar_DetalleVenta(numeroVenta, float.Parse(row.Cells[1].Value.ToString()),
                    (float)0.7, int.Parse(row.Cells[0].Value.ToString()), salon, int.Parse(dgvEventos.SelectedRows[0].Cells[0].Value.ToString()));

            }
            MessageBox.Show("Venta Realizada con éxisto" , "Mensaje del sistema");
            dgvAsientos.Rows.Clear();
            txtNombre.Enabled = false;
        }

        private void txtCedula_KeyUp(object sender, KeyEventArgs e)
        {
            txtNombre.Text = CVenta.Cedula_Comprador_NOMBRE(txtCedula.Text);
            txtID.Text = CVenta.Cedula_Comprador_ID(txtCedula.Text).ToString();
        }

        private void btnNuevoCliente_Event(object sender, EventArgs e)
        {
            txtID.Text = CVenta.CompradorNuevo().ToString();
            txtNombre.Enabled = true;
        }

        private void btnCancelarCliente_Event(object sender, EventArgs e)
        {

            txtNombre.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var verificacion = MessageBox.Show("¿Desea cancelar la Venta?", "Mensje del sistema",
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
    }
}
