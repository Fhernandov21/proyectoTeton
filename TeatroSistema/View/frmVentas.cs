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
        public frmVentas()
        {
            InitializeComponent();
        }

        private void cargarEventos()
        {           
            dgvEventos.DataSource = CEvento.Mostrar_EventosPendientes(DateTime.Now.ToString());
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {           
            cargarEventos();
            dgvAsientos.Columns.Add("Asiento", "Asiento" );
            dgvAsientos.Columns.Add("Precio", "Precio");
        }

        private void btnAddBoleto_Click(object sender, EventArgs e)
        {
            dgvAsientos.Rows.Add(new object[] { dgvEventos.SelectedRows[0].Cells[2].Value.ToString(), });
        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPrecio.Text = dgvEventos.SelectedRows[0].Cells[0].Value.ToString();       
        }

        private void dgvEventos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtPrecio.Text = dgvEventos.Rows[e.RowIndex].Cells[0].Value.ToString();
            dgvAsientos.Rows.Clear();
        }

        private void btnVerAsientos_Click(object sender, EventArgs e)
        {
            string salon = dgvEventos.SelectedRows[0].Cells[2].Value.ToString();
            object[] asientos = new object[10];
            frmAsientos fa = new frmAsientos(salon);
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
            string numVenta = 
                dgvAsientos.Rows.Count.ToString() + 
                DateTime.Today.Year.ToString() + 
                dgvEventos.SelectedRows[0].Cells[0].Value.ToString() + 
                DateTime.Now.Hour + 
                DateTime.Now.Millisecond;
            int numeroVenta = int.Parse(numVenta);
            string okkkk = CVenta.Realizar_Venta(numeroVenta, int.Parse(dgvEventos.SelectedRows[0].Cells[0].Value.ToString()),
                DateTime.Now.ToString(), int.Parse(txtID.Text), int.Parse(lblID.Text));
            foreach(DataGridViewRow row in dgvAsientos.Rows)
            {
                string okkk = CVenta.Insertar_DetalleVenta(numeroVenta, float.Parse(row.Cells[1].Value.ToString()),
                    float.Parse(txtPorcentaje.Text), int.Parse(row.Cells[0].Value.ToString()));
                if (okkk.Equals("Ok"))
                {
                    MessageBox.Show("Detalle Insertado");
                }
            }
            if (okkkk.Equals("Ok"))
            {
                MessageBox.Show("Venta Realizada");
            }
        }

        private void txtCedula_KeyUp(object sender, KeyEventArgs e)
        {
            txtNombre.Text = CVenta.Cedula_Comprador_NOMBRE(txtCedula.Text);
            txtID.Text = CVenta.Cedula_Comprador_ID(txtCedula.Text).ToString();
        }
    }
}
