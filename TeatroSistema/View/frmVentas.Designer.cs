
namespace TeatroSistema.View
{
    partial class frmVentas
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
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvAsientos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddBoleto = new System.Windows.Forms.Button();
            this.btnEliminarBoleto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnVerAsientos = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.AllowUserToResizeColumns = false;
            this.dgvEventos.AllowUserToResizeRows = false;
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(15, 98);
            this.dgvEventos.MultiSelect = false;
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersWidth = 51;
            this.dgvEventos.RowTemplate.Height = 24;
            this.dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventos.Size = new System.Drawing.Size(835, 157);
            this.dgvEventos.TabIndex = 0;
            this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
            this.dgvEventos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calendario de Eventos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Datos del Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cédula:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(99, 305);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(116, 22);
            this.txtPrecio.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Buscar:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(74, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(776, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 455);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(348, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(87, 427);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(191, 22);
            this.txtCedula.TabIndex = 3;
            this.txtCedula.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCedula_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Porcentaje Teatro:";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Enabled = false;
            this.txtPorcentaje.Location = new System.Drawing.Point(346, 305);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(89, 22);
            this.txtPorcentaje.TabIndex = 3;
            this.txtPorcentaje.Text = "0.50";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(865, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 343);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(1040, 447);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(167, 38);
            this.btnVenta.TabIndex = 7;
            this.btnVenta.Text = "Realizar venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(865, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 38);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar venta";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvAsientos
            // 
            this.dgvAsientos.AllowUserToAddRows = false;
            this.dgvAsientos.AllowUserToDeleteRows = false;
            this.dgvAsientos.AllowUserToResizeColumns = false;
            this.dgvAsientos.AllowUserToResizeRows = false;
            this.dgvAsientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsientos.Location = new System.Drawing.Point(450, 298);
            this.dgvAsientos.MultiSelect = false;
            this.dgvAsientos.Name = "dgvAsientos";
            this.dgvAsientos.ReadOnly = true;
            this.dgvAsientos.RowHeadersWidth = 51;
            this.dgvAsientos.RowTemplate.Height = 24;
            this.dgvAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsientos.Size = new System.Drawing.Size(400, 143);
            this.dgvAsientos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Asientos Disponibles:";
            // 
            // btnAddBoleto
            // 
            this.btnAddBoleto.Location = new System.Drawing.Point(20, 341);
            this.btnAddBoleto.Name = "btnAddBoleto";
            this.btnAddBoleto.Size = new System.Drawing.Size(402, 34);
            this.btnAddBoleto.TabIndex = 7;
            this.btnAddBoleto.Text = "Agregar boleto";
            this.btnAddBoleto.UseVisualStyleBackColor = true;
            this.btnAddBoleto.Click += new System.EventHandler(this.btnAddBoleto_Click);
            // 
            // btnEliminarBoleto
            // 
            this.btnEliminarBoleto.Location = new System.Drawing.Point(448, 447);
            this.btnEliminarBoleto.Name = "btnEliminarBoleto";
            this.btnEliminarBoleto.Size = new System.Drawing.Size(402, 34);
            this.btnEliminarBoleto.TabIndex = 7;
            this.btnEliminarBoleto.Text = "Eliminar Boleto";
            this.btnEliminarBoleto.UseVisualStyleBackColor = true;
            this.btnEliminarBoleto.Click += new System.EventHandler(this.btnEliminarBoleto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Asientos ordenados:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Asiento:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 277);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 22);
            this.textBox2.TabIndex = 10;
            // 
            // btnVerAsientos
            // 
            this.btnVerAsientos.Location = new System.Drawing.Point(154, 272);
            this.btnVerAsientos.Name = "btnVerAsientos";
            this.btnVerAsientos.Size = new System.Drawing.Size(61, 27);
            this.btnVerAsientos.TabIndex = 7;
            this.btnVerAsientos.Text = "Ver...";
            this.btnVerAsientos.UseVisualStyleBackColor = true;
            this.btnVerAsientos.Click += new System.EventHandler(this.btnVerAsientos_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "ID Comprador:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(389, 427);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(46, 22);
            this.txtID.TabIndex = 10;
            this.txtID.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1037, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Empleado: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1111, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(16, 17);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "0";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 497);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerAsientos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnEliminarBoleto);
            this.Controls.Add(this.btnAddBoleto);
            this.Controls.Add(this.dgvAsientos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEventos);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvAsientos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddBoleto;
        private System.Windows.Forms.Button btnEliminarBoleto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnVerAsientos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblID;
    }
}