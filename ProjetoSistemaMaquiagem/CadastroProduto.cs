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
    }
}
