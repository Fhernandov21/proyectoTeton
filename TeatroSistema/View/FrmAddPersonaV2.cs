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
    public partial class FrmAddPersonaV2 : Form
    {
        int idActual = 0;
        public FrmAddPersonaV2(int id)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string date = dateTimeFecha.Text;
            string save = CCliente.Crear_Persona(this.idActual, txtFName.Text, txtSName.Text, txtFLName.Text, txtSLName.Text,
                txtDireccion.Text, txtCedula.Text, date, txtTelefono.Text);
            if (save.Equals("OK"))
            {
                MessageBox.Show("Añadido con éxito!!!", "Sistema Teatro", MessageBoxButtons.OK);
                enviarPersonaEvent(this.idActual, "Natural", txtFName.Text + " " + txtFLName.Text, txtDireccion.Text, txtTelefono.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("nooOOOOOOOOOOOOOOOOOOOOOO", date, MessageBoxButtons.OK);

            }
        }

        public delegate void enviarPersona(int id, string tipo, string nombre, string direccion, string telefono);
        public event enviarPersona enviarPersonaEvent;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddPersonaV2_Load(object sender, EventArgs e)
        {
            iniciarTextBox(txtCedula, "ej: 123-123456-1234A");
            iniciarTextBox(txtTelefono, "ej: 12345678");
        }

        private void iniciarTextBox(TextBox txt, string v)
        {
            txt.Text = v;
            txt.ForeColor = Color.Gray;
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

        public void entrando(TextBox txt, string v)
        {
            if (txt.Text.Equals(v))
            {
                txt.Text = "";
                txt.ForeColor = Color.Black;
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            entrando(txtCedula, "ej: 123-123456-1234A");
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            saliendo(txtCedula, "ej: 123-123456-1234A");
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            entrando(txtTelefono, "ej: 12345678");
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            saliendo(txtTelefono, "ej: 12345678");
        }
    }
}
