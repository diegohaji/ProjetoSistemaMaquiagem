namespace ProjetoSistemaMaquiagem
{
    partial class RelatorioFinanceiro
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProjetoSistemaMaquiagem.DataSet1();
            this.dataTablePeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.buttonPesquisarCliente = new System.Windows.Forms.Button();
            this.buttonPesquisarFuncionario = new System.Windows.Forms.Button();
            this.PesquisarPeriodo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataTableClienteTableAdapter = new ProjetoSistemaMaquiagem.DataSet1TableAdapters.DataTableClienteTableAdapter();
            this.dataTableClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableFuncionarioTableAdapter = new ProjetoSistemaMaquiagem.DataSet1TableAdapters.DataTableFuncionarioTableAdapter();
            this.dataTablePeriodoTableAdapter = new ProjetoSistemaMaquiagem.DataSet1TableAdapters.DataTablePeriodoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePeriodoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableFuncionarioBindingSource
            // 
            this.dataTableFuncionarioBindingSource.DataMember = "DataTableFuncionario";
            this.dataTableFuncionarioBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTablePeriodoBindingSource
            // 
            this.dataTablePeriodoBindingSource.DataMember = "DataTablePeriodo";
            this.dataTablePeriodoBindingSource.DataSource = this.dataSet1;
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.Location = new System.Drawing.Point(18, 19);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerInicial.TabIndex = 1;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(263, 19);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(221, 20);
            this.dateTimePickerFinal.TabIndex = 2;
            // 
            // buttonPesquisarCliente
            // 
            this.buttonPesquisarCliente.Location = new System.Drawing.Point(347, 5);
            this.buttonPesquisarCliente.Name = "buttonPesquisarCliente";
            this.buttonPesquisarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarCliente.TabIndex = 2;
            this.buttonPesquisarCliente.Text = "Pesquisar";
            this.buttonPesquisarCliente.UseVisualStyleBackColor = true;
            this.buttonPesquisarCliente.Click += new System.EventHandler(this.buttonPesquisarCliente_Click);
            // 
            // buttonPesquisarFuncionario
            // 
            this.buttonPesquisarFuncionario.Location = new System.Drawing.Point(375, 6);
            this.buttonPesquisarFuncionario.Name = "buttonPesquisarFuncionario";
            this.buttonPesquisarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarFuncionario.TabIndex = 2;
            this.buttonPesquisarFuncionario.Text = "Pesquisar";
            this.buttonPesquisarFuncionario.UseVisualStyleBackColor = true;
            this.buttonPesquisarFuncionario.Click += new System.EventHandler(this.buttonPesquisarFuncionario_Click);
            // 
            // PesquisarPeriodo
            // 
            this.PesquisarPeriodo.Location = new System.Drawing.Point(490, 16);
            this.PesquisarPeriodo.Name = "PesquisarPeriodo";
            this.PesquisarPeriodo.Size = new System.Drawing.Size(75, 23);
            this.PesquisarPeriodo.TabIndex = 3;
            this.PesquisarPeriodo.Text = "Pesquisar";
            this.PesquisarPeriodo.UseVisualStyleBackColor = true;
            this.PesquisarPeriodo.Click += new System.EventHandler(this.PesquisarPeriodo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 598);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 572);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxCliente);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.buttonPesquisarCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(51, 5);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(290, 21);
            this.comboBoxCliente.TabIndex = 10;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoSistemaMaquiagem.ReportCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 32);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(765, 511);
            this.reportViewer1.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comboBoxFuncionario);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Controls.Add(this.buttonPesquisarFuncionario);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Funcionario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Funcionario";
            // 
            // comboBoxFuncionario
            // 
            this.comboBoxFuncionario.FormattingEnabled = true;
            this.comboBoxFuncionario.Location = new System.Drawing.Point(74, 6);
            this.comboBoxFuncionario.Name = "comboBoxFuncionario";
            this.comboBoxFuncionario.Size = new System.Drawing.Size(290, 21);
            this.comboBoxFuncionario.TabIndex = 12;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dataTableFuncionarioBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ProjetoSistemaMaquiagem.ReportFuncionario.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 38);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(768, 502);
            this.reportViewer2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.PesquisarPeriodo);
            this.tabPage3.Controls.Add(this.dateTimePickerInicial);
            this.tabPage3.Controls.Add(this.dateTimePickerFinal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 546);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Periodo";
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.dataTablePeriodoBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "ProjetoSistemaMaquiagem.ReportPeriodo.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(6, 46);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(768, 494);
            this.reportViewer3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data inicial";
            // 
            // dataTableClienteTableAdapter
            // 
            this.dataTableClienteTableAdapter.ClearBeforeFill = true;
            // 
            // dataTableClienteBindingSource1
            // 
            this.dataTableClienteBindingSource1.DataMember = "DataTableCliente";
            this.dataTableClienteBindingSource1.DataSource = this.dataSet1;
            // 
            // dataTableFuncionarioTableAdapter
            // 
            this.dataTableFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // dataTablePeriodoTableAdapter
            // 
            this.dataTablePeriodoTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(822, 622);
            this.Controls.Add(this.groupBox1);
            this.Name = "RelatorioFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Financeiro";
            this.Load += new System.EventHandler(this.Relatorio_Financeiro_load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePeriodoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClienteBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Button buttonPesquisarCliente;
        private System.Windows.Forms.Button buttonPesquisarFuncionario;
        private System.Windows.Forms.Button PesquisarPeriodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFuncionario;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource dataTableClienteBindingSource;
        private DataSet1TableAdapters.DataTableClienteTableAdapter dataTableClienteTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTableClienteBindingSource1;
        private System.Windows.Forms.BindingSource dataTableFuncionarioBindingSource;
        private System.Windows.Forms.BindingSource dataTablePeriodoBindingSource;
        private DataSet1TableAdapters.DataTableFuncionarioTableAdapter dataTableFuncionarioTableAdapter;
        private DataSet1TableAdapters.DataTablePeriodoTableAdapter dataTablePeriodoTableAdapter;
    }
}