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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentoDeHorariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoDeServiçosClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentoDeServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleFinanceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleFinanceiroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonEsqueciSenha = new System.Windows.Forms.Button();
            this.buttonLogar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.timerAtualizarGrid = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.serviçosToolStripMenuItem1,
            this.controleFinanceiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem1.Text = "Login";
            this.loginToolStripMenuItem1.Click += new System.EventHandler(this.loginToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Enabled = false;
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            this.serviçosToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem1
            // 
            this.serviçosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançamentoDeHorariosToolStripMenuItem,
            this.agendamentoDeServiçosClienteToolStripMenuItem,
            this.pagamentoDeServiçosToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.serviçosToolStripMenuItem1.Enabled = false;
            this.serviçosToolStripMenuItem1.Name = "serviçosToolStripMenuItem1";
            this.serviçosToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.serviçosToolStripMenuItem1.Text = "Serviços";
            // 
            // lançamentoDeHorariosToolStripMenuItem
            // 
            this.lançamentoDeHorariosToolStripMenuItem.Name = "lançamentoDeHorariosToolStripMenuItem";
            this.lançamentoDeHorariosToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.lançamentoDeHorariosToolStripMenuItem.Text = "Lançamento de horarios - funcionario";
            this.lançamentoDeHorariosToolStripMenuItem.Click += new System.EventHandler(this.lançamentoDeHorariosToolStripMenuItem_Click);
            // 
            // agendamentoDeServiçosClienteToolStripMenuItem
            // 
            this.agendamentoDeServiçosClienteToolStripMenuItem.Name = "agendamentoDeServiçosClienteToolStripMenuItem";
            this.agendamentoDeServiçosClienteToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.agendamentoDeServiçosClienteToolStripMenuItem.Text = "Agendamento de serviços - cliente";
            this.agendamentoDeServiçosClienteToolStripMenuItem.Click += new System.EventHandler(this.agendamentoDeServiçosClienteToolStripMenuItem_Click);
            // 
            // pagamentoDeServiçosToolStripMenuItem
            // 
            this.pagamentoDeServiçosToolStripMenuItem.Name = "pagamentoDeServiçosToolStripMenuItem";
            this.pagamentoDeServiçosToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.pagamentoDeServiçosToolStripMenuItem.Text = "Pagamento de serviços";
            this.pagamentoDeServiçosToolStripMenuItem.Click += new System.EventHandler(this.pagamentoDeServiçosToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // controleFinanceiroToolStripMenuItem
            // 
            this.controleFinanceiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarRelatórioToolStripMenuItem,
            this.controleFinanceiroToolStripMenuItem1});
            this.controleFinanceiroToolStripMenuItem.Enabled = false;
            this.controleFinanceiroToolStripMenuItem.Name = "controleFinanceiroToolStripMenuItem";
            this.controleFinanceiroToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.controleFinanceiroToolStripMenuItem.Text = "Controle financeiro";
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            this.gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            this.gerarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.gerarRelatórioToolStripMenuItem.Text = "Gerar relatório";
            this.gerarRelatórioToolStripMenuItem.Click += new System.EventHandler(this.gerarRelatórioToolStripMenuItem_Click);
            // 
            // controleFinanceiroToolStripMenuItem1
            // 
            this.controleFinanceiroToolStripMenuItem1.Name = "controleFinanceiroToolStripMenuItem1";
            this.controleFinanceiroToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.controleFinanceiroToolStripMenuItem1.Text = "Controle financeiro";
            this.controleFinanceiroToolStripMenuItem1.Click += new System.EventHandler(this.controleFinanceiroToolStripMenuItem1_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonSair);
            this.groupBoxLogin.Controls.Add(this.buttonEsqueciSenha);
            this.groupBoxLogin.Controls.Add(this.buttonLogar);
            this.groupBoxLogin.Controls.Add(this.textBoxSenha);
            this.groupBoxLogin.Controls.Add(this.textBoxUsuario);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Enabled = false;
            this.groupBoxLogin.Location = new System.Drawing.Point(12, 27);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(139, 205);
            this.groupBoxLogin.TabIndex = 3;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            this.groupBoxLogin.Visible = false;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(9, 169);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(111, 23);
            this.buttonSair.TabIndex = 8;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonEsqueciSenha
            // 
            this.buttonEsqueciSenha.Location = new System.Drawing.Point(9, 140);
            this.buttonEsqueciSenha.Name = "buttonEsqueciSenha";
            this.buttonEsqueciSenha.Size = new System.Drawing.Size(111, 23);
            this.buttonEsqueciSenha.TabIndex = 6;
            this.buttonEsqueciSenha.Text = "Esqueci Senha";
            this.buttonEsqueciSenha.UseVisualStyleBackColor = true;
            this.buttonEsqueciSenha.Click += new System.EventHandler(this.buttonEsqueciSenha_Click);
            // 
            // buttonLogar
            // 
            this.buttonLogar.Location = new System.Drawing.Point(9, 111);
            this.buttonLogar.Name = "buttonLogar";
            this.buttonLogar.Size = new System.Drawing.Size(111, 23);
            this.buttonLogar.TabIndex = 5;
            this.buttonLogar.Text = "Logar";
            this.buttonLogar.UseVisualStyleBackColor = true;
            this.buttonLogar.Click += new System.EventHandler(this.buttonLogar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(9, 74);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(111, 20);
            this.textBoxSenha.TabIndex = 4;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(9, 35);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(111, 20);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Enabled = false;
            this.dgv1.Location = new System.Drawing.Point(12, 27);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(715, 445);
            this.dgv1.TabIndex = 4;
            this.dgv1.Visible = false;
            // 
            // timerAtualizarGrid
            // 
            this.timerAtualizarGrid.Enabled = true;
            this.timerAtualizarGrid.Interval = 1000;
            this.timerAtualizarGrid.Tick += new System.EventHandler(this.timerAtualizarGrid_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 487);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.Text = "Menu principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lançamentoDeHorariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoDeServiçosClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentoDeServiçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleFinanceiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleFinanceiroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button buttonEsqueciSenha;
        private System.Windows.Forms.Button buttonLogar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Timer timerAtualizarGrid;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
    }
}