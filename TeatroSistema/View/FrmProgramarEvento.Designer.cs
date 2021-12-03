
namespace TeatroSistema.View
{
    partial class FrmProgramarEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProgramar = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchCliente = new System.Windows.Forms.Button();
            this.btnNewCliente = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAMPMInicio = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbHoraInicio = new System.Windows.Forms.ComboBox();
            this.cmbMinutoInicio = new System.Windows.Forms.ComboBox();
            this.cmbMinutosFinal = new System.Windows.Forms.ComboBox();
            this.cmbHoraFinal = new System.Windows.Forms.ComboBox();
            this.cmbAMPMFinal = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.dgvItinerario = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.lblItinerario = new System.Windows.Forms.Label();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.btnCancelarServicio = new System.Windows.Forms.Button();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.spnCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProgramar
            // 
            this.btnProgramar.Location = new System.Drawing.Point(991, 266);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(163, 80);
            this.btnProgramar.TabIndex = 1;
            this.btnProgramar.Text = "Programar Evento";
            this.btnProgramar.UseVisualStyleBackColor = true;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(19, 365);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 2;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha y Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del Evento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de personas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salón:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cliente";
            // 
            // btnSearchCliente
            // 
            this.btnSearchCliente.Location = new System.Drawing.Point(13, 199);
            this.btnSearchCliente.Name = "btnSearchCliente";
            this.btnSearchCliente.Size = new System.Drawing.Size(107, 28);
            this.btnSearchCliente.TabIndex = 6;
            this.btnSearchCliente.Text = "Buscar Cliente";
            this.btnSearchCliente.UseVisualStyleBackColor = true;
            // 
            // btnNewCliente
            // 
            this.btnNewCliente.Location = new System.Drawing.Point(134, 199);
            this.btnNewCliente.Name = "btnNewCliente";
            this.btnNewCliente.Size = new System.Drawing.Size(107, 28);
            this.btnNewCliente.TabIndex = 6;
            this.btnNewCliente.Text = "Nuevo Cliente";
            this.btnNewCliente.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(13, 233);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(629, 80);
            this.dgvCliente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Información del Evento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Empleado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombres:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Apellidos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Hora de Inicio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 434);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Hora de Finalización:";
            // 
            // cmbAMPMInicio
            // 
            this.cmbAMPMInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAMPMInicio.FormattingEnabled = true;
            this.cmbAMPMInicio.Location = new System.Drawing.Point(514, 399);
            this.cmbAMPMInicio.Name = "cmbAMPMInicio";
            this.cmbAMPMInicio.Size = new System.Drawing.Size(68, 24);
            this.cmbAMPMInicio.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(815, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 80);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar programación";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbHoraInicio
            // 
            this.cmbHoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraInicio.FormattingEnabled = true;
            this.cmbHoraInicio.Location = new System.Drawing.Point(366, 399);
            this.cmbHoraInicio.Name = "cmbHoraInicio";
            this.cmbHoraInicio.Size = new System.Drawing.Size(68, 24);
            this.cmbHoraInicio.TabIndex = 10;
            // 
            // cmbMinutoInicio
            // 
            this.cmbMinutoInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutoInicio.FormattingEnabled = true;
            this.cmbMinutoInicio.Location = new System.Drawing.Point(440, 399);
            this.cmbMinutoInicio.Name = "cmbMinutoInicio";
            this.cmbMinutoInicio.Size = new System.Drawing.Size(68, 24);
            this.cmbMinutoInicio.TabIndex = 10;
            // 
            // cmbMinutosFinal
            // 
            this.cmbMinutosFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutosFinal.FormattingEnabled = true;
            this.cmbMinutosFinal.Location = new System.Drawing.Point(440, 461);
            this.cmbMinutosFinal.Name = "cmbMinutosFinal";
            this.cmbMinutosFinal.Size = new System.Drawing.Size(68, 24);
            this.cmbMinutosFinal.TabIndex = 10;
            // 
            // cmbHoraFinal
            // 
            this.cmbHoraFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraFinal.FormattingEnabled = true;
            this.cmbHoraFinal.Location = new System.Drawing.Point(366, 461);
            this.cmbHoraFinal.Name = "cmbHoraFinal";
            this.cmbHoraFinal.Size = new System.Drawing.Size(68, 24);
            this.cmbHoraFinal.TabIndex = 10;
            // 
            // cmbAMPMFinal
            // 
            this.cmbAMPMFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAMPMFinal.FormattingEnabled = true;
            this.cmbAMPMFinal.Location = new System.Drawing.Point(514, 461);
            this.cmbAMPMFinal.Name = "cmbAMPMFinal";
            this.cmbAMPMFinal.Size = new System.Drawing.Size(68, 24);
            this.cmbAMPMFinal.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 115);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(522, 86);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(215, 22);
            this.textBox5.TabIndex = 11;
            // 
            // cmbSalon
            // 
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(522, 50);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(215, 24);
            this.cmbSalon.TabIndex = 12;
            // 
            // dgvItinerario
            // 
            this.dgvItinerario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItinerario.Location = new System.Drawing.Point(643, 378);
            this.dgvItinerario.Name = "dgvItinerario";
            this.dgvItinerario.RowHeadersWidth = 51;
            this.dgvItinerario.RowTemplate.Height = 24;
            this.dgvItinerario.Size = new System.Drawing.Size(505, 194);
            this.dgvItinerario.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(920, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Reservar Servicios";
            // 
            // lblItinerario
            // 
            this.lblItinerario.AutoSize = true;
            this.lblItinerario.Location = new System.Drawing.Point(708, 339);
            this.lblItinerario.Name = "lblItinerario";
            this.lblItinerario.Size = new System.Drawing.Size(0, 17);
            this.lblItinerario.TabIndex = 4;
            // 
            // dgvServicios
            // 
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(794, 53);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.RowHeadersWidth = 51;
            this.dgvServicios.RowTemplate.Height = 24;
            this.dgvServicios.Size = new System.Drawing.Size(184, 174);
            this.dgvServicios.TabIndex = 13;
            // 
            // btnCancelarServicio
            // 
            this.btnCancelarServicio.Location = new System.Drawing.Point(983, 120);
            this.btnCancelarServicio.Name = "btnCancelarServicio";
            this.btnCancelarServicio.Size = new System.Drawing.Size(163, 49);
            this.btnCancelarServicio.TabIndex = 1;
            this.btnCancelarServicio.Text = "Aceptar";
            this.btnCancelarServicio.UseVisualStyleBackColor = true;
            // 
            // cmbServicios
            // 
            this.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Location = new System.Drawing.Point(985, 53);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(162, 24);
            this.cmbServicios.TabIndex = 14;
            // 
            // spnCantidad
            // 
            this.spnCantidad.Location = new System.Drawing.Point(1059, 87);
            this.spnCantidad.Name = "spnCantidad";
            this.spnCantidad.Size = new System.Drawing.Size(88, 22);
            this.spnCantidad.TabIndex = 15;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(985, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(163, 49);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(985, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Cantidad:";
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Location = new System.Drawing.Point(522, 118);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(95, 24);
            this.cmbCantidad.TabIndex = 12;
            // 
            // FrmProgramarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 582);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.spnCantidad);
            this.Controls.Add(this.cmbServicios);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.dgvItinerario);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.cmbSalon);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbAMPMFinal);
            this.Controls.Add(this.cmbAMPMInicio);
            this.Controls.Add(this.cmbHoraFinal);
            this.Controls.Add(this.cmbHoraInicio);
            this.Controls.Add(this.cmbMinutosFinal);
            this.Controls.Add(this.cmbMinutoInicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btnNewCliente);
            this.Controls.Add(this.btnSearchCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblItinerario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelarServicio);
            this.Controls.Add(this.btnProgramar);
            this.Name = "FrmProgramarEvento";
            this.Text = "FrmProgramarEvento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProgramar;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchCliente;
        private System.Windows.Forms.Button btnNewCliente;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbAMPMInicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbHoraInicio;
        private System.Windows.Forms.ComboBox cmbMinutoInicio;
        private System.Windows.Forms.ComboBox cmbMinutosFinal;
        private System.Windows.Forms.ComboBox cmbHoraFinal;
        private System.Windows.Forms.ComboBox cmbAMPMFinal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.DataGridView dgvItinerario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblItinerario;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Button btnCancelarServicio;
        private System.Windows.Forms.ComboBox cmbServicios;
        private System.Windows.Forms.NumericUpDown spnCantidad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCantidad;
    }
}