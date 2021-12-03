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

    
    public partial class FrmAddEntidad : Form
    {

        private int idActualjejeje = 0;
        public FrmAddEntidad(int id)
        {
            InitializeComponent();
            this.idActualjejeje = id;
        }

        private void FrmAddEntidad_Load(object sender, EventArgs e)
        {
            iniciarCmb();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dateRep = cmbDay.SelectedItem.ToString() + "-" + cmbMonth.SelectedItem.ToString() + "-" + cmbYear.SelectedItem.ToString();
            
            string save = CCliente.Crear_Entidad(this.idActualjejeje, int.Parse(txtRuc.Text), txtNEntidad.Text, txtDirent.Text, 
                txtCelent.Text,  txtCedula.Text,txtName.Text+" "+txtApellido.Text, txtDirRep.Text, dateRep, txtCelrep.Text);
            if (save.Equals("OK"))
            {
                MessageBox.Show("Añadido con éxito!!!", "Sistema Teatro", MessageBoxButtons.OK);
                enviarEntidadEvent(this.idActualjejeje, "Natural", txtName.Text, txtDirent.Text, txtCelent.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("nooOOOOOOOOOOOOOOOOOOOOOO "+save, dateRep+" id:"+ idActualjejeje, MessageBoxButtons.OK);

            }
        }
        public delegate void enviarEntidad(int id, string tipo, string nombre, string direccion, string telefono);
        public event enviarEntidad enviarEntidadEvent;

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
            for (int i = 0; i <= 149; i++)
            {
                cmbAñosItems[i] = (DateTime.Now.Year - i);

            }

            cmbDay.Items.AddRange(cmbDiasItems);
            cmbMonth.Items.AddRange(cmbMesesItems);
            cmbYear.Items.AddRange(cmbAñosItems);
            cmbDay.SelectedIndex = 0;
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;

        }









        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
