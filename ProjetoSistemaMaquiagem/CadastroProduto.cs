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
    public partial class CadastroProduto : Form
    {

        //Construtor
        public CadastroProduto()
        {
            InitializeComponent();
        }

        //inutil
        private void label4_Click(object sender, EventArgs e)
        {

        }

        //inutil
        private void maskedTextBoxDtAquisicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //função que carrega o grid quando o formulario é chamado
        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
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

        //funcao que atualiza o grid
        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
            ClnProdutos produto = new ClnProdutos();
            produto.Nm_Produto = textBoxPesquisar.Text;
            ds = produto.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
        }

        //Funcao que verifica se há algum campo em branco
        private bool verificaText(Control controles)
        {
            foreach (Control T in controles.Controls)
            {
                if (T is TextBox || T is MaskedTextBox)
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

        //funçao que cadastra o produto
        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnProdutos prod = new ClnProdutos();
            prod.Nm_Produto = textBoxNome.Text;
            prod.Nm_Marca = textBoxMarca.Text;
            prod.VL_Produto = Convert.ToDouble(textBoxVlProduto.Text);
            prod.Dt_Vencimento = maskedTextBoxDtVencimento.Text;
            prod.Dt_Aquisicao = maskedTextBoxDtAquisicao.Text;
            prod.Uso = textBoxUso.Text;
            prod.Gravar();
            AtualizarGrid();
            LimparTxt(groupBoxProduto);
        }

        //funcao que é chamada quando é cancelado o cadastro
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            LimparTxt(groupBoxProduto);
        }

        //funcao do grid
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnProdutos produtos = new ClnProdutos();
            if (dgv1.RowCount > 0)
            {

                textBoxNome.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                textBoxMarca.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                textBoxVlProduto.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                maskedTextBoxDtAquisicao.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                maskedTextBoxDtVencimento.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
                textBoxUso.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
            }


        }

        //função que é chamada para excluir produto
        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja excluir o cadastro," + textBoxNome.Text + " ?";
            int resposta = Convert.ToInt16(MessageBox.Show(mensagem, "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == 6)
            {
                ClnProdutos produto = new ClnProdutos();
                produto.Excluir(textBoxNome.Text);
            }
            LimparTxt(groupBoxProduto);
            AtualizarGrid();
        }

        //funcao da pesquisa
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ClnProdutos produto = new ClnProdutos();
            produto.Nm_Produto = textBoxPesquisar.Text;
            ds = produto.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            ClnProdutos prod = new ClnProdutos();
            prod.Nm_Produto = textBoxNome.Text;
            prod.Nm_Marca = textBoxMarca.Text;
            prod.VL_Produto = Convert.ToDouble(textBoxVlProduto.Text);
            prod.Dt_Vencimento = maskedTextBoxDtVencimento.Text;
            prod.Dt_Aquisicao = maskedTextBoxDtAquisicao.Text;
            prod.Uso = textBoxUso.Text;
            prod.Cd_Produto = prod.BuscarporCodigo();
            prod.Atualizar();
            AtualizarGrid();
            LimparTxt(groupBoxProduto);
        }
    }
}
