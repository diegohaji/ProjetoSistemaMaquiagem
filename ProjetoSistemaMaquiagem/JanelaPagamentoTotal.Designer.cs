﻿namespace ProjetoSistemaMaquiagem
{
    partial class JanelaPagamentoTotal
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new ProjetoSistemaMaquiagem.DataSet1();
            this.DataTablePagamentoTotalFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTablePagamentoTotalFuncionarioTableAdapter = new ProjetoSistemaMaquiagem.DataSet1TableAdapters.DataTablePagamentoTotalFuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTablePagamentoTotalFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTablePagamentoTotalFuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoSistemaMaquiagem.ReportPagamentoTotal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(713, 495);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTablePagamentoTotalFuncionarioBindingSource
            // 
            this.DataTablePagamentoTotalFuncionarioBindingSource.DataMember = "DataTablePagamentoTotalFuncionario";
            this.DataTablePagamentoTotalFuncionarioBindingSource.DataSource = this.DataSet1;
            // 
            // DataTablePagamentoTotalFuncionarioTableAdapter
            // 
            this.DataTablePagamentoTotalFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // JanelaPagamentoTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 495);
            this.Controls.Add(this.reportViewer1);
            this.Name = "JanelaPagamentoTotal";
            this.Text = "PagamentoTotal";
            this.Load += new System.EventHandler(this.JanelaPagamentoTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTablePagamentoTotalFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTablePagamentoTotalFuncionarioBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTablePagamentoTotalFuncionarioTableAdapter DataTablePagamentoTotalFuncionarioTableAdapter;
    }
}