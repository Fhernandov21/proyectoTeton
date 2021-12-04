
namespace TeatroSistema.View.Subframes
{
    partial class FrmOperaciones
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
            this.btnProgramarEvento = new System.Windows.Forms.Button();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProgramarEvento
            // 
            this.btnProgramarEvento.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProgramarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramarEvento.ForeColor = System.Drawing.Color.White;
            this.btnProgramarEvento.Location = new System.Drawing.Point(0, 0);
            this.btnProgramarEvento.Name = "btnProgramarEvento";
            this.btnProgramarEvento.Size = new System.Drawing.Size(139, 33);
            this.btnProgramarEvento.TabIndex = 1;
            this.btnProgramarEvento.Text = "Programar Evento";
            this.btnProgramarEvento.UseVisualStyleBackColor = true;
            this.btnProgramarEvento.Click += new System.EventHandler(this.btnProgramarEvento_Click);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRealizarVenta.Location = new System.Drawing.Point(139, 0);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(139, 33);
            this.btnRealizarVenta.TabIndex = 2;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            // 
            // FrmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 33);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.btnProgramarEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOperaciones";
            this.Text = "FrmOperaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProgramarEvento;
        private System.Windows.Forms.Button btnRealizarVenta;
    }
}