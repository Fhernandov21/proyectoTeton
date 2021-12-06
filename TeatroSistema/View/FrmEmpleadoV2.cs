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
    public partial class FrmEmpleadoV2 : Form
    {
        public void EsconderBotones()
        {
            btnActualizar.Hide();
            btnCancelar.Hide();
            btnDetalles.Hide();
            btnEstado.Hide();
            btnNuevo.Hide();
            btnSave.Hide();
        }
        public FrmEmpleadoV2()
        {
            
            InitializeComponent();
            btnSeleccionar.Hide();
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.ReadOnly = true;
        }
        public string desde = "";

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

        private void FrmEmpleadoV2_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = CEmpleado.Mostrar_Empleados();
            cerrarCampos();
            cargarEmpleados();
            bloquaerBotonesForm();
            panelTable.Width = 656;
            //if (desde.Equals(""))
            //{

            //    btnSelect.Enabled = false;
            //    btnSelect.Hide();
            //}
            //else
            //{
            //    btnSelect.Enabled = true;
            //    btnSelect.Show();
            //}
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
         
            if (btnEstado.Enabled == false)
            {
                int IdEmpleado = dgvEmpleados.Rows.Count + 1;
                string PrimerNombre = txtprimerNombre.Text;
                string SegundoNombre = txtsegundoNombre.Text;
                string PrimerApellido = txtprimerApellido.Text;
                string SegundoApellido = txtsegundoApellido.Text;
                string Cedula = txtCedula.Text;
                string Direccion = txtDireccion.Text;
                float Salario = float.Parse(txtSalario.Text);
                string Codigo = txtCodigo.Text;

                string rept = CEmpleado.Nuevo_Empleado(IdEmpleado, PrimerNombre, SegundoNombre, PrimerApellido,
                    SegundoApellido, Cedula, Direccion, Salario, Codigo);
                if (rept.Equals("Ok"))
                {
                    MessageBox.Show("Empleado agregado con Éxito", "Sistema de teatro", MessageBoxButtons.OK);
                    desbloquearBotonesTabla();
                }
                else
                {
                    MessageBox.Show("Error al Añadir el Empleado "+rept+" "+Salario, "Sistema de teatro", MessageBoxButtons.OK);
                    return;
                }
            }else
            {
                int.TryParse(dgvEmpleados.CurrentRow.Cells[0].Value.ToString(), out int id);
                string PrimerNombre = txtprimerNombre.Text;
                string SegundoNombre = txtsegundoNombre.Text;
                string PrimerApellido = txtprimerApellido.Text;
                string SegundoApellido = txtsegundoApellido.Text;
                string Cedula = txtCedula.Text;
                string Direccion = txtDireccion.Text;
                float Salario = float.Parse(txtSalario.Text);
                string Codigo = txtCodigo.Text;

                string rept = CEmpleado.Actualizar_Empleado(Convert.ToInt32(id), PrimerNombre, SegundoNombre, PrimerApellido,
                    SegundoApellido, Cedula, Direccion, Salario, Codigo);
                if (rept.Equals("Ok"))
                {
                    MessageBox.Show("Empleado actualizado con Éxito", "Sistema de teatro", MessageBoxButtons.OK);
                    desbloquearBotonesTabla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el Empleado", "Sistema de teatro", MessageBoxButtons.OK);
                    return;
                }
            }
            cargarEmpleados();
            bloquaerBotonesForm();
            cerrarCampos();
            limpiarCampos();
            dgvEmpleados.Enabled = true;
        }

        private void cargarEmpleados()
        {
            dgvEmpleados.DataSource = CEmpleado.Mostrar_Empleados();
        }
        private void limpiarCampos()
        {
            lblIdEmpleado.Text = "Id Empleado:";
            txtprimerNombre.Text = "";
            txtprimerApellido.Text = "";
            txtsegundoNombre.Text = "";
            txtsegundoApellido.Text = "";
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtSalario.Text = "";
            txtCodigo.Text = "";

        }

        private void desbloquearBotonesTabla()
        {
            btnEstado.Enabled = true;
            btnActualizar.Enabled = true;
            btnNuevo.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnEstado.Enabled = false;
            dgvEmpleados.Enabled = false;
            abrirCampos();
            bloquearBotonesTabla();
            desbloquearBotonesForm();
            limpiarCampos();
        }

        private void bloquearBotonesTabla()
        {
            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void bloquaerBotonesForm()
        {
            btnSave.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void desbloquearBotonesForm()
        {
            btnSave.Enabled = true;
            btnCancelar.Enabled = true;
        }
        
        private void abrirCampos()
        {
            //AddEmpleado.Width = 429;
            //this.Width = 1193;
            txtprimerNombre.Enabled = true;
            txtprimerApellido.Enabled = true;
            txtsegundoNombre.Enabled = true;
            txtsegundoApellido.Enabled = true;
            txtCedula.Enabled = true;
            txtDireccion.Enabled = true;
            txtSalario.Enabled = true;
            txtCodigo.Enabled = true;
        }
        private void cerrarCampos()
        {
            //AddEmpleado.Width = 0;
            //this.Width = 764;
            this.dgvEmpleados.DataSource = CEmpleado.Mostrar_Empleados();
            txtprimerNombre.Enabled = false;
            txtprimerApellido.Enabled = false;
            txtsegundoNombre.Enabled = false;
            txtsegundoApellido.Enabled = false;
            txtCedula.Enabled = false;
            txtDireccion.Enabled = false;
            txtSalario.Enabled = false;
            txtCodigo.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            btnEstado.Enabled = true;
            abrirCampos();
            bloquearBotonesTabla();
            desbloquearBotonesForm();
            dgvEmpleados.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cerrarCampos();
            bloquaerBotonesForm();
            desbloquearBotonesTabla();
            dgvEmpleados.Enabled = true;
        }

        private void dgvEmpleados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            string rpta = CEmpleado.Cambiar_Estado_Empleado(int.Parse(dgvEmpleados.CurrentRow.Cells[0].Value.ToString()));
            if (rpta.Equals("Ok"))
            {
                MessageBox.Show("Estado actualizado con Éxito", "Sistema del Teatro", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Error al actualizar el estado del empleado "
                    + rpta, "Sistema del Teatro", MessageBoxButtons.OK);
                return;
            }
            cargarEmpleados();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione una única fila", "Sistema Teatro", MessageBoxButtons.OK);
                return;
            }
            FrmDetalleEmpleado fdet = new FrmDetalleEmpleado();
            int.TryParse(dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString(), out int id);

            fdet.CargarEmpleado(id);
            fdet.Show();
        }

        private void dgvEmpleados_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            
            try
            {
                int.TryParse(dgvEmpleados.CurrentRow.Cells[0].Value.ToString(), out int id);
                
                
                DataTable dt = new DataTable();
                dt = CEmpleado.Mostrar_Detalle_Empleado(id);
                
                if (dt == null)
                {
                    return;
                }
                else
                {
                    lblIdEmpleado.Text = "Id Empleado: " + dt.Rows[0].ItemArray[0];
                    txtprimerNombre.Text = dt.Rows[0].ItemArray[1].ToString();
                    txtsegundoNombre.Text = dt.Rows[0].ItemArray[2].ToString();
                    txtprimerApellido.Text = dt.Rows[0].ItemArray[3].ToString();
                    txtsegundoApellido.Text = dt.Rows[0].ItemArray[4].ToString();
                    txtCedula.Text = dt.Rows[0].ItemArray[5].ToString();
                    txtDireccion.Text = dt.Rows[0].ItemArray[6].ToString();
                    txtSalario.Text = dt.Rows[0].ItemArray[7].ToString();
                    txtCodigo.Text = dt.Rows[0].ItemArray[8].ToString();



                }
            }
            catch (IndexOutOfRangeException ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (System.NullReferenceException exo) 
            {
                return;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
