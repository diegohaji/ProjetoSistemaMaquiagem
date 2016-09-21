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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnCliente Cliente = new ClnCliente();
            Cliente.Nm_Cliente = textBoxNome.Text;
            Cliente.CPF_cliente = maskedTextBoxCPF.Text;
            Cliente.Email_cliente = textBoxEmail.Text;
            Cliente.RG_Cliente = maskedTextBoxRG.Text;
            Cliente.Celular_cliente = Convert.ToInt16(maskedTextBoxCelular.Text);
            Cliente.Telefone_cliente = Convert.ToInt16(maskedTextBoxTelefone.Text);
            Cliente.CEP_cliente = Convert.ToInt16(maskedTextBoxCEP.Text);
            Cliente.Rua_cliente = textBoxRua.Text;
            Cliente.Numero_cliente = Convert.ToInt16(textBoxNumero.Text);
            Cliente.Bairro_cliente = textBoxBairro.Text;
            Cliente.Cidade_cliente = textBoxCidade.Text;
            Cliente.Estado_cliente = textBoxEstado.Text;
            Cliente.Complemento_cliente = textBoxComplemento.Text;
            Cliente.Gravar();

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
