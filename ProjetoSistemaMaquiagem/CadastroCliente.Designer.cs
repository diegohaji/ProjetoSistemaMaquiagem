namespace ProjetoSistemaMaquiagem
{
    partial class CadastroCliente
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
            this.Cadastro = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRG = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxRua = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BotaoConfirmar = new System.Windows.Forms.Button();
            this.BotaoEditar = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBoxEndereco = new System.Windows.Forms.GroupBox();
            this.textBoxCEP = new System.Windows.Forms.TextBox();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBoxEndereco.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.maskedTextBoxCPF);
            this.Cadastro.Controls.Add(this.maskedTextBoxRG);
            this.Cadastro.Controls.Add(this.textBoxEmail);
            this.Cadastro.Controls.Add(this.label12);
            this.Cadastro.Controls.Add(this.maskedTextBoxCelular);
            this.Cadastro.Controls.Add(this.label5);
            this.Cadastro.Controls.Add(this.maskedTextBoxTelefone);
            this.Cadastro.Controls.Add(this.label4);
            this.Cadastro.Controls.Add(this.label3);
            this.Cadastro.Controls.Add(this.label2);
            this.Cadastro.Controls.Add(this.textBoxNome);
            this.Cadastro.Controls.Add(this.label1);
            this.Cadastro.Location = new System.Drawing.Point(13, 13);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(477, 180);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.TabStop = false;
            this.Cadastro.Text = "Informações pessoais";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(245, 96);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCPF.TabIndex = 4;
            // 
            // maskedTextBoxRG
            // 
            this.maskedTextBoxRG.Location = new System.Drawing.Point(30, 96);
            this.maskedTextBoxRG.Mask = "00.000.000";
            this.maskedTextBoxRG.Name = "maskedTextBoxRG";
            this.maskedTextBoxRG.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxRG.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(246, 44);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(198, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Email";
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(30, 145);
            this.maskedTextBoxCelular.Mask = "(99) 00000-0000";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBoxCelular.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Celular";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(245, 145);
            this.maskedTextBoxTelefone.Mask = "(99) 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTelefone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RG";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(30, 44);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(195, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(244, 163);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(171, 20);
            this.textBoxEstado.TabIndex = 12;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(30, 163);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(176, 20);
            this.textBoxCidade.TabIndex = 11;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(244, 106);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(171, 20);
            this.textBoxBairro.TabIndex = 10;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(244, 43);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(58, 20);
            this.textBoxNumero.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nº";
            // 
            // textBoxRua
            // 
            this.textBoxRua.Location = new System.Drawing.Point(30, 106);
            this.textBoxRua.Name = "textBoxRua";
            this.textBoxRua.Size = new System.Drawing.Size(176, 20);
            this.textBoxRua.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Logradouro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CEP";
            // 
            // BotaoConfirmar
            // 
            this.BotaoConfirmar.Location = new System.Drawing.Point(13, 448);
            this.BotaoConfirmar.Name = "BotaoConfirmar";
            this.BotaoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BotaoConfirmar.TabIndex = 14;
            this.BotaoConfirmar.Text = "Confirmar";
            this.BotaoConfirmar.UseVisualStyleBackColor = true;
            this.BotaoConfirmar.Click += new System.EventHandler(this.BotaoConfirmar_Click);
            // 
            // BotaoEditar
            // 
            this.BotaoEditar.Location = new System.Drawing.Point(282, 87);
            this.BotaoEditar.Name = "BotaoEditar";
            this.BotaoEditar.Size = new System.Drawing.Size(75, 23);
            this.BotaoEditar.TabIndex = 18;
            this.BotaoEditar.Text = "Editar";
            this.BotaoEditar.UseVisualStyleBackColor = true;
            this.BotaoEditar.Click += new System.EventHandler(this.BotaoEditar_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(94, 448);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 15;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.Location = new System.Drawing.Point(374, 87);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.BotaoExcluir.TabIndex = 19;
            this.BotaoExcluir.Text = "Excluir";
            this.BotaoExcluir.UseVisualStyleBackColor = true;
            this.BotaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(512, 142);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(477, 329);
            this.dgv1.TabIndex = 20;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // groupBoxEndereco
            // 
            this.groupBoxEndereco.Controls.Add(this.textBoxCEP);
            this.groupBoxEndereco.Controls.Add(this.textBoxComplemento);
            this.groupBoxEndereco.Controls.Add(this.label13);
            this.groupBoxEndereco.Controls.Add(this.label6);
            this.groupBoxEndereco.Controls.Add(this.textBoxRua);
            this.groupBoxEndereco.Controls.Add(this.textBoxEstado);
            this.groupBoxEndereco.Controls.Add(this.label7);
            this.groupBoxEndereco.Controls.Add(this.textBoxBairro);
            this.groupBoxEndereco.Controls.Add(this.textBoxCidade);
            this.groupBoxEndereco.Controls.Add(this.label8);
            this.groupBoxEndereco.Controls.Add(this.label11);
            this.groupBoxEndereco.Controls.Add(this.textBoxNumero);
            this.groupBoxEndereco.Controls.Add(this.label10);
            this.groupBoxEndereco.Controls.Add(this.label9);
            this.groupBoxEndereco.Location = new System.Drawing.Point(13, 200);
            this.groupBoxEndereco.Name = "groupBoxEndereco";
            this.groupBoxEndereco.Size = new System.Drawing.Size(477, 242);
            this.groupBoxEndereco.TabIndex = 22;
            this.groupBoxEndereco.TabStop = false;
            this.groupBoxEndereco.Text = "Endereço";
            // 
            // textBoxCEP
            // 
            this.textBoxCEP.Location = new System.Drawing.Point(30, 43);
            this.textBoxCEP.Name = "textBoxCEP";
            this.textBoxCEP.Size = new System.Drawing.Size(100, 20);
            this.textBoxCEP.TabIndex = 7;
            this.textBoxCEP.Leave += new System.EventHandler(this.textBoxCEP_Leave);
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(30, 212);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(385, 20);
            this.textBoxComplemento.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Complemento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BotaoExcluir);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.BotaoEditar);
            this.groupBox3.Controls.Add(this.textBoxPesquisar);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(512, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 116);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(21, 44);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(336, 20);
            this.textBoxPesquisar.TabIndex = 16;
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
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 479);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoConfirmar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxEndereco);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.Cadastro);
            this.Name = "CadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.Cadastro.ResumeLayout(false);
            this.Cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBoxEndereco.ResumeLayout(false);
            this.groupBoxEndereco.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Cadastro;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxRua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotaoConfirmar;
        private System.Windows.Forms.Button BotaoEditar;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Button BotaoExcluir;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRG;
        private System.Windows.Forms.GroupBox groupBoxEndereco;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCEP;
    }
}