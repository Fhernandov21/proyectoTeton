
namespace TeatroSistema.View.Subframes
{
    partial class FrmReportes
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
            this.btnFacturarEvento = new System.Windows.Forms.Button();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFacturarEvento
            // 
            this.btnFacturarEvento.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFacturarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturarEvento.ForeColor = System.Drawing.Color.White;
            this.btnFacturarEvento.Location = new System.Drawing.Point(0, 0);
            this.btnFacturarEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFacturarEvento.Name = "btnFacturarEvento";
            this.btnFacturarEvento.Size = new System.Drawing.Size(190, 41);
            this.btnFacturarEvento.TabIndex = 1;
            this.btnFacturarEvento.Text = "Recaudación de Ventas";
            this.btnFacturarEvento.UseVisualStyleBackColor = true;
            this.btnFacturarEvento.Click += new System.EventHandler(this.btnFacturarEvento_Click);
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFactura.ForeColor = System.Drawing.Color.White;
            this.btnCancelarFactura.Location = new System.Drawing.Point(190, 0);
            this.btnCancelarFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(156, 41);
            this.btnCancelarFactura.TabIndex = 2;
            this.btnCancelarFactura.Text = "Cancelar Factura";
            this.btnCancelarFactura.UseVisualStyleBackColor = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1067, 41);
            this.Controls.Add(this.btnCancelarFactura);
            this.Controls.Add(this.btnFacturarEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFacturarEvento;
        private System.Windows.Forms.Button btnCancelarFactura;
    }
}