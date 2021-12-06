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
    public partial class FrmEmpresasMan : Form
    {
        public FrmEmpresasMan()
        {
            InitializeComponent();
        }

        private void FrmEmpresasMan_Load(object sender, EventArgs e)
        {

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
    }
}
