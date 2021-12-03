
namespace TeatroSistema.View
{
    partial class frmCliente
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.Entidades = new System.Windows.Forms.Label();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnEntidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(17, 567);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(121, 48);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo Cliente Natural";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Entidades
            // 
            this.Entidades.AutoSize = true;
            this.Entidades.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entidades.Location = new System.Drawing.Point(339, 9);
            this.Entidades.Name = "Entidades";
            this.Entidades.Size = new System.Drawing.Size(102, 30);
            this.Entidades.TabIndex = 5;
            this.Entidades.Text = "Clientes";
            this.Entidades.Click += new System.EventHandler(this.Entidades_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(269, 568);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(121, 48);
            this.btnDetalles.TabIndex = 1;
            this.btnDetalles.Text = "Ver detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(17, 66);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(741, 495);
            this.dgvClientes.TabIndex = 6;
            // 
            // btnEntidad
            // 
            this.btnEntidad.Location = new System.Drawing.Point(144, 569);
            this.btnEntidad.Name = "btnEntidad";
            this.btnEntidad.Size = new System.Drawing.Size(119, 47);
            this.btnEntidad.TabIndex = 7;
            this.btnEntidad.Text = "Nuevo Cliente Jurídico";
            this.btnEntidad.UseVisualStyleBackColor = true;
            this.btnEntidad.Click += new System.EventHandler(this.btnEntidad_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 627);
            this.Controls.Add(this.btnEntidad);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.Entidades);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnNuevo);
            this.MaximumSize = new System.Drawing.Size(794, 674);
            this.MinimumSize = new System.Drawing.Size(794, 674);
            this.Name = "frmCliente";
            this.Text = "Clientes del Teatro";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label Entidades;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnEntidad;
    }
}