
namespace TeatroSistema.View
{
    partial class LosHombresNoLloran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LosHombresNoLloran));
            this.Header = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblItinerario = new System.Windows.Forms.Label();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.spnCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvServiciosReservados = new System.Windows.Forms.DataGridView();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.dgvItinerario = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbAMPMInicio = new System.Windows.Forms.ComboBox();
            this.cmbHoraInicio = new System.Windows.Forms.ComboBox();
            this.cmbMinutoInicio = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCapacidadSalon = new System.Windows.Forms.Label();
            this.lblPrecioSalon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarEmpleado = new System.Windows.Forms.Button();
            this.btnSearchCliente = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosReservados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Header.Controls.Add(this.btnExit);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1305, 44);
            this.Header.TabIndex = 38;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(1260, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbSalon);
            this.panel1.Controls.Add(this.txtDuracion);
            this.panel1.Controls.Add(this.lblItinerario);
            this.panel1.Controls.Add(this.btnEliminarServicio);
            this.panel1.Controls.Add(this.btnAddService);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.spnCantidad);
            this.panel1.Controls.Add(this.dgvServiciosReservados);
            this.panel1.Controls.Add(this.dgvServicios);
            this.panel1.Controls.Add(this.dgvItinerario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cmbAMPMInicio);
            this.panel1.Controls.Add(this.cmbHoraInicio);
            this.panel1.Controls.Add(this.cmbMinutoInicio);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblCapacidadSalon);
            this.panel1.Controls.Add(this.lblPrecioSalon);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.calendario);
            this.panel1.Controls.Add(this.dgvCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSeleccionarEmpleado);
            this.panel1.Controls.Add(this.btnSearchCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 843);
            this.panel1.TabIndex = 39;
            // 
            // cmbSalon
            // 
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(784, 84);
            this.cmbSalon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(269, 24);
            this.cmbSalon.TabIndex = 77;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(381, 382);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuracion.Multiline = true;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(105, 22);
            this.txtDuracion.TabIndex = 76;
            // 
            // lblItinerario
            // 
            this.lblItinerario.AutoSize = true;
            this.lblItinerario.Location = new System.Drawing.Point(21, 494);
            this.lblItinerario.Name = "lblItinerario";
            this.lblItinerario.Size = new System.Drawing.Size(63, 17);
            this.lblItinerario.TabIndex = 75;
            this.lblItinerario.Text = "Itinerario";
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.FlatAppearance.BorderSize = 0;
            this.btnEliminarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnEliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.ForeColor = System.Drawing.Color.Snow;
            this.btnEliminarServicio.Location = new System.Drawing.Point(1061, 514);
            this.btnEliminarServicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(101, 48);
            this.btnEliminarServicio.TabIndex = 74;
            this.btnEliminarServicio.Text = "Eliminar";
            this.btnEliminarServicio.UseVisualStyleBackColor = true;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.Color.Snow;
            this.btnAddService.Location = new System.Drawing.Point(1061, 326);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(101, 48);
            this.btnAddService.TabIndex = 73;
            this.btnAddService.Text = "Aceptar";
            this.btnAddService.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(1031, 718);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 80);
            this.button2.TabIndex = 72;
            this.button2.Text = "Programar Evento ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(727, 718);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 80);
            this.button1.TabIndex = 71;
            this.button1.Text = "Cancelar Programacion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1060, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 24);
            this.label14.TabIndex = 70;
            this.label14.Text = "Cantidad:";
            // 
            // spnCantidad
            // 
            this.spnCantidad.Location = new System.Drawing.Point(1156, 289);
            this.spnCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spnCantidad.Name = "spnCantidad";
            this.spnCantidad.Size = new System.Drawing.Size(91, 22);
            this.spnCantidad.TabIndex = 69;
            // 
            // dgvServiciosReservados
            // 
            this.dgvServiciosReservados.AllowUserToAddRows = false;
            this.dgvServiciosReservados.AllowUserToDeleteRows = false;
            this.dgvServiciosReservados.AllowUserToResizeColumns = false;
            this.dgvServiciosReservados.AllowUserToResizeRows = false;
            this.dgvServiciosReservados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServiciosReservados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiciosReservados.Location = new System.Drawing.Point(633, 514);
            this.dgvServiciosReservados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvServiciosReservados.Name = "dgvServiciosReservados";
            this.dgvServiciosReservados.RowHeadersVisible = false;
            this.dgvServiciosReservados.RowHeadersWidth = 51;
            this.dgvServiciosReservados.RowTemplate.Height = 24;
            this.dgvServiciosReservados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiciosReservados.Size = new System.Drawing.Size(421, 135);
            this.dgvServiciosReservados.TabIndex = 67;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.AllowUserToResizeColumns = false;
            this.dgvServicios.AllowUserToResizeRows = false;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(633, 284);
            this.dgvServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.RowHeadersVisible = false;
            this.dgvServicios.RowHeadersWidth = 51;
            this.dgvServicios.RowTemplate.Height = 24;
            this.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicios.Size = new System.Drawing.Size(421, 199);
            this.dgvServicios.TabIndex = 66;
            // 
            // dgvItinerario
            // 
            this.dgvItinerario.AllowUserToAddRows = false;
            this.dgvItinerario.AllowUserToDeleteRows = false;
            this.dgvItinerario.AllowUserToResizeColumns = false;
            this.dgvItinerario.AllowUserToResizeRows = false;
            this.dgvItinerario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItinerario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItinerario.Location = new System.Drawing.Point(21, 514);
            this.dgvItinerario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvItinerario.Name = "dgvItinerario";
            this.dgvItinerario.RowHeadersVisible = false;
            this.dgvItinerario.RowHeadersWidth = 51;
            this.dgvItinerario.RowTemplate.Height = 24;
            this.dgvItinerario.Size = new System.Drawing.Size(532, 135);
            this.dgvItinerario.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(723, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 24);
            this.label9.TabIndex = 65;
            this.label9.Text = "Servicios Reservados";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(844, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 24);
            this.label13.TabIndex = 64;
            this.label13.Text = "Reservar Servicios";
            // 
            // cmbAMPMInicio
            // 
            this.cmbAMPMInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAMPMInicio.FormattingEnabled = true;
            this.cmbAMPMInicio.Location = new System.Drawing.Point(532, 314);
            this.cmbAMPMInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAMPMInicio.Name = "cmbAMPMInicio";
            this.cmbAMPMInicio.Size = new System.Drawing.Size(68, 24);
            this.cmbAMPMInicio.TabIndex = 61;
            // 
            // cmbHoraInicio
            // 
            this.cmbHoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoraInicio.FormattingEnabled = true;
            this.cmbHoraInicio.Location = new System.Drawing.Point(381, 314);
            this.cmbHoraInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHoraInicio.Name = "cmbHoraInicio";
            this.cmbHoraInicio.Size = new System.Drawing.Size(68, 24);
            this.cmbHoraInicio.TabIndex = 62;
            // 
            // cmbMinutoInicio
            // 
            this.cmbMinutoInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutoInicio.FormattingEnabled = true;
            this.cmbMinutoInicio.Location = new System.Drawing.Point(456, 314);
            this.cmbMinutoInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMinutoInicio.Name = "cmbMinutoInicio";
            this.cmbMinutoInicio.Size = new System.Drawing.Size(68, 24);
            this.cmbMinutoInicio.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(379, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "Duración:";
            // 
            // lblCapacidadSalon
            // 
            this.lblCapacidadSalon.AutoSize = true;
            this.lblCapacidadSalon.Location = new System.Drawing.Point(900, 119);
            this.lblCapacidadSalon.Name = "lblCapacidadSalon";
            this.lblCapacidadSalon.Size = new System.Drawing.Size(79, 17);
            this.lblCapacidadSalon.TabIndex = 59;
            this.lblCapacidadSalon.Text = "Capacidad:";
            // 
            // lblPrecioSalon
            // 
            this.lblPrecioSalon.AutoSize = true;
            this.lblPrecioSalon.Location = new System.Drawing.Point(780, 119);
            this.lblPrecioSalon.Name = "lblPrecioSalon";
            this.lblPrecioSalon.Size = new System.Drawing.Size(52, 17);
            this.lblPrecioSalon.TabIndex = 58;
            this.lblPrecioSalon.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Hora de Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Fecha y Hora";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(25, 281);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 55;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(21, 684);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.Size = new System.Drawing.Size(573, 78);
            this.dgvCliente.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 656);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "Cliente ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(784, 194);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(89, 22);
            this.textBox6.TabIndex = 52;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(784, 151);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(269, 22);
            this.textBox5.TabIndex = 49;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(201, 167);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 22);
            this.textBox3.TabIndex = 51;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 124);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 22);
            this.textBox2.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(637, 193);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 24);
            this.label11.TabIndex = 46;
            this.label11.Text = "Personas:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 22);
            this.textBox1.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(637, 151);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Apellidos: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombres:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(637, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "Salon:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(820, 34);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(234, 24);
            this.label15.TabIndex = 41;
            this.label15.Text = "Información del Evento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Codigo: ";
            // 
            // btnSeleccionarEmpleado
            // 
            this.btnSeleccionarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSeleccionarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarEmpleado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarEmpleado.ForeColor = System.Drawing.Color.Snow;
            this.btnSeleccionarEmpleado.Location = new System.Drawing.Point(44, 209);
            this.btnSeleccionarEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionarEmpleado.Name = "btnSeleccionarEmpleado";
            this.btnSeleccionarEmpleado.Size = new System.Drawing.Size(351, 28);
            this.btnSeleccionarEmpleado.TabIndex = 39;
            this.btnSeleccionarEmpleado.Text = "Buscar Empleado";
            this.btnSeleccionarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnSearchCliente
            // 
            this.btnSearchCliente.FlatAppearance.BorderSize = 0;
            this.btnSearchCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSearchCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCliente.ForeColor = System.Drawing.Color.Snow;
            this.btnSearchCliente.Location = new System.Drawing.Point(20, 769);
            this.btnSearchCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchCliente.Name = "btnSearchCliente";
            this.btnSearchCliente.Size = new System.Drawing.Size(351, 28);
            this.btnSearchCliente.TabIndex = 38;
            this.btnSearchCliente.Text = "Seleccionar / Registrar cliente";
            this.btnSearchCliente.UseVisualStyleBackColor = true;
            // 
            // LosHombresNoLloran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1305, 887);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LosHombresNoLloran";
            this.Text = "LosHombresNoLloran";
            this.Load += new System.EventHandler(this.LosHombresNoLloran_Load);
            this.Header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosReservados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItinerario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblItinerario;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown spnCantidad;
        private System.Windows.Forms.DataGridView dgvServiciosReservados;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.DataGridView dgvItinerario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbAMPMInicio;
        private System.Windows.Forms.ComboBox cmbHoraInicio;
        private System.Windows.Forms.ComboBox cmbMinutoInicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCapacidadSalon;
        private System.Windows.Forms.Label lblPrecioSalon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarEmpleado;
        private System.Windows.Forms.Button btnSearchCliente;
    }
}