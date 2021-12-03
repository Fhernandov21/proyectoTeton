using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using TeatroSistema.View.Subframes;

namespace TeatroSistema.View
{
    
    public partial class FrmMain : Form
    {
        bool maxpress = false;
        public FrmMain()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!maxpress)
            {
                this.WindowState = FormWindowState.Maximized;
                maxpress = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maxpress = false;
            }

        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (!maxpress)
            {
                this.WindowState = FormWindowState.Maximized;
                maxpress = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maxpress = false;
            }
        }

        

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarVentana(sender,e);
        }

        public static  void MostrarFrames(Panel content ,Form FormChild)
        {
            if (content.Controls.Count > 0)
            {
                content.Controls.RemoveAt(0);
            }
            FormChild.TopLevel = false;
            //FormChild.Dock = DockStyle.Fill;
            content.Controls.Add(FormChild);
            content.Tag = FormChild;
            FormChild.Show();
        }

        public void SeleccionandoBoton(Button sender)
        {
            btnCata.ForeColor = Color.White;
            btnOpe.ForeColor = Color.White;
            btnRepo.ForeColor = Color.White;
            btnSegu.ForeColor = Color.White;

            sender.Enabled = true;
            if(sender.Enabled)
            {
                sender.ForeColor = Color.FromArgb(0, 122, 204);
            }

        }

        public void SeguirBoton(Button sender)
        {
            Flecha.Top = sender.Top;
            Flecha.Visible = true;
        }

        private void btnCata_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            SeguirBoton((Button)sender);
            MostrarFrames(this.Menu, new FrmCatalogo(this.Content));
        }

        private void btnSegu_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            SeguirBoton((Button)sender);
            MostrarFrames(this.Menu, new FrmSeguridad(this.Content));
        }

        private void btnRepo_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            SeguirBoton((Button)sender);
            MostrarFrames(this.Menu, new FrmReportes(this.Content));
        }

        private void btnOpe_Click(object sender, EventArgs e)
        {
            SeleccionandoBoton((Button)sender);
            SeguirBoton((Button)sender);
            MostrarFrames(this.Menu, new FrmOperaciones(this.Content));
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Flecha.Visible = false;
        }
    }
}
