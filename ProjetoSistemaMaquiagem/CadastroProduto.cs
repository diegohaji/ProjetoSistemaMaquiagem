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
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnProdutos prod = new ClnProdutos();
            prod.Nm_Produto = textBoxNome.Text;
            prod.Nm_Marca = textBoxMarca.Text;
            prod.VL_Produto = Convert.ToDouble(textBoxVlProduto.Text);
          //  prod.Dt_Vencimento = Convert.ToDateTime(maskedTextBoxDtVencimento.Text);
          //  prod.Dt_Aquisicao = Convert.ToDateTime(maskedTextBoxDtAquisicao.Text);
            prod.Gravar();
        }

        private void maskedTextBoxDtAquisicao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            LimparTxt(groupBox1);
        }

        public void LimparTxt(Control controles)
        {
            foreach (Control ctl in controles.Controls)
            {
                if (ctl is TextBox) ctl.Text = string.Empty;
                if (ctl is MaskedTextBox) ctl.Text = string.Empty;
            }
        }

        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
            ClnCliente cliente = new ClnCliente();
            cliente.Nm_Cliente = textBoxPesquisar.Text;
            ds = cliente.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        dgv1.CurrentRow.Selected = true;
            ClnProdutos produtos = new ClnProdutos();
            if (dgv1.RowCount > 0)
            {
                textBoxCodigo.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
                textBoxNome.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                textBoxMarca.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBoxDtAquisicao.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                maskedTextBoxDtVencimento.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                textBoxVlProduto.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
                textBoxUso.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
            }

        
        }
    }
}
