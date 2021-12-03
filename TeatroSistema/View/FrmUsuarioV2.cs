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
    public partial class FrmUsuarioV2 : Form
    {
        
        public FrmUsuarioV2()
        {
            InitializeComponent();
            dtUsuario.ReadOnly = true;
            dtUsuario.MultiSelect = false;
        }

        // PARA ARRASTRAR LA VENTANA

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

        // BOTÓN PARA SALIR
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // EVENTOS
            // CARGA EL FRM
        private void FrmUsuarioV2_Load(object sender, EventArgs e)
        {
            this.Width = 1144;
            this.Height = 380;
            cerrarCampos();
        }
              
            // RECOGE LOS VALORES DE LA TABLA PARA INGRESARLOS A LOS CAMPOS DE TEXTO
        private void dtUsuario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //0 id 
            //1 user }
            //2 contraseña
            //3 rol
            //4 estado

            lblID.Text = "ID del Empleado: " + dtUsuario.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = dtUsuario.CurrentRow.Cells[1].Value.ToString();
            txtContraseña.Text = dtUsuario.CurrentRow.Cells[2].Value.ToString();
            txtRepetirContraseña.Text = dtUsuario.CurrentRow.Cells[2].Value.ToString();
            cmbRol.SelectedItem = dtUsuario.CurrentRow.Cells[3].Value.ToString();
        }

        // ASIGNACION DE EVENTOS DE CADA BOTÓN

        private void btnEstado_Click(object sender, EventArgs e)
        {
            int.TryParse(dtUsuario.CurrentRow.Cells[0].Value.ToString(), out int IdUsuario);
            //MessageBox.Show(IdUsuario.ToString(),"holamundo");
            string save = CUsuario.Cambiar_EstadoUsuario(IdUsuario);
            if (save.Equals("OK"))
            {
                MessageBox.Show("Omg esto va a ser épico papus", "dale select * from usuarios en sql");
            }
            else
            {
                MessageBox.Show("ven y sana este dooOLOOOOOOOOOOOOOOOOOOOOOOR", "no guardo jejeje");
            }
            this.dtUsuario.DataSource = CUsuario.Mostrar_Usuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }



            if (this.btnModificar.Enabled == true)
            {
                int.TryParse(dtUsuario.CurrentRow.Cells[0].Value.ToString(), out int id);
                string estado = dtUsuario.CurrentRow.Cells[4].Value.ToString();
                string save = CUsuario.Update_Usuario(Convert.ToInt32(id), txtUsuario.Text,
                txtContraseña.Text, cmbRol.SelectedItem.ToString(), estado);

                if (save.Equals("OK"))
                {
                    MessageBox.Show("Omg esto va a ser épico papus", "dale select * from usuarios en sql");
                }
                else
                {
                    MessageBox.Show("ven y sana este dooOLOOOOOOOOOOOOOOOOOOOOOOR", "no guardo jejeje");
                }
            }
            else if (this.btnNuevo.Enabled == true)
            {
                string save = CUsuario.Insertar_Usuario(txtUsuario.Text,
                txtContraseña.Text, cmbRol.SelectedItem.ToString());

                if (save.Equals("OK"))
                {
                    MessageBox.Show("Omg esto va a ser épico papus", "dale select * from usuarios en sql");
                }
                else
                {
                    MessageBox.Show("ven y sana este dooOLOOOOOOOOOOOOOOOOOOOOOOR", "no guardo jejeje");
                }
            }
            this.dtUsuario.DataSource = CUsuario.Mostrar_Usuario();
            this.btnGuardar.Enabled = false;
            this.btnEstado.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnNuevo.Enabled = true;
            vaciarCampos();
            cerrarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            abrirCampos();
            this.btnEstado.Enabled = false;
            if (dtUsuario.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe seleccionar UNA fila!!", "Sistema Teatro", MessageBoxButtons.OK);
                return;
            }

            tablaACampos();

            this.txtContraseña.Enabled = true;
            this.txtUsuario.Enabled = true;
            this.txtRepetirContraseña.Enabled = true;
            this.cmbRol.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnNuevo.Enabled = false;
            this.btnGuardar.Enabled = true;

            this.txtUsuario.Focus();
        }

        private void tablaACampos()
        {
            lblID.Text = "ID del Empleado: " + dtUsuario.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = dtUsuario.CurrentRow.Cells[1].Value.ToString();
            cmbRol.SelectedItem = dtUsuario.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            abrirCampos();
            this.btnEstado.Enabled = false;

            this.btnModificar.Enabled = false;
            this.btnNuevo.Enabled = true;
            this.btnGuardar.Enabled = true;

            this.txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.dtUsuario.DataSource = CUsuario.Mostrar_Usuario();
            this.btnGuardar.Enabled = false;
            cerrarCampos();
            vaciarCampos();
            this.btnNuevo.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnEstado.Enabled = true;
        }

        // FUNCIONES CAMBIO DE EVENTO DE LOS CAMPOS DE TEXTO
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.FromArgb(15, 15, 15);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.FromArgb(15, 15, 15);
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.FromArgb(15, 15, 15);
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.FromArgb(15, 15, 15);
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void txtRepetirContraseña_Enter(object sender, EventArgs e)
        {
            if (txtRepetirContraseña.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtRepetirContraseña.Text = "";
                txtRepetirContraseña.ForeColor = Color.FromArgb(15, 15, 15);
                txtRepetirContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtRepetirContraseña_Leave(object sender, EventArgs e)
        {
            if (txtRepetirContraseña.Text == "")
            {
                txtRepetirContraseña.Text = "CONFIRMAR CONTRASEÑA";
                txtRepetirContraseña.ForeColor = Color.FromArgb(15, 15, 15);
                txtRepetirContraseña.UseSystemPasswordChar = false;
            }
        }

        // FUNCIONES UTILES
        private void cerrarCampos()
        {
            cmbRol.SelectedIndex = 0;
            this.dtUsuario.DataSource = CUsuario.Mostrar_Usuario();
            this.btnGuardar.Enabled = false;
            this.txtContraseña.Enabled = false;
            this.txtUsuario.Enabled = false;
            this.txtRepetirContraseña.Enabled = false;
            this.cmbRol.Enabled = false;
        }
        private void abrirCampos()
        {
            this.txtContraseña.Enabled = true;
            this.txtUsuario.Enabled = true;
            this.txtRepetirContraseña.Enabled = true;
            this.cmbRol.Enabled = true;
        }

        private void malFormato(string v)
        {
            MessageBox.Show("Formato no vàlido en el campo " + v);
        }

        private void camposVacios(string v)
        {
            MessageBox.Show("Debe completar el campo " + v);
        }

        private void VariosCamposVacios(string[] v)
        {
            string campos = "";
            foreach (string campo in v)
            {
                campos += $"{campo}";
            }
            MessageBox.Show("Debe rellenar los campos:" + campos);
        }

        private void vaciarCampos()
        {
            txtUsuario.Text = "USUARIO"; txtContraseña.Text = "CONTRASEÑA"; txtRepetirContraseña.Text = "CONFIRMAR CONTRASEÑA";
            cmbRol.SelectedIndex = 0;
        }

        // VALIDACION DE CAMPOS DE TEXTO
        private bool validarCampos()
        {
            if ((txtUsuario.Text == "USUARIO" || txtUsuario.Text == "") &&
                (txtContraseña.Text == "CONTRASEÑA" || txtContraseña.Text == "") &&
                (txtRepetirContraseña.Text == "CONFIRMAR CONTRASEÑA" || txtRepetirContraseña.Text == ""))
            {
                string[] campos = { "USUARIO, ", "CONTRASEÑA", " y REPETIR CONTRASEÑA." };
                VariosCamposVacios(campos); return false;
            }
            if (txtUsuario.Text == "USUARIO" && txtContraseña.Text == "CONTRASEÑA")
            {
                string[] campos = { "USUARIO ", "y CONTRASEÑA." };
                VariosCamposVacios(campos); return false;
            }
            if (txtUsuario.Text == "USUARIO" && txtRepetirContraseña.Text == "CONFIRMAR CONTRASEÑA")
            {
                string[] campos = { "USUARIO ", "y CONFIRMAR CONTRASEÑA." };
                VariosCamposVacios(campos); return false;
            }
            if (txtContraseña.Text == "CONTRASEÑA" && txtRepetirContraseña.Text == "CONFIRMAR CONTRASEÑA")
            {
                string[] campos = { "CONTRASEÑA ", "y CONFIRMAR CONTRASEÑA." };
                VariosCamposVacios(campos); return false;
            }
            if (txtUsuario.Text == "USUARIO" || txtUsuario.Text == "")
            {
                camposVacios("Usuario"); return false;
            }
            if (txtContraseña.Text == "CONTRASEÑA" || txtContraseña.Text == "")
            {
                camposVacios("Contraseña"); return false;
            }
            if (txtRepetirContraseña.Text == "CONFIRMAR CONTRASEÑA" || txtRepetirContraseña.Text == "")
            {
                camposVacios("Confirmar Contraseña"); return false;
            }
            if (!txtContraseña.Text.Equals(txtRepetirContraseña.Text))
            {
                MessageBox.Show("Contraseñas no coinciden");
            }
            return true;
        }

        private void dtUsuario_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tablaACampos();
        }
    }

}
