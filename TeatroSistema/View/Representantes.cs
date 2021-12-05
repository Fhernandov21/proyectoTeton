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
    public partial class Representantes : Form
    {
        public Representantes()
        {
            InitializeComponent();
        }

        private void Representantes_Load(object sender, EventArgs e)
        {
            CargarReprese();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string NombreRepre , NombreEnti , Direccion, telefono , CedulaRepresentante , fecha;
            NombreRepre = txtNombreRepre.Text;
            NombreEnti = txtNombreEntidad.Text;
            Direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            CedulaRepresentante = txtCedula.Text;
            fecha = dateTimeFecha.Text;
            CRepresentante.CrearRepresentante(NombreRepre , NombreEnti, Direccion , telefono , CedulaRepresentante , fecha);
            Console.WriteLine("Se Creo el representante");
        }
        private void CargarReprese()
        {
            dataGridView1.DataSource = CRepresentante.MostrarRepresentantes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string NombreRepre, NombreEnti, Direccion, telefono, CedulaRepresentante, fecha;
            NombreRepre = txtNombreRepre.Text;
            NombreEnti = txtNombreEntidad.Text;
            Direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            CedulaRepresentante = txtCedula.Text;
            fecha = dateTimeFecha.Text;
            CRepresentante.ActualizarRepresentanes(NombreRepre, NombreEnti, Direccion, telefono, CedulaRepresentante, fecha);
            CargarReprese();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreRepre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNombreEntidad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCedula.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimeFecha.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
