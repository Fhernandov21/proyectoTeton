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
    public partial class frmAddPersona : Form
    {
        private int idActualjejeje = 0;
        public frmAddPersona(int id)
        {
            InitializeComponent();
            this.idActualjejeje = id;
        }
        
        private void frmAddPersona_Load(object sender, EventArgs e)
        {
            iniciarCmb();
            iniciarTextBox(txtCedula, "ej: 123-123456-1234A");
            iniciarTextBox(txtTelefono, "ej: 12345678");
        }

        private void iniciarTextBox(TextBox txt, string v)
        {
            txt.Text = v;
            txt.ForeColor = Color.Gray;
        }
        private void iniciarCmb()
        {
            object[] cmbDiasItems = new object[31];
            for (int i = 0; i <= 30; i++)
            {
                cmbDiasItems[i] = (i + 1);

            }
            object[] cmbMesesItems = new object[12];
            for (int i = 0; i <= 11; i++)
            {
                cmbMesesItems[i] = (i + 1);

            }
            object[] cmbAñosItems = new object[150];
            for (int i =0 ; i <= 149; i++)
            {
                cmbAñosItems[i] = (DateTime.Now.Year-i);

            }

            cmbDay.Items.AddRange(cmbDiasItems);
            cmbMonth.Items.AddRange(cmbMesesItems);
            cmbYear.Items.AddRange(cmbAñosItems);
            cmbDay.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;

        }

        
        private void txtTelefono_Enter(object sender, EventArgs e)
        {

            entrando(txtTelefono, "ej: 12345678");
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            saliendo(txtTelefono, "ej: 12345678"); 
        }



        private void txtCedula_Enter(object sender, EventArgs e)
        {
            entrando(txtCedula, "ej: 123-123456-1234A"); 
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            saliendo(txtCedula, "ej: 123-123456-1234A");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            validarCampos();
            string date = cmbDay.SelectedItem.ToString() +"-"+ cmbMonth.SelectedItem.ToString() + "-" + cmbYear.SelectedItem.ToString();
            string save = CCliente.Crear_Persona(this.idActualjejeje, txtFName.Text, txtSName.Text, txtFLName.Text, txtSLName.Text,
                txtDireccion.Text, txtCedula.Text, date, txtTelefono.Text);
            if (save.Equals("OK"))
            {
                MessageBox.Show("Añadido con éxito!!!", "Sistema Teatro", MessageBoxButtons.OK);
                enviarPersonaEvent(this.idActualjejeje, "Natural", txtFName.Text + " " + txtFLName.Text, txtDireccion.Text, txtTelefono.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("nooOOOOOOOOOOOOOOOOOOOOOO", date, MessageBoxButtons.OK);
                
            }

        }

        private void validarCampos()
        {
            
        }

        private void frmAddPersona_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }


        //

        public delegate void enviarPersona(int id, string tipo, string nombre, string direccion, string telefono);
        public event enviarPersona enviarPersonaEvent; 
    }
}
