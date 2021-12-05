
namespace TeatroSistema.View
{
    partial class frmAsientos
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
            this.dgvAsientosDisponibles = new System.Windows.Forms.DataGridView();
            this.lblSalon = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsientosDisponibles
            // 
            this.dgvAsientosDisponibles.AllowUserToAddRows = false;
            this.dgvAsientosDisponibles.AllowUserToDeleteRows = false;
            this.dgvAsientosDisponibles.AllowUserToResizeColumns = false;
            this.dgvAsientosDisponibles.AllowUserToResizeRows = false;
            this.dgvAsientosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsientosDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsientosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsientosDisponibles.Location = new System.Drawing.Point(12, 65);
            this.dgvAsientosDisponibles.MultiSelect = false;
            this.dgvAsientosDisponibles.Name = "dgvAsientosDisponibles";
            this.dgvAsientosDisponibles.ReadOnly = true;
            this.dgvAsientosDisponibles.RowHeadersWidth = 51;
            this.dgvAsientosDisponibles.RowTemplate.Height = 24;
            this.dgvAsientosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAsientosDisponibles.Size = new System.Drawing.Size(596, 481);
            this.dgvAsientosDisponibles.TabIndex = 0;
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Location = new System.Drawing.Point(207, 29);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(119, 17);
            this.lblSalon.TabIndex = 1;
            this.lblSalon.Text = "NOMBRE SALON";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(13, 553);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(298, 35);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(310, 553);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(298, 35);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar asiento";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 600);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblSalon);
            this.Controls.Add(this.dgvAsientosDisponibles);
            this.Name = "frmAsientos";
            this.Text = "frmAsientos";
            this.Load += new System.EventHandler(this.frmAsientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvAsientosDisponibles;
        public System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}