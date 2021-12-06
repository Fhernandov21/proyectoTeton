
namespace TeatroSistema.View.Reportes
{
    partial class frmFacturaVenta
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Mostrar_FacturaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtVentas = new TeatroSistema.View.Reportes.dtVentas();
            this.MostrarDetalle_FacturaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Mostrar_FacturaVentaTableAdapter = new TeatroSistema.View.Reportes.dtVentasTableAdapters.Mostrar_FacturaVentaTableAdapter();
            this.MostrarDetalle_FacturaVentaTableAdapter = new TeatroSistema.View.Reportes.dtVentasTableAdapters.MostrarDetalle_FacturaVentaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_FacturaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDetalle_FacturaVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Mostrar_FacturaVentaBindingSource
            // 
            this.Mostrar_FacturaVentaBindingSource.DataMember = "Mostrar_FacturaVenta";
            this.Mostrar_FacturaVentaBindingSource.DataSource = this.dtVentas;
            // 
            // dtVentas
            // 
            this.dtVentas.DataSetName = "dtVentas";
            this.dtVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MostrarDetalle_FacturaVentaBindingSource
            // 
            this.MostrarDetalle_FacturaVentaBindingSource.DataMember = "MostrarDetalle_FacturaVenta";
            this.MostrarDetalle_FacturaVentaBindingSource.DataSource = this.dtVentas;
            // 
            // Mostrar_FacturaVentaTableAdapter
            // 
            this.Mostrar_FacturaVentaTableAdapter.ClearBeforeFill = true;
            // 
            // MostrarDetalle_FacturaVentaTableAdapter
            // 
            this.MostrarDetalle_FacturaVentaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Mostrar_FacturaVentaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.MostrarDetalle_FacturaVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TeatroSistema.View.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(74, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(739, 544);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 632);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmFacturaVenta";
            this.Text = "frmFacturaVenta";
            this.Load += new System.EventHandler(this.frmFacturaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar_FacturaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDetalle_FacturaVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Mostrar_FacturaVentaBindingSource;
        private dtVentas dtVentas;
        private System.Windows.Forms.BindingSource MostrarDetalle_FacturaVentaBindingSource;
        private dtVentasTableAdapters.Mostrar_FacturaVentaTableAdapter Mostrar_FacturaVentaTableAdapter;
        private dtVentasTableAdapters.MostrarDetalle_FacturaVentaTableAdapter MostrarDetalle_FacturaVentaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}