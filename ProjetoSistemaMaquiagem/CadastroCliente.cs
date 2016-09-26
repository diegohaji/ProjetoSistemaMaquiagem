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
using MySql.Data.MySqlClient;

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
            StringBuilder mensagem = new StringBuilder();
            ClnCliente Cliente = new ClnCliente();
            Cliente.Nm_Cliente = textBoxNome.Text;
            Cliente.CPF_cliente = maskedTextBoxCPF.Text;
            Cliente.Email_cliente = textBoxEmail.Text;
            Cliente.RG_Cliente = maskedTextBoxRG.Text;
            Cliente.Celular_cliente = maskedTextBoxCelular.Text;
            Cliente.Telefone_cliente = maskedTextBoxTelefone.Text;
            Cliente.CEP_cliente = maskedTextBoxCEP.Text;
            Cliente.Rua_cliente = textBoxRua.Text;
            Cliente.Numero_cliente = textBoxNumero.Text;
            Cliente.Bairro_cliente = textBoxBairro.Text;
            Cliente.Cidade_cliente = textBoxCidade.Text;
            Cliente.Estado_cliente = textBoxEstado.Text;
            Cliente.Complemento_cliente = textBoxComplemento.Text;
            if (string.IsNullOrEmpty(textBoxNome.Text))
            {
                mensagem.Append("Campo Nome em branco.\n");
            }else 
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                mensagem.Append("Campo Email em branco.\n");
            }else
            if (string.IsNullOrEmpty(maskedTextBoxRG.Text))
            {
                mensagem.Append("Campo RG em branco.\n");
            }else
            if (string.IsNullOrEmpty(maskedTextBoxCPF.Text))
            {
                mensagem.Append("Campo CPF em branco.\n");
            }


            if (string.IsNullOrWhiteSpace(mensagem.ToString()))
            {
                Cliente.Gravar();
            }
            else
            {
                MessageBox.Show(mensagem.ToString(), "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            try {
            }catch(MySqlException msqlex)
            {

                MessageBox.Show(msqlex.ToString(),"Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            /*  ClnValidacao validar = new ClnValidacao();
if (validar.ValidaCPF(maskedTextBoxCPF.Text))
{
Cliente.Gravar();
}
else
{
MessageBox.Show("Campo de CPF inválido! \nDigite novamente","Campo inválido." ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
}

*/
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

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            textBoxBairro.Text = null;
            textBoxCidade.Text = null;
            textBoxComplemento.Text = null;
            textBoxEmail.Text = null;
            textBoxEstado.Text = null;
            textBoxNome.Text = null;
            textBoxNumero.Text = null;
            textBoxRua.Text = null;
            maskedTextBoxCelular.Text = null;
            maskedTextBoxCEP.Text = null;
            maskedTextBoxCPF.Text = null;
            maskedTextBoxRG.Text = null;
            maskedTextBoxTelefone.Text = null;

        }
    }
}
