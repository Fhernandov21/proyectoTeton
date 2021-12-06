
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsientos));
            this.dgvAsientosDisponibles = new System.Windows.Forms.DataGridView();
            this.lblSalon = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientosDisponibles)).BeginInit();
            this.Header.SuspendLayout();
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
            this.dgvAsientosDisponibles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(228)))));
            this.dgvAsientosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsientosDisponibles.Location = new System.Drawing.Point(9, 67);
            this.dgvAsientosDisponibles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAsientosDisponibles.MultiSelect = false;
            this.dgvAsientosDisponibles.Name = "dgvAsientosDisponibles";
            this.dgvAsientosDisponibles.ReadOnly = true;
            this.dgvAsientosDisponibles.RowHeadersWidth = 51;
            this.dgvAsientosDisponibles.RowTemplate.Height = 24;
            this.dgvAsientosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAsientosDisponibles.Size = new System.Drawing.Size(447, 391);
            this.dgvAsientosDisponibles.TabIndex = 0;
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblSalon.ForeColor = System.Drawing.Color.White;
            this.lblSalon.Location = new System.Drawing.Point(166, 46);
            this.lblSalon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(140, 19);
            this.lblSalon.TabIndex = 1;
            this.lblSalon.Text = "NOMBRE SALON";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(9, 475);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(224, 28);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(231, 475);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(224, 28);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar asiento";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Header.Controls.Add(this.btnExit);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(466, 36);
            this.Header.TabIndex = 3;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(432, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(466, 514);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblSalon);
            this.Controls.Add(this.dgvAsientosDisponibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAsientos";
            this.Text = "frmAsientos";
            this.Load += new System.EventHandler(this.frmAsientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsientosDisponibles)).EndInit();
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvAsientosDisponibles;
        public System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button btnExit;
    }
}