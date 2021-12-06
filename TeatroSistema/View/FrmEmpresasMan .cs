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
    public partial class FrmEmpresasMan : Form
    {
        public FrmEmpresasMan()
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

        private void FrmEmpresasMan_Load(object sender, EventArgs e)
        {
            CargarEmpresas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ruc;
            string Nombre, Direccion, Telefono;
            ruc = (int)Convert.ToInt64(txtRucEmpresa.Text);
            Nombre = txtNombreEmpresa.Text;
            Direccion = txtDireccion.Text;
            Telefono = txtTelefono.Text;

            CEmpresasMantenimiento.CrearEmpresa(ruc ,Nombre , Direccion , Telefono);
            CargarEmpresas();

        }
        private void CargarEmpresas()
        {
            dgvEmpresasMan.DataSource = CEmpresasMantenimiento.MostrarEmpresaMan();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int ruc;
            string Nombre, Direccion, Telefono;
            ruc = (int)Convert.ToInt64(txtRucEmpresa.Text);
            Nombre = txtNombreEmpresa.Text;
            Direccion = txtDireccion.Text;
            Telefono = txtTelefono.Text;
            CEmpresasMantenimiento.ActualizarEmpresaMan(ruc , Nombre , Direccion , Telefono);
            CargarEmpresas(); 

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Nombre;
            Nombre = txtNombreEmpresa.Text;
            CEmpresasMantenimiento.EliminarEmpresaMan(Nombre);
            CargarEmpresas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtDireccion.Text = null;
            txtNombreEmpresa.Text = null;
            txtRucEmpresa.Text = null;
            txtTelefono.Text = null; 
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarVentana(sender,e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
