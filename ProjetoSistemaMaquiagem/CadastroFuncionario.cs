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
using System.ServiceModel;

namespace ProjetoSistemaMaquiagem
{
    public partial class CadastroFuncionario : Form
    {
        //Contrutor
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        //função que carrega o grid quando o formulario é chamado
        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

            try
            {
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Fudeu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //limpa o texto da caixa de texto do grupo
        public void LimparTxt(Control controles)
        {
            foreach (Control ctl in controles.Controls)
            {
                if (ctl is TextBox) ctl.Text = string.Empty;
                if (ctl is MaskedTextBox) ctl.Text = string.Empty;
            }
        }

        //atualiza o grid
        private void AtualizarGrid()
        {

            DataSet ds = new DataSet();
           // DataSet ds1 = new DataSet();
            ClnFuncionario funcionario = new ClnFuncionario();
            funcionario.Nm_Funcionario = textBoxPesquisar.Text;
            ds = funcionario.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
            //ds1 = funcionario.BuscaporEndereco();
            //dgv1.DataSource =ds1.Tables[0];

        }

        //Funcao que verifica se há algum campo em branco
        private bool verificaText(Control controles)
        {
            foreach (Control T in controles.Controls)
            {
                if (T is TextBox || T is MaskedTextBox)
                {
                    if (T.Text == string.Empty)
                    {
                        MessageBox.Show("Há campos vazios\nFavor verificar!", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        //funcao que busca o endereco dado o cep
        private void maskedTextBoxCEP_Leave(object sender, EventArgs e)
        {

            try
            {
                APICorreios.AtendeClienteClient consulta = new APICorreios.AtendeClienteClient("AtendeClientePort");

                var resultado = consulta.consultaCEP(maskedTextBoxCEP.Text);

                if (resultado != null)
                {
                    textBoxRua.Text = resultado.end;
                    textBoxComplemento.Text = resultado.complemento;
                    textBoxBairro.Text = resultado.bairro;
                    textBoxCidade.Text = resultado.cidade;
                    textBoxEstado.Text = resultado.uf;
                    //lblInformacoes.Text = "Consulta Realizada Com Sucesso!";
                }
                //maskedTextBoxCEP.Clear();
            }
            catch (FaultException)
            {
                MessageBox.Show("CEP NÃO ENCONTRADO OU INVALIDO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBoxCEP.Clear();
                maskedTextBoxCEP.Focus();
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Não foi possivel completar a operação\nVerifique sua conexão com a internet.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextBoxCEP.Clear();
            }

        }

        //funçao que cadastra o cliente
        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ClnFuncionario funcionario = new ClnFuncionario();
                funcionario.Nm_Funcionario = textBoxNome.Text;
                funcionario.RG_Funcionario = maskedTextBoxRG.Text;
                funcionario.CPF_Funcionario = maskedTextBoxCPF.Text;
                funcionario.Email_Funcionario = textBoxEmail.Text;
                funcionario.Celular_funcionario = maskedTextBoxCelular.Text;
                funcionario.Telefone_funcionario = maskedTextBoxTelefone.Text;
                funcionario.CEP_funcionario = maskedTextBoxCEP.Text;
                funcionario.Rua_funcionario = textBoxRua.Text;
                funcionario.Numero_funcionario = textBoxNumero.Text;
                funcionario.Bairro_funcionario = textBoxBairro.Text;
                funcionario.Cidade_funcionario = textBoxCidade.Text;
                funcionario.Estado_funcionario = textBoxEstado.Text;
                funcionario.Complemento_funcionario = textBoxComplemento.Text;
                if (verificaText(Cadastro) && verificaText(groupBoxEndereco))
                {
                    funcionario.Gravar();
                    AtualizarGrid();
                    LimparTxt(Cadastro);
                    LimparTxt(groupBoxEndereco);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //funcao que é chamada quando é cancelado o cadastro
        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            LimparTxt(Cadastro);
            LimparTxt(groupBoxEndereco);
        }

        //função do grid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnFuncionario funcionario = new ClnFuncionario();
            if (dgv1.RowCount > 0)
            {
                textBoxNome.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                maskedTextBoxCPF.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                maskedTextBoxRG.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                textBoxEmail.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                // maskedTextBoxCelular.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                // maskedTextBoxTelefone.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
                maskedTextBoxCEP.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
                textBoxEstado.Text = dgv1.CurrentRow.Cells[10].Value.ToString();
                textBoxCidade.Text = dgv1.CurrentRow.Cells[9].Value.ToString();
                textBoxBairro.Text = dgv1.CurrentRow.Cells[8].Value.ToString();
                textBoxRua.Text = dgv1.CurrentRow.Cells[7].Value.ToString();
                textBoxNumero.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
                textBoxComplemento.Text = dgv1.CurrentRow.Cells[11].Value.ToString();


            }

        }

        //função que é chamada para excluir algum horario
        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja excluir o cadastro," + textBoxNome.Text + " ?";
            int resposta = Convert.ToInt16(MessageBox.Show(mensagem, "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == 6)
            {
                ClnFuncionario funcionario = new ClnFuncionario();
                funcionario.Excluir(funcionario.BuscarId(textBoxNome.Text));
            }
            LimparTxt(Cadastro);
            AtualizarGrid();
        }

        //Funcao para editar algum cadastro NAO ESTÁ FUNCIONANDO!!!!
        private void BotaoEditar_Click(object sender, EventArgs e)
        {

            ClnFuncionario funcionario = new ClnFuncionario();
            funcionario.Nm_Funcionario = textBoxNome.Text;
            funcionario.RG_Funcionario = maskedTextBoxRG.Text;
            funcionario.CPF_Funcionario = maskedTextBoxCPF.Text;
            funcionario.Email_Funcionario = textBoxEmail.Text;
            funcionario.Celular_funcionario = maskedTextBoxCelular.Text;
            funcionario.Telefone_funcionario = maskedTextBoxTelefone.Text;
            funcionario.CEP_funcionario = maskedTextBoxCEP.Text;
            funcionario.Rua_funcionario = textBoxRua.Text;
            funcionario.Numero_funcionario = textBoxNumero.Text;
            funcionario.Bairro_funcionario = textBoxBairro.Text;
            funcionario.Cidade_funcionario = textBoxCidade.Text;
            funcionario.Estado_funcionario = textBoxEstado.Text;
            funcionario.Complemento_funcionario = textBoxComplemento.Text;
            funcionario.Cd_Funcionario = funcionario.BuscarId(textBoxNome.Text);
            funcionario.Atualizar();
            LimparTxt(Cadastro);
            LimparTxt(groupBoxEndereco);
        }

        //funcao de pesquisa
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ClnFuncionario funcionario = new ClnFuncionario();
            funcionario.Nm_Funcionario = textBoxPesquisar.Text;
            ds = funcionario.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
        }

    }
}