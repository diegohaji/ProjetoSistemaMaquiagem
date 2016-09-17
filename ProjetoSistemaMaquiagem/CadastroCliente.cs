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
            ClnCliente cli = new ClnCliente();
            cli.Nm_Cliente = textBoxNome.Text;
            cli.CPF_cliente = textBoxCPF.Text;
            cli.Email_cliente = textBoxEmail.Text;
            cli.rg = textBoxRG.Text;
            func.Gravar();

        }
    }
}
