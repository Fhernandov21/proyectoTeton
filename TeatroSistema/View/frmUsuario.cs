using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatroSistema.Controller;
namespace TeatroSistema.View
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cerrarCampos();
            

        }

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            abrirCampos();
            this.btnEstado.Enabled = false;
            
            this.btnModificar.Enabled = false;
            this.btnNuevo.Enabled = true;
            this.btnGuardar.Enabled = true;

            this.txtUsuario.Focus();




        }

        private void abrirCampos()
        {
            this.txtContraseña.Enabled = true;
            this.txtUsuario.Enabled = true;
            this.txtRepetirContraseña.Enabled = true;
            this.cmbRol.Enabled = true;
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
                string save = CUsuario.Update_Usuario(Convert.ToInt32(id),txtUsuario.Text,
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

        
            private bool validarCampos()
            {
                if (txtContraseña.Text.Length == 0)
                {
                    camposVacios("Contraseña"); return false;
                }
                if (txtRepetirContraseña.Text.Length == 0)
                {
                    camposVacios("Repetir Contraseña"); return false;
                }
                if (txtUsuario.Text.Length == 0)
                {
                    camposVacios("Usuario"); return false;
                }
                /*if (txtUsuario.Text.All(char.IsLetter))
                {
                    malFormato("Usuario"); return false;
                }*/
            if (!txtContraseña.Text.Equals(txtRepetirContraseña.Text)){
                MessageBox.Show("Contraseñas no coinciden");
            }
                return true;
            }

            private void malFormato(string v)
            {
                MessageBox.Show("Formato no vàlido en el campo " + v);
            }

            private void camposVacios(string v)
            {
                MessageBox.Show("Debe completar el campo " + v);
            }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dtUsuario.DataSource = CUsuario.Mostrar_Usuario();
            this.btnGuardar.Enabled = false;
            cerrarCampos();
            vaciarCampos();
            this.btnNuevo.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnEstado.Enabled = true;
        }

        private void vaciarCampos()
        {

            txtUsuario.Text = ""; txtContraseña.Text = ""; txtRepetirContraseña.Text = "";
            cmbRol.SelectedIndex = 0;


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            abrirCampos();
            this.btnEstado.Enabled = false;
            if (dtUsuario.SelectedRows.Count !=1)
            {
                MessageBox.Show("Debe seleccionar UNA fila!!", "Sistema Teatro", MessageBoxButtons.OK);
                return;
            }

            lblID.Text = "ID del Empleado: " + dtUsuario.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = dtUsuario.CurrentRow.Cells[1].Value.ToString();
            txtContraseña.Text = dtUsuario.CurrentRow.Cells[2].Value.ToString();
            txtRepetirContraseña.Text = dtUsuario.CurrentRow.Cells[2].Value.ToString();
            cmbRol.SelectedItem = dtUsuario.CurrentRow.Cells[3].Value.ToString();

            this.txtContraseña.Enabled = true;
            this.txtUsuario.Enabled = true;
            this.txtRepetirContraseña.Enabled = true;
            this.cmbRol.Enabled = true;
            this.btnModificar.Enabled = true;
            this.btnNuevo.Enabled = false;
            this.btnGuardar.Enabled = true;

            this.txtUsuario.Focus();

        }

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
    }

