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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxDtVencimento = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDtAquisicao = new System.Windows.Forms.MaskedTextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoConfirmar = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxVlProduto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxVlProduto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.maskedTextBoxDtVencimento);
            this.groupBox1.Controls.Add(this.maskedTextBoxDtAquisicao);
            this.groupBox1.Controls.Add(this.textBoxMarca);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.textBoxCodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 172);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(359, 95);
            this.textBox4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Uso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data De Vencimento";
            // 
            // maskedTextBoxDtVencimento
            // 
            this.maskedTextBoxDtVencimento.Location = new System.Drawing.Point(337, 68);
            this.maskedTextBoxDtVencimento.Name = "maskedTextBoxDtVencimento";
            this.maskedTextBoxDtVencimento.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDtVencimento.TabIndex = 8;
            // 
            // maskedTextBoxDtAquisicao
            // 
            this.maskedTextBoxDtAquisicao.Location = new System.Drawing.Point(337, 17);
            this.maskedTextBoxDtAquisicao.Name = "maskedTextBoxDtAquisicao";
            this.maskedTextBoxDtAquisicao.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxDtAquisicao.TabIndex = 7;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(78, 121);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarca.TabIndex = 6;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(78, 69);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(78, 17);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data De Aquisição";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // botaoConfirmar
            // 
            this.botaoConfirmar.Location = new System.Drawing.Point(23, 307);
            this.botaoConfirmar.Name = "botaoConfirmar";
            this.botaoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.botaoConfirmar.TabIndex = 1;
            this.botaoConfirmar.Text = "Confirmar";
            this.botaoConfirmar.UseVisualStyleBackColor = true;
            this.botaoConfirmar.Click += new System.EventHandler(this.botaoConfirmar_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(137, 307);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(75, 23);
            this.botaoEditar.TabIndex = 2;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(258, 307);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 3;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(375, 307);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoExcluir.TabIndex = 4;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 116);
            this.dataGridView1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor";
            // 
            // textBoxVlProduto
            // 
            this.textBoxVlProduto.Location = new System.Drawing.Point(337, 121);
            this.textBoxVlProduto.Name = "textBoxVlProduto";
            this.textBoxVlProduto.Size = new System.Drawing.Size(100, 20);
            this.textBoxVlProduto.TabIndex = 13;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoConfirmar);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroProduto";
            this.Text = "CadastroProduto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDtVencimento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDtAquisicao;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Button botaoConfirmar;
        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxVlProduto;
        private System.Windows.Forms.Label label7;
    }
}