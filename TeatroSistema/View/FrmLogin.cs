using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using TeatroSistema.Data;
using TeatroSistema.Controller;

namespace TeatroSistema.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnIniciarSecion_Click(object sender, EventArgs e)
        {
            FrmMain f1 = new FrmMain();
            DataTable dato;
            dato = CUsuario.Validar_Acceso(txtUsuario.Text, txtPass.Text);
            DataTable Rol;
            Rol = CUsuario.ObtenerRol(txtUsuario.Text, txtPass.Text);
            DataRow DiRol;
            try
            {
                
                DiRol = Rol.Rows[0];
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show("Usuario o Contraseña inválida", "Sistema Teatro", MessageBoxButtons.OK); return;
            }
            //Console.WriteLine(Rol.ToString());
            
            if (DiRol["rol"].ToString() == "Cajero")
            {
                //f1.usuariosWin.Enabled = false;
            }
            if (DiRol["rol"].ToString() == "Recepcionista")
            {

            }
            if (DiRol["rol"].ToString() == "Reportes")
            {

            }
            if (dato != null)
            {
                DataRow dr;


                MessageBox.Show("Bienvenido al sistema!!!", "_.:Sistema Eventos:._", MessageBoxButtons.OK);

                f1.Show();
                this.Hide();
            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
            lblConextion.Text = "Pista 3: Estás conectándote a \n" + Conexion.Cn + "\n" + "ServerName / DBName / Usuario / Contraseña";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                btnIniciarSecion_Click(sender, e);
            }
        }
    }
}
