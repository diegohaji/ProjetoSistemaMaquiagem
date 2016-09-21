namespace ProjetoSistemaMaquiagem
{
    partial class TelaPrincipal
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
            this.buttonCadUsuario = new System.Windows.Forms.Button();
            this.buttonEsqueciSenha = new System.Windows.Forms.Button();
            this.buttonLogar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.buttonServicos = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonFuncionario = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonServPrestado = new System.Windows.Forms.Button();
            this.buttonLancHorario = new System.Windows.Forms.Button();
            this.buttonAgendServico = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonVerificarEst = new System.Windows.Forms.Button();
            this.buttonAlterarEst = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonContFinanceiro = new System.Windows.Forms.Button();
            this.buttonRelatorio = new System.Windows.Forms.Button();
            this.buttonEstoque = new System.Windows.Forms.Button();
            this.buttonProduto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCadUsuario);
            this.groupBox1.Controls.Add(this.buttonEsqueciSenha);
            this.groupBox1.Controls.Add(this.buttonLogar);
            this.groupBox1.Controls.Add(this.textBoxSenha);
            this.groupBox1.Controls.Add(this.textBoxUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonCadUsuario
            // 
            this.buttonCadUsuario.Location = new System.Drawing.Point(9, 181);
            this.buttonCadUsuario.Name = "buttonCadUsuario";
            this.buttonCadUsuario.Size = new System.Drawing.Size(111, 23);
            this.buttonCadUsuario.TabIndex = 7;
            this.buttonCadUsuario.Text = "Cadastrar Usuario";
            this.buttonCadUsuario.UseVisualStyleBackColor = true;
            this.buttonCadUsuario.Click += new System.EventHandler(this.buttonCadUsuario_Click);
            // 
            // buttonEsqueciSenha
            // 
            this.buttonEsqueciSenha.Location = new System.Drawing.Point(9, 222);
            this.buttonEsqueciSenha.Name = "buttonEsqueciSenha";
            this.buttonEsqueciSenha.Size = new System.Drawing.Size(111, 23);
            this.buttonEsqueciSenha.TabIndex = 6;
            this.buttonEsqueciSenha.Text = "Esqueci Senha";
            this.buttonEsqueciSenha.UseVisualStyleBackColor = true;
            this.buttonEsqueciSenha.Click += new System.EventHandler(this.buttonEsqueciSenha_Click);
            // 
            // buttonLogar
            // 
            this.buttonLogar.Location = new System.Drawing.Point(9, 139);
            this.buttonLogar.Name = "buttonLogar";
            this.buttonLogar.Size = new System.Drawing.Size(111, 23);
            this.buttonLogar.TabIndex = 5;
            this.buttonLogar.Text = "Logar";
            this.buttonLogar.UseVisualStyleBackColor = true;
            this.buttonLogar.Click += new System.EventHandler(this.buttonLogar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(62, 88);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(100, 20);
            this.textBoxSenha.TabIndex = 4;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(62, 38);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 3;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCadastro);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(198, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(311, 143);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.BackColor = System.Drawing.Color.Gray;
            this.tabPageCadastro.Controls.Add(this.buttonProduto);
            this.tabPageCadastro.Controls.Add(this.buttonServicos);
            this.tabPageCadastro.Controls.Add(this.buttonCliente);
            this.tabPageCadastro.Controls.Add(this.buttonFuncionario);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(303, 117);
            this.tabPageCadastro.TabIndex = 0;
            this.tabPageCadastro.Text = "Cadastro";
            // 
            // buttonServicos
            // 
            this.buttonServicos.Location = new System.Drawing.Point(163, 6);
            this.buttonServicos.Name = "buttonServicos";
            this.buttonServicos.Size = new System.Drawing.Size(134, 23);
            this.buttonServicos.TabIndex = 2;
            this.buttonServicos.Text = "Serviços";
            this.buttonServicos.UseVisualStyleBackColor = true;
            this.buttonServicos.Click += new System.EventHandler(this.buttonServicos_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(6, 71);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(138, 23);
            this.buttonCliente.TabIndex = 1;
            this.buttonCliente.Text = "Cliente";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonFuncionario
            // 
            this.buttonFuncionario.Location = new System.Drawing.Point(6, 6);
            this.buttonFuncionario.Name = "buttonFuncionario";
            this.buttonFuncionario.Size = new System.Drawing.Size(138, 23);
            this.buttonFuncionario.TabIndex = 0;
            this.buttonFuncionario.Text = "Funcionario";
            this.buttonFuncionario.UseVisualStyleBackColor = true;
            this.buttonFuncionario.Click += new System.EventHandler(this.buttonFuncionario_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.buttonServPrestado);
            this.tabPage2.Controls.Add(this.buttonLancHorario);
            this.tabPage2.Controls.Add(this.buttonAgendServico);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(303, 117);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Serviços";
            // 
            // buttonServPrestado
            // 
            this.buttonServPrestado.Location = new System.Drawing.Point(165, 6);
            this.buttonServPrestado.Name = "buttonServPrestado";
            this.buttonServPrestado.Size = new System.Drawing.Size(132, 23);
            this.buttonServPrestado.TabIndex = 2;
            this.buttonServPrestado.Text = "Serviço Prestado";
            this.buttonServPrestado.UseVisualStyleBackColor = true;
            this.buttonServPrestado.Click += new System.EventHandler(this.buttonServPrestado_Click);
            // 
            // buttonLancHorario
            // 
            this.buttonLancHorario.Location = new System.Drawing.Point(7, 67);
            this.buttonLancHorario.Name = "buttonLancHorario";
            this.buttonLancHorario.Size = new System.Drawing.Size(138, 23);
            this.buttonLancHorario.TabIndex = 1;
            this.buttonLancHorario.Text = "Lançamento de horário";
            this.buttonLancHorario.UseVisualStyleBackColor = true;
            this.buttonLancHorario.Click += new System.EventHandler(this.buttonLancHorario_Click);
            // 
            // buttonAgendServico
            // 
            this.buttonAgendServico.Location = new System.Drawing.Point(7, 7);
            this.buttonAgendServico.Name = "buttonAgendServico";
            this.buttonAgendServico.Size = new System.Drawing.Size(138, 23);
            this.buttonAgendServico.TabIndex = 0;
            this.buttonAgendServico.Text = "Agendamento de serviço";
            this.buttonAgendServico.UseVisualStyleBackColor = true;
            this.buttonAgendServico.Click += new System.EventHandler(this.buttonAgendServico_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gray;
            this.tabPage3.Controls.Add(this.buttonEstoque);
            this.tabPage3.Controls.Add(this.buttonVerificarEst);
            this.tabPage3.Controls.Add(this.buttonAlterarEst);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(303, 117);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estoque";
            // 
            // buttonVerificarEst
            // 
            this.buttonVerificarEst.Location = new System.Drawing.Point(7, 77);
            this.buttonVerificarEst.Name = "buttonVerificarEst";
            this.buttonVerificarEst.Size = new System.Drawing.Size(137, 23);
            this.buttonVerificarEst.TabIndex = 1;
            this.buttonVerificarEst.Text = "Verificar";
            this.buttonVerificarEst.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarEst
            // 
            this.buttonAlterarEst.Location = new System.Drawing.Point(160, 6);
            this.buttonAlterarEst.Name = "buttonAlterarEst";
            this.buttonAlterarEst.Size = new System.Drawing.Size(137, 23);
            this.buttonAlterarEst.TabIndex = 0;
            this.buttonAlterarEst.Text = "Alterar";
            this.buttonAlterarEst.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gray;
            this.tabPage4.Controls.Add(this.buttonContFinanceiro);
            this.tabPage4.Controls.Add(this.buttonRelatorio);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(303, 117);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ControleFinanceiro";
            // 
            // buttonContFinanceiro
            // 
            this.buttonContFinanceiro.Location = new System.Drawing.Point(7, 79);
            this.buttonContFinanceiro.Name = "buttonContFinanceiro";
            this.buttonContFinanceiro.Size = new System.Drawing.Size(137, 23);
            this.buttonContFinanceiro.TabIndex = 1;
            this.buttonContFinanceiro.Text = "Controle Financeiro";
            this.buttonContFinanceiro.UseVisualStyleBackColor = true;
            this.buttonContFinanceiro.Click += new System.EventHandler(this.buttonContFinanceiro_Click);
            // 
            // buttonRelatorio
            // 
            this.buttonRelatorio.Location = new System.Drawing.Point(7, 7);
            this.buttonRelatorio.Name = "buttonRelatorio";
            this.buttonRelatorio.Size = new System.Drawing.Size(137, 23);
            this.buttonRelatorio.TabIndex = 0;
            this.buttonRelatorio.Text = "Gerar Relatório";
            this.buttonRelatorio.UseVisualStyleBackColor = true;
            this.buttonRelatorio.Click += new System.EventHandler(this.buttonRelatorio_Click);
            // 
            // buttonEstoque
            // 
            this.buttonEstoque.Location = new System.Drawing.Point(8, 6);
            this.buttonEstoque.Name = "buttonEstoque";
            this.buttonEstoque.Size = new System.Drawing.Size(136, 23);
            this.buttonEstoque.TabIndex = 4;
            this.buttonEstoque.Text = "Estoque";
            this.buttonEstoque.UseVisualStyleBackColor = true;
            // 
            // buttonProduto
            // 
            this.buttonProduto.Location = new System.Drawing.Point(163, 70);
            this.buttonProduto.Name = "buttonProduto";
            this.buttonProduto.Size = new System.Drawing.Size(134, 23);
            this.buttonProduto.TabIndex = 3;
            this.buttonProduto.Text = "Produto";
            this.buttonProduto.UseVisualStyleBackColor = true;
            this.buttonProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 280);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaPrincipal";
            this.Text = "Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCadUsuario;
        private System.Windows.Forms.Button buttonEsqueciSenha;
        private System.Windows.Forms.Button buttonLogar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonServicos;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonFuncionario;
        private System.Windows.Forms.Button buttonAgendServico;
        private System.Windows.Forms.Button buttonServPrestado;
        private System.Windows.Forms.Button buttonLancHorario;
        private System.Windows.Forms.Button buttonVerificarEst;
        private System.Windows.Forms.Button buttonAlterarEst;
        private System.Windows.Forms.Button buttonRelatorio;
        private System.Windows.Forms.Button buttonContFinanceiro;
        private System.Windows.Forms.Button buttonProduto;
        private System.Windows.Forms.Button buttonEstoque;
    }
}