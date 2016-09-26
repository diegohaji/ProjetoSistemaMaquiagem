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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnFuncionario funcionario = new ClnFuncionario();
            funcionario.Nm_Funcionario = textBoxNome.Text;
            funcionario.CPF_Funcionario = maskedTextBoxCPF.Text;
            funcionario.Email_Funcionario = textBoxEmail.Text;
            funcionario.RG_Funcionario = maskedTextBoxRG.Text;
            funcionario.Celular_funcionario = maskedTextBoxCelular.Text;
            funcionario.Telefone_funcionario = maskedTextBoxTelefone.Text;
            funcionario.CEP_funcionario = maskedTextBoxCEP.Text;
            funcionario.Rua_funcionario = textBoxRua.Text;
            funcionario.Numero_funcionario = textBoxNumero.Text;
            funcionario.Bairro_funcionario = textBoxBairro.Text;
            funcionario.Cidade_funcionario = textBoxCidade.Text;
            funcionario.Estado_funcionario = textBoxEstado.Text;
            funcionario.Complemento_funcionario = textBoxComplemento.Text;
            funcionario.Gravar();

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