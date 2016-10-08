using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoADados;
using CamadaDeNegocio;

namespace ProjetoSistemaMaquiagem
{
    public partial class ControleEstoque : Form
    {
        //construtor
        public ControleEstoque()
        {
            InitializeComponent();
        }
      
        //inutil
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //funcao que carrega o grid ao iniciar
        private void ControleEstoque_Load(object sender, EventArgs e)
        {
            PreencherComboTipo();
            AtualizarGrid();
        }

        //Atualiza o grid
        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
            ClnEstoque estoque = new ClnEstoque();
            estoque.Nm_Produto = textBoxPesquisar.Text;
            ds = estoque.BuscarporNome();
            dataGridView1.DataSource = ds.Tables[0];
        }

        //limpa o texto da caixa de texto do grupo
        public void LimparTxt(Control controles)
        {
            foreach (Control ctl in controles.Controls)
            {
                if (ctl is TextBox) ctl.Text = string.Empty;
                if (ctl is MaskedTextBox) ctl.Text = string.Empty;
            }
        }

        //Funcao que verifica se há algum campo em branco
        private bool verificaText(Control controles)
        {
            foreach (Control T in controles.Controls)
            {
                if (T is TextBox || T is MaskedTextBox || T is ComboBox)
                {
                    if (T.Text == string.Empty)
                    {
                        MessageBox.Show("Há campos vazios\nFavor verificar!", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        //preenche o combobox com os valores dos serviços
        public void PreencherComboTipo()
        {
            ClnProdutos tipo = new ClnProdutos();
            DataSet ds = tipo.BuscarporNome();
            comboBoxProduto.DataSource = ds.Tables[0];
            comboBoxProduto.DisplayMember = "Nome";
            comboBoxProduto.ValueMember = "Codigo";
        }

        //Cancelar
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            LimparTxt(groupBox1);
    
        }

        //Confirmar
        private void botaoConfirmar_Click_1(object sender, EventArgs e)
        {
            ClnEstoque estoque = new ClnEstoque();
            estoque.Cd_Produto = estoque.BuscarporCodigo();
            estoque.Nm_Produto = comboBoxProduto.Text;
            estoque.Qtd_Minimo = Convert.ToInt32(textBoxQtdMinima.Text);
            estoque.Qtd_Atual = Convert.ToInt32(textBoxQtdAtual.Text);
            if (verificaText(groupBox1))
            {
                estoque.Gravar();
                AtualizarGrid();
                LimparTxt(groupBox1);
            }
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            ClnEstoque estoque = new ClnEstoque();
            estoque.Nm_Produto = comboBoxProduto.Text;
            estoque.Qtd_Minimo = Convert.ToInt32(textBoxQtdMinima.Text);
            estoque.Qtd_Atual = Convert.ToInt32(textBoxQtdAtual.Text);
            estoque.Atualizar();
            AtualizarGrid();
            LimparTxt(groupBox1);
        }

        //Funcao do grid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            ClnEstoque produtos = new ClnEstoque();
            if (dataGridView1.RowCount > 0)
            {
                comboBoxProduto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxQtdMinima.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxQtdAtual.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

    }
}
