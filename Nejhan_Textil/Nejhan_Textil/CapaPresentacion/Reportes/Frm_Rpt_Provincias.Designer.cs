﻿namespace CapaPresentacion.Reportes
{
    partial class Frm_Rpt_Provincias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Nejhan = new CapaPresentacion.Reportes.DataSet_Nejhan();
            this.uSPListadopoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Listado_poTableAdapter = new CapaPresentacion.Reportes.DataSet_NejhanTableAdapters.USP_Listado_poTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Nejhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadopoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPListadopoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Rpt_Provincias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Nejhan
            // 
            this.dataSet_Nejhan.DataSetName = "DataSet_Nejhan";
            this.dataSet_Nejhan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPListadopoBindingSource
            // 
            this.uSPListadopoBindingSource.DataMember = "USP_Listado_po";
            this.uSPListadopoBindingSource.DataSource = this.dataSet_Nejhan;
            // 
            // uSP_Listado_poTableAdapter
            // 
            this.uSP_Listado_poTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 52);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 3;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Provincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 486);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Provincias";
            this.Text = "REPORTE DE PROVINCIAS";
            this.Load += new System.EventHandler(this.Frm_Rpt_Provincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Nejhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadopoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uSPListadopoBindingSource;
        private DataSet_Nejhan dataSet_Nejhan;
        private DataSet_NejhanTableAdapters.USP_Listado_poTableAdapter uSP_Listado_poTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}