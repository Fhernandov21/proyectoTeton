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
    public partial class FrmRepresentates : Form
    {
        public FrmRepresentates()
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

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarVentana(sender, e);
        }

        private void CargarReprese()
        {
            dgvRepresentantes.DataSource = CRepresentante.MostrarRepresentantes();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string NombreRepre, NombreEnti, Direccion, telefono, CedulaRepresentante, fecha;
            NombreRepre = txtNombreRepre.Text;
            NombreEnti = txtNombreEntidad.Text;
            Direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            CedulaRepresentante = txtCedula.Text;
            fecha = dateTimeFecha.Text;
            CRepresentante.CrearRepresentante(NombreRepre, NombreEnti, Direccion, telefono, CedulaRepresentante, fecha);
            Console.WriteLine("Se Creo el representante");
        }

        private void FrmRepresentates_Load(object sender, EventArgs e)
        {
            CargarReprese();
        }

        private void dgvRepresentantes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreRepre.Text = dgvRepresentantes.CurrentRow.Cells[0].Value.ToString();
            txtNombreEntidad.Text = dgvRepresentantes.CurrentRow.Cells[1].Value.ToString();
            txtDireccion.Text = dgvRepresentantes.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvRepresentantes.CurrentRow.Cells[3].Value.ToString();
            txtCedula.Text = dgvRepresentantes.CurrentRow.Cells[4].Value.ToString();
            dateTimeFecha.Text = dgvRepresentantes.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
