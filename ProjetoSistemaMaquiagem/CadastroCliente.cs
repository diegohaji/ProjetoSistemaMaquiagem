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
using System.ServiceModel;

namespace ProjetoSistemaMaquiagem
{
    public partial class CadastroCliente : Form
    {
        //construtor
        public CadastroCliente()
        {
            InitializeComponent();
        }

        //função que carrega o grid quando o formulario é chamado
        private void CadastroCliente_Load(Object sender, EventArgs e)
        {
            AtualizarGrid();
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
            ClnCliente cliente = new ClnCliente();
            cliente.Nm_Cliente = textBoxPesquisar.Text;
            ds = cliente.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
            
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

        //funçao que cadastra o cliente
        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ClnCliente Cliente = new ClnCliente();
                Cliente.Nm_Cliente = textBoxNome.Text;
                Cliente.CPF_cliente = maskedTextBoxCPF.Text;
                Cliente.Email_cliente = textBoxEmail.Text;
                Cliente.RG_Cliente = maskedTextBoxRG.Text;
                Cliente.Celular_cliente = maskedTextBoxCelular.Text;
                Cliente.Telefone_cliente = maskedTextBoxTelefone.Text;
                Cliente.CEP_cliente = textBoxCEP.Text;
                Cliente.Rua_cliente = textBoxRua.Text;
                Cliente.Numero_cliente = textBoxNumero.Text;
                Cliente.Bairro_cliente = textBoxBairro.Text;
                Cliente.Cidade_cliente = textBoxCidade.Text;
                Cliente.Estado_cliente = textBoxEstado.Text;
                Cliente.Complemento_cliente = textBoxComplemento.Text;

                if (verificaText(Cadastro) && verificaText(groupBoxEndereco))
                {
                    Cliente.Gravar();
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
            LimparTxt(groupBoxEndereco);
            LimparTxt(Cadastro);

        }

        //função do grid
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnCliente cliente = new ClnCliente();

            if (dgv1.RowCount > 0)
            {
                textBoxNome.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                maskedTextBoxRG.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBoxCPF.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                textBoxEmail.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                //maskedTextBoxCelular.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                //maskedTextBoxTelefone.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
                textBoxCEP.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
                textBoxEstado.Text = dgv1.CurrentRow.Cells[10].Value.ToString();
                textBoxCidade.Text = dgv1.CurrentRow.Cells[9].Value.ToString();
                textBoxBairro.Text = dgv1.CurrentRow.Cells[8].Value.ToString();
                textBoxRua.Text = dgv1.CurrentRow.Cells[7].Value.ToString();
                textBoxNumero.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
                textBoxComplemento.Text = dgv1.CurrentRow.Cells[11].Value.ToString();
                

            }
        }

        //funcao de pesquisa
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ClnCliente cliente = new ClnCliente();
            cliente.Nm_Cliente = textBoxPesquisar.Text;
            ds = cliente.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
        }

        //função que é chamada para excluir algum horario
        private void BotaoExcluir_Click(object sender, EventArgs e)
        {

            string mensagem = "Deseja excluir o cadastro," + textBoxNome.Text + " ?";
            int resposta = Convert.ToInt16(MessageBox.Show(mensagem, "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == 6)
            {
                ClnCliente cliente = new ClnCliente();
                cliente.Excluir(cliente.BuscarId(textBoxNome.Text));
            }
            LimparTxt(Cadastro);
            AtualizarGrid();
        }

        //funcao que busca o endereco dado o cep
        private void textBoxCEP_Leave(object sender, EventArgs e)
        {
            try
            {
                APICorreios.AtendeClienteClient consulta = new APICorreios.AtendeClienteClient("AtendeClientePort");

                var resultado = consulta.consultaCEP(textBoxCEP.Text);

                if (resultado != null)
                {
                    textBoxRua.Text = resultado.end;
                    textBoxComplemento.Text = resultado.complemento;
                    textBoxBairro.Text = resultado.bairro;
                    textBoxCidade.Text = resultado.cidade;
                    textBoxEstado.Text = resultado.uf;
                    //lblInformacoes.Text = "Consulta Realizada Com Sucesso!";
                }
                //textBoxCEP.Clear();
            }
            catch (FaultException)
            {
                MessageBox.Show("CEP NÃO ENCONTRADO OU INVALIDO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCEP.Clear();
                textBoxCEP.Focus();
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("Não foi possivel completar a operação\nVerifique sua conexão com a internet.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxCEP.Clear();
            }
        }

        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            ClnCliente Cliente = new ClnCliente();
            Cliente.Nm_Cliente = textBoxNome.Text;
            Cliente.CPF_cliente = maskedTextBoxCPF.Text;
            Cliente.Email_cliente = textBoxEmail.Text;
            Cliente.RG_Cliente = maskedTextBoxRG.Text;
            Cliente.Celular_cliente = maskedTextBoxCelular.Text;
            Cliente.Telefone_cliente = maskedTextBoxTelefone.Text;
            Cliente.CEP_cliente = textBoxCEP.Text;
            Cliente.Rua_cliente = textBoxRua.Text;
            Cliente.Numero_cliente = textBoxNumero.Text;
            Cliente.Bairro_cliente = textBoxBairro.Text;
            Cliente.Cidade_cliente = textBoxCidade.Text;
            Cliente.Estado_cliente = textBoxEstado.Text;
            Cliente.Complemento_cliente = textBoxComplemento.Text;
            Cliente.Cd_cliente = Cliente.BuscarId(textBoxNome.Text);
            Cliente.Atualizar();
            AtualizarGrid();
            LimparTxt(Cadastro);
            LimparTxt(groupBoxEndereco);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

