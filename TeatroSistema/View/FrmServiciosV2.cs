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
    public partial class FrmServiciosV2 : Form
    {
        public FrmServiciosV2()
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

        private void cargarServicios()
        {
            dgvServicios.DataSource = CServicio.Mostrar_Servicios();
            //codigos = new List<int>();
            //foreach (DataRow fila in dgvServicios.Rows)
            //{
            //    codigos.Add(int.Parse(fila["Codigo"].ToString()));
            //} 

            dgvServicios.Columns["Codigo"].Visible = false;
        }
        private void bloquearBotonesFormulario()
        {
            btnSave.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnEstado.Enabled == false) //si es falso es porque le dio al btnadd
            {
                if (!validarCampos())
                {
                    return;
                }
                if (!validarFormato())
                {
                    return;
                }
                string descripcion = txtDescripcion.Text;
                float.TryParse(txtPrecio.Text, out float precio);
                int.TryParse(spnStock.Value.ToString(), out int stock);
                string rpta = CServicio.Crear_Servicio(descripcion, precio, stock, "ACTIVO");
                if (rpta.Equals("Ok"))
                {
                    MessageBox.Show("Servicio añadido con Éxito", "Sistema del Teatro", MessageBoxButtons.OK);
                    desbloquearBotonesTabla();
                }
                else
                {
                    MessageBox.Show("Error al añadir el servicio " + "\nprecio: " + precio +
                        "\ndescripcion: " + descripcion +
                        "\nStock: " + stock + "\n"
                        + rpta, "Sistema del Teatro", MessageBoxButtons.OK);
                    return;
                }

            }
            else //si está activo es porque le dio a actualizar
            {
                if (!validarCampos())
                {
                    return;
                }
                if (!validarFormato())
                {
                    return;
                }
                //codigo para actualizar
                string descripcion = txtDescripcion.Text;
                float.TryParse(txtPrecio.Text, out float precio);
                int.TryParse(spnStock.Value.ToString(), out int stock);
                string rpta = CServicio.Update_Servicio(int.Parse(txtCodigo.Text), descripcion, precio, stock);
                if (rpta.Equals("Ok"))
                {
                    MessageBox.Show("Servicio actualizado con Éxito", "Sistema del Teatro", MessageBoxButtons.OK);
                    desbloquearBotonesTabla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el servicio " + "\nprecio: " + precio +
                        "\ndescripcion: " + descripcion +
                        "\nStock: " + stock + "\n"
                        + rpta, "Sistema del Teatro", MessageBoxButtons.OK);
                    return;
                }
                cargarServicios();
                bloquearBotonesFormulario();
                cerrarCampos();
                limpiarCampos();
                dgvServicios.Enabled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnEstado.Enabled = true;
            abrirCampos();
            bloquearBotonesTabla();
            desbloquearBotonesFormulario();
            dgvServicios.Enabled = false;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta = CServicio.Cambiar_Estado(int.Parse(dgvServicios.CurrentRow.Cells[0].Value.ToString()));
            if (rpta.Equals("Ok"))
            {
                MessageBox.Show("Estado actualizado con Éxito", "Sistema del Teatro", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Error al actualizar el servicio "
                    + rpta, "Sistema del Teatro", MessageBoxButtons.OK);
                return;
            }
            cargarServicios();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnEstado.Enabled = false;
            txtCodigo.Text = (dgvServicios.Rows.Count + 1).ToString();
            dgvServicios.Enabled = false;
            abrirCampos();
            bloquearBotonesTabla();
            desbloquearBotonesFormulario();
            limpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cerrarCampos();
            bloquearBotonesFormulario();
            desbloquearBotonesTabla();
            txtCodigo.Clear();
            dgvServicios.Enabled = true;
        }

        private void FrmServiciosV2_Load(object sender, EventArgs e)
        {
            cerrarCampos();
            cargarServicios();
            bloquearBotonesFormulario();
            dgvServicios.ReadOnly = true;
            dgvServicios.MultiSelect = false;
        }

        private void cerrarCampos()
        {

            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            spnStock.Enabled = false;
        }

        private void bloquearBotonesTabla()
        {
            btnAdd.Enabled = false;
            btnActualizar.Enabled = false;

        }

        private void desbloquearBotonesFormulario()
        {
            btnSave.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void abrirCampos()
        {

            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            spnStock.Enabled = true;
        }

        private void limpiarCampos()
        {
            txtDescripcion.Clear();
            txtPrecio.Clear();
            spnStock.Value = 0;

        }

        private void desbloquearBotonesTabla()
        {
            btnActualizar.Enabled = true;
            btnAdd.Enabled = true;
            btnEstado.Enabled = true;
        }

        private Boolean validarFormato()
        {

            if (!float.TryParse(txtPrecio.Text, out float floati))
            {
                malFormato("Precio"); return false;
            }
            return true;
        }

        private void malFormato(string v)
        {
            MessageBox.Show("Completar el campo " + v + " correctamente", "Mensaje del Sistema", MessageBoxButtons.OK);
        }

        private Boolean validarCampos()
        {

            if (txtDescripcion.Text.Equals(""))
            {
                camposVacios("Descripción"); return false;
            }
            if (txtPrecio.Text.Equals(""))
            {
                camposVacios("Precio"); return false;
            }
            if (spnStock.Value.ToString().Equals(""))
            {
                camposVacios("Stock"); return false;
            }
            return true;
        }

        private void camposVacios(string v)
        {
            MessageBox.Show("Completar el campo " + v, "Mensaje del Sistema", MessageBoxButtons.OK);
        }

        private void dgvServicios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvServicios.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dgvServicios.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvServicios.CurrentRow.Cells[2].Value.ToString();
            spnStock.Value = int.Parse(dgvServicios.CurrentRow.Cells[3].Value.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastrarVentana(sender, e);
        }
    }
}
