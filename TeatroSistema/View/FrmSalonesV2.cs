using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatroSistema.Controller;
using TeatroSistema.Data;

namespace TeatroSistema.View
{
    public partial class FrmSalonesV2 : Form
    {
        public FrmSalonesV2()
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

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarVentana(sender, e);
        }

        private void CargarSalones()
        {

            dgvSalones.DataSource = CSalon.MostrarSalones();

        }
        private void cerrarCampos()
        {
            txtNombreSalon.Enabled = false;
            txtNoSalon.Enabled = false;
            txtPath.Enabled = false;
            txtPersonasCant.Enabled = false;
            txtPrecio.Enabled = false;

        }

        private void abrirCampos()
        {
            txtNombreSalon.Enabled = true;

            txtPath.Enabled = true;
            txtPersonasCant.Enabled = true;
            txtPrecio.Enabled = true;

        }
        private void LimpiarCampos()
        {
            txtNombreSalon.Clear();
            txtNoSalon.Clear();
            txtPath.Clear();
            txtPersonasCant.Clear();
            txtPrecio.Clear();
        }

        private void AbrirBotones()
        {

            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;

        }
        public void SetearImagen(string ruta)
        {
            if (txtPath.Text.Length == 0)
            {

            }
            else
            {
                //string ruta;
                //ruta =  ;
                //pictureBox1.Image = Image.From(ruta);
                pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, txtPath.Text));
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnCancelar.Enabled = true;
            btnActualizar.Enabled = false;
            btnBrowse.Enabled = true;
            btnCrear.Enabled = true;
            LimpiarCampos();
            abrirCampos();
            txtNoSalon.Enabled = true;
            dgvSalones.Enabled = false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtNoSalon.Enabled == true)
            {
                int NoSalon = int.Parse(txtNoSalon.Text);
                string NombreSalon = txtNombreSalon.Text;
                float Precio = float.Parse(txtPrecio.Text);
                int Capacidad = int.Parse(txtPersonasCant.Text);
                string Path = txtPath.Text;
                try
                {
                    DSalon instance = new DSalon();
                    instance.InsertarSalon(NoSalon, NombreSalon, Precio, Capacidad, Path);
                    Console.WriteLine("Se inserto papi");
                    dgvSalones.DataSource = instance.MostrarSalones();
                }
                catch (Exception ex)
                {

                }
                cerrarCampos();
                AbrirBotones();

            }
            else
            {
                txtNoSalon.Text = dgvSalones.CurrentRow.Cells[0].Value.ToString();
                txtPath.Text = dgvSalones.CurrentRow.Cells[4].Value.ToString();
                int NoSalon = int.Parse(txtNoSalon.Text);
                string NombreSalon = txtNombreSalon.Text;
                float Precio = float.Parse(txtPrecio.Text);
                int Capacidad = int.Parse(txtPersonasCant.Text);
                string Path = txtPath.Text;
                DSalon instance = new DSalon();
                instance.ActualizarSalon(NoSalon, NombreSalon, Precio, Capacidad, Path);
                Console.WriteLine("Se actualizo pa");
                CargarSalones();
                AbrirBotones();
                dgvSalones.Enabled = true;
            }
            dgvSalones.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnBrowse.Enabled = true;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            abrirCampos();
            btnCrear.Enabled = true;
            dgvSalones.Enabled = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string ruta;
            var fd = new OpenFileDialog();
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
            {
                ruta = fd.FileName;
                pictureBox1.Image = Image.FromFile(ruta);
                txtPath.Text = fd.FileName;
                Console.WriteLine(fd.FileName);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSalonesV2_Load(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            cerrarCampos();
            CargarSalones();
            btnBrowse.Enabled = false;
            btnCrear.Enabled = false;
            dgvSalones.ReadOnly = true;
            dgvSalones.MultiSelect = false;
        }
    }
}
