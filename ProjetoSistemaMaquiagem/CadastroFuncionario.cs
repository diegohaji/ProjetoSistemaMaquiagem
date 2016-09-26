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
            LimparTxt(Cadastro);
            LimparTxt(groupBoxEndereco);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnFuncionario funcionario = new ClnFuncionario();
            if (dgv1.RowCount > 0)
            {
                textBoxNome.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
                textBoxEmail.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                maskedTextBoxRG.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBoxCPF.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                maskedTextBoxCelular.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                maskedTextBoxTelefone.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
            }

        }
    }
}