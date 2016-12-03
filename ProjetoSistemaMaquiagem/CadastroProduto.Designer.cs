namespace ProjetoSistemaMaquiagem
{
    partial class CadastroProduto
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
            this.groupBoxProduto = new System.Windows.Forms.GroupBox();
            this.dateTimePickerVencimento = new System.Windows.Forms.DateTimePicker();
            this.botaoConfirmar = new System.Windows.Forms.Button();
            this.dateTimePickerAquisicao = new System.Windows.Forms.DateTimePicker();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxVlProduto = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProduto
            // 
            this.groupBoxProduto.Controls.Add(this.textBoxVlProduto);
            this.groupBoxProduto.Controls.Add(this.dateTimePickerVencimento);
            this.groupBoxProduto.Controls.Add(this.botaoConfirmar);
            this.groupBoxProduto.Controls.Add(this.dateTimePickerAquisicao);
            this.groupBoxProduto.Controls.Add(this.botaoCancelar);
            this.groupBoxProduto.Controls.Add(this.label7);
            this.groupBoxProduto.Controls.Add(this.textBoxUso);
            this.groupBoxProduto.Controls.Add(this.label6);
            this.groupBoxProduto.Controls.Add(this.label5);
            this.groupBoxProduto.Controls.Add(this.textBoxMarca);
            this.groupBoxProduto.Controls.Add(this.textBoxNome);
            this.groupBoxProduto.Controls.Add(this.label4);
            this.groupBoxProduto.Controls.Add(this.label3);
            this.groupBoxProduto.Controls.Add(this.label2);
            this.groupBoxProduto.Location = new System.Drawing.Point(13, 13);
            this.groupBoxProduto.Name = "groupBoxProduto";
            this.groupBoxProduto.Size = new System.Drawing.Size(497, 224);
            this.groupBoxProduto.TabIndex = 0;
            this.groupBoxProduto.TabStop = false;
            // 
            // dateTimePickerVencimento
            // 
            this.dateTimePickerVencimento.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerVencimento.Location = new System.Drawing.Point(257, 83);
            this.dateTimePickerVencimento.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerVencimento.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerVencimento.Name = "dateTimePickerVencimento";
            this.dateTimePickerVencimento.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerVencimento.TabIndex = 4;
            // 
            // botaoConfirmar
            // 
            this.botaoConfirmar.Location = new System.Drawing.Point(6, 195);
            this.botaoConfirmar.Name = "botaoConfirmar";
            this.botaoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.botaoConfirmar.TabIndex = 7;
            this.botaoConfirmar.Text = "Confirmar";
            this.botaoConfirmar.UseVisualStyleBackColor = true;
            this.botaoConfirmar.Click += new System.EventHandler(this.botaoConfirmar_Click);
            // 
            // dateTimePickerAquisicao
            // 
            this.dateTimePickerAquisicao.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerAquisicao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAquisicao.Location = new System.Drawing.Point(10, 83);
            this.dateTimePickerAquisicao.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerAquisicao.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAquisicao.Name = "dateTimePickerAquisicao";
            this.dateTimePickerAquisicao.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerAquisicao.TabIndex = 3;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(87, 195);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 8;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor";
            // 
            // textBoxUso
            // 
            this.textBoxUso.Location = new System.Drawing.Point(10, 139);
            this.textBoxUso.Name = "textBoxUso";
            this.textBoxUso.Size = new System.Drawing.Size(212, 20);
            this.textBoxUso.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Uso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data De Vencimento";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(257, 32);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(212, 20);
            this.textBoxMarca.TabIndex = 2;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(10, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(212, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data De Aquisição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(282, 93);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(75, 23);
            this.botaoEditar.TabIndex = 11;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(373, 93);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoExcluir.TabIndex = 12;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(516, 13);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(455, 353);
            this.dgv1.TabIndex = 14;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.botaoExcluir);
            this.groupBox3.Controls.Add(this.botaoEditar);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBoxPesquisar);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(12, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 122);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(21, 44);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(336, 20);
            this.textBoxPesquisar.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nome";
            // 
            // textBoxVlProduto
            // 
            this.textBoxVlProduto.Location = new System.Drawing.Point(257, 138);
            this.textBoxVlProduto.Mask = "0000";
            this.textBoxVlProduto.Name = "textBoxVlProduto";
            this.textBoxVlProduto.Size = new System.Drawing.Size(57, 20);
            this.textBoxVlProduto.TabIndex = 13;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 377);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupBoxProduto);
            this.Name = "CadastroProduto";
            this.Text = "Cadastro de produto";
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            this.groupBoxProduto.ResumeLayout(false);
            this.groupBoxProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button botaoConfirmar;
        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimento;
        private System.Windows.Forms.DateTimePicker dateTimePickerAquisicao;
        private System.Windows.Forms.MaskedTextBox textBoxVlProduto;
    }
}