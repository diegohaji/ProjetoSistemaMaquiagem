namespace ProjetoSistemaMaquiagem
{
    partial class JanelaRelatorioTotalClientes
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
            this.DataTableTodosClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableTodosClientesTableAdapter = new ProjetoSistemaMaquiagem.DataSet1TableAdapters.DataTableTodosClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableTodosClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableTodosClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoSistemaMaquiagem.ReportTodosClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 492);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableTodosClientesBindingSource
            // 
            this.DataTableTodosClientesBindingSource.DataMember = "DataTableTodosClientes";
            this.DataTableTodosClientesBindingSource.DataSource = this.DataSet1;
            // 
            // DataTableTodosClientesTableAdapter
            // 
            this.DataTableTodosClientesTableAdapter.ClearBeforeFill = true;
            // 
            // JanelaRelatorioTotalClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 492);
            this.Controls.Add(this.reportViewer1);
            this.Name = "JanelaRelatorioTotalClientes";
            this.Text = "RelatorioTotalClientes";
            this.Load += new System.EventHandler(this.JanelaRelatorioTotalClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableTodosClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTableTodosClientesBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTableTodosClientesTableAdapter DataTableTodosClientesTableAdapter;
    }
}