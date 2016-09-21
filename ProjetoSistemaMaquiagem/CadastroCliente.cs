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
