namespace ProjetoSistemaMaquiagem
{
    partial class CadastroServiços
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
            this.groupBoxServico = new System.Windows.Forms.GroupBox();
            this.botaoConfirmar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxServico
            // 
            this.groupBoxServico.Controls.Add(this.botaoConfirmar);
            this.groupBoxServico.Controls.Add(this.dateTimePicker1);
            this.groupBoxServico.Controls.Add(this.textBoxNome);
            this.groupBoxServico.Controls.Add(this.Cancelar);
            this.groupBoxServico.Controls.Add(this.textBoxPreco);
            this.groupBoxServico.Controls.Add(this.label4);
            this.groupBoxServico.Controls.Add(this.label3);
            this.groupBoxServico.Controls.Add(this.label1);
            this.groupBoxServico.Location = new System.Drawing.Point(13, 13);
            this.groupBoxServico.Name = "groupBoxServico";
            this.groupBoxServico.Size = new System.Drawing.Size(418, 111);
            this.groupBoxServico.TabIndex = 0;
            this.groupBoxServico.TabStop = false;
            // 
            // botaoConfirmar
            // 
            this.botaoConfirmar.Location = new System.Drawing.Point(20, 82);
            this.botaoConfirmar.Name = "botaoConfirmar";
            this.botaoConfirmar.Size = new System.Drawing.Size(75, 23);
            this.botaoConfirmar.TabIndex = 4;
            this.botaoConfirmar.Text = "Confirmar";
            this.botaoConfirmar.UseVisualStyleBackColor = true;
            this.botaoConfirmar.Click += new System.EventHandler(this.botaoConfirmar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(67, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(20, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(163, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(108, 82);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(217, 32);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(75, 20);
            this.textBoxPreco.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duração";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(247, 80);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(75, 23);
            this.botaoEditar.TabIndex = 8;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(339, 80);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoExcluir.TabIndex = 9;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(15, 245);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(419, 173);
            this.dgv1.TabIndex = 10;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.botaoExcluir);
            this.groupBox3.Controls.Add(this.botaoEditar);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBoxPesquisar);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(14, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 109);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(21, 44);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(301, 20);
            this.textBoxPesquisar.TabIndex = 6;
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
            // CadastroServiços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 429);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.groupBoxServico);
            this.Name = "CadastroServiços";
            this.Text = "Cadastro de serviços";
            this.Load += new System.EventHandler(this.CadastroServiços_Load);
            this.groupBoxServico.ResumeLayout(false);
            this.groupBoxServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxServico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Button botaoConfirmar;
        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}