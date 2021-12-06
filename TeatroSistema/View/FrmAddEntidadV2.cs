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
    public partial class FrmAddEntidadV2 : Form
    {
        private int idActual = 0;
        public FrmAddEntidadV2(int id)
        {
            InitializeComponent();
            this.idActual = id;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string dateRep = dateTimeFecha.Text;

            string save = CCliente.Crear_Entidad(this.idActual, int.Parse(txtRuc.Text), txtNEntidad.Text, txtDirent.Text,
                txtCelent.Text, txtCedula.Text, txtName.Text + " " + txtApellido.Text, txtDirRep.Text, dateRep, txtCelrep.Text);
            if (save.Equals("OK"))
            {
                MessageBox.Show("Añadido con éxito!!!", "Sistema Teatro", MessageBoxButtons.OK);
                enviarEntidadEvent(this.idActual, "Natural", txtName.Text, txtDirent.Text, txtCelent.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("nooOOOOOOOOOOOOOOOOOOOOOO " + save, dateRep + " id:" + idActual, MessageBoxButtons.OK);

            }
        }
        public delegate void enviarEntidad(int id, string tipo, string nombre, string direccion, string telefono);
        public event enviarEntidad enviarEntidadEvent;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddEntidadV2_Load(object sender, EventArgs e)
        {

        }
    }


}
