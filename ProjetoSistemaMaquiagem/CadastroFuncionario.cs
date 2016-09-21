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
            funcionario.Celular_funcionario = Convert.ToInt16(maskedTextBoxCelular.Text);
            funcionario.Telefone_funcionario = Convert.ToInt16(maskedTextBoxTelefone.Text);
            funcionario.CEP_funcionario = Convert.ToInt16(maskedTextBoxCEP.Text);
            funcionario.Rua_funcionario = textBoxRua.Text;
            funcionario.Numero_funcionario = Convert.ToInt16(textBoxNumero.Text);
            funcionario.Bairro_funcionario = textBoxBairro.Text;
            funcionario.Cidade_funcionario = textBoxCidade.Text;
            funcionario.Estado_funcionario = textBoxEstado.Text;
            funcionario.Complemento_funcionario = textBoxComplemento.Text;
            funcionario.Gravar();

        }
    }
}