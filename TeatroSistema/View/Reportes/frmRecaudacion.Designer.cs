﻿
namespace TeatroSistema.View.Reportes
{
    partial class frmRecaudacion
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtRecaudacion = new TeatroSistema.View.Reportes.dtRecaudacion();
            this.RecaudacionVentasDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RecaudacionVentasDetallesTableAdapter = new TeatroSistema.View.Reportes.dtRecaudacionTableAdapters.RecaudacionVentasDetallesTableAdapter();
            this.RecaudacionVentasTotalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RecaudacionVentasTotalesTableAdapter = new TeatroSistema.View.Reportes.dtRecaudacionTableAdapters.RecaudacionVentasTotalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecaudacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecaudacionVentasDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecaudacionVentasTotalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RecaudacionVentasDetallesBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.RecaudacionVentasTotalesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TeatroSistema.View.Reportes.ReporteRecaudacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtRecaudacion
            // 
            this.dtRecaudacion.DataSetName = "dtRecaudacion";
            this.dtRecaudacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RecaudacionVentasDetallesBindingSource
            // 
            this.RecaudacionVentasDetallesBindingSource.DataMember = "RecaudacionVentasDetalles";
            this.RecaudacionVentasDetallesBindingSource.DataSource = this.dtRecaudacion;
            // 
            // RecaudacionVentasDetallesTableAdapter
            // 
            this.RecaudacionVentasDetallesTableAdapter.ClearBeforeFill = true;
            // 
            // RecaudacionVentasTotalesBindingSource
            // 
            this.RecaudacionVentasTotalesBindingSource.DataMember = "RecaudacionVentasTotales";
            this.RecaudacionVentasTotalesBindingSource.DataSource = this.dtRecaudacion;
            // 
            // RecaudacionVentasTotalesTableAdapter
            // 
            this.RecaudacionVentasTotalesTableAdapter.ClearBeforeFill = true;
            // 
            // frmRecaudacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRecaudacion";
            this.Text = "frmRecaudacion";
            this.Load += new System.EventHandler(this.frmRecaudacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRecaudacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecaudacionVentasDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecaudacionVentasTotalesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RecaudacionVentasDetallesBindingSource;
        private dtRecaudacion dtRecaudacion;
        private System.Windows.Forms.BindingSource RecaudacionVentasTotalesBindingSource;
        private dtRecaudacionTableAdapters.RecaudacionVentasDetallesTableAdapter RecaudacionVentasDetallesTableAdapter;
        private dtRecaudacionTableAdapters.RecaudacionVentasTotalesTableAdapter RecaudacionVentasTotalesTableAdapter;
    }
}