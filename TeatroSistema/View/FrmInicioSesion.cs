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
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            DataTable dato;
            dato = CUsuario.Validar_Acceso(txtUsuario.Text, txtPass.Text);
            DataTable Rol;
            Rol = CUsuario.ObtenerRol(txtUsuario.Text, txtPass.Text);
            Console.WriteLine(Rol.ToString());
            DataRow DiRol;
            DiRol = Rol.Rows[0];
            if (DiRol["rol"].ToString() == "Cajero")
            {
                f1.usuariosWin.Enabled = false;
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
                dr = dato.Rows[0];

                if (dr["Resultado"].ToString()== "Acceso Exitoso")
                {
                    //string rol = dato.Rows[0][4].ToString();
                    //string nombre = dato.Rows[0][2].ToString();
                    //int.TryParse(dato.Rows[0][0].ToString(), out int IdEmpleado);

                    MessageBox.Show("Bienvenido al sistema!!!", "_.:Sistema Eventos:._", MessageBoxButtons.OK);
               
                    f1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Acceso denegado!!!", "_.:Sistema Eventos:._", MessageBoxButtons.OK);

                }
            }
            else
            {
                MessageBox.Show("No hay conexión al servidor", "    _.:: Sistema Eventos ::._", MessageBoxButtons.OK);

            }
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            label6.Text = "Pista 3: Estás conectándote a " + Conexion.Cn + "\n" +
                "ServerName / DBName / Usuario / Contraseña";
        }
    }
}
