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
            ClnFuncionario func = new ClnFuncionario();
            func.Nm_Funcionario = textBoxNome.Text;
            func.CPF_Funcionario = textBoxCPF.Text;
            func.Email_Funcionario = textBoxEmail.Text;
            func.RG_Funcionario = textBoxRG.Text;
            func.Gravar();

        }
    }
}
