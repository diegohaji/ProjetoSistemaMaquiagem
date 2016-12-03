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
    public partial class AgendamentoServico : Form
    {
        public AgendamentoServico()
        {
            InitializeComponent();
        }

        //load
        private void AgendamentoServico_Load(object sender, EventArgs e)
        {
            PreencherComboFuncionario();
            PreencherComboServico();
            PreencherComboCliente();
            PreencherComboProduto();
            HorarioDoDia();
            AtualizarGrid();
        }

        //preenche o combobox com os valores dos funcionarios
        public void PreencherComboFuncionario()
        {
            ClnFuncionario tipo = new ClnFuncionario();
            DataSet ds = tipo.BuscarporNome();
            comboBoxFuncionario.DataSource = ds.Tables[0];
            comboBoxFuncionario.DisplayMember = "Nome";
            comboBoxFuncionario.ValueMember = "Codigo";
        }

        //preenche o combobox com os valores dos funcionarios
        public void PreencherComboServico()
        {
            ClnServiços tipo = new ClnServiços();
            DataSet ds = tipo.BuscarporNome();
            comboBoxServico.DataSource = ds.Tables[0];
            comboBoxServico.DisplayMember = "Nome";
            comboBoxServico.ValueMember = "Codigo";
        }

        //preenche o combobox com os valores dos clientes
        public void PreencherComboCliente()
        {
            ClnCliente tipo = new ClnCliente();
            DataSet ds = tipo.BuscarporNome();
            comboBoxCliente.DataSource = ds.Tables[0];
            comboBoxCliente.DisplayMember = "Nome";
            comboBoxCliente.ValueMember = "Codigo";
        }

        public void PreencherComboProduto()
        {
            ClnProdutos tipo = new ClnProdutos();
            DataSet ds = tipo.BuscarporNome();
            comboBoxProduto.DataSource = ds.Tables[0];
            comboBoxProduto.DisplayMember = "Nome";
            comboBoxProduto.ValueMember = "Codigo";
        }

        public void PreencherComboHorario(DataSet pesquisa)
        {
            ClnAgendaDeHorario tipo = new ClnAgendaDeHorario();
            DataSet ds = pesquisa;
            comboBoxHorario.DataSource = ds.Tables[0];
            comboBoxHorario.DisplayMember = "Horarioinicial";
            comboBoxHorario.ValueMember = "Horarioinicial";
        }

        //atualiza o grid
        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
            ClnAgendaDeServico agenda = new ClnAgendaDeServico();
            agenda.Nm_pesquisa = textBoxPesquisar.Text;
            ds = agenda.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];

        }

        //Funcao que verifica se há algum campo em branco
        private bool verificaText(Control controles)
        {
            foreach (Control T in controles.Controls)
            {
                if (T is TextBox)
                {
                    if (string.IsNullOrEmpty(T.Text) || string.IsNullOrWhiteSpace(T.Text))
                    {
                        MessageBox.Show("Há campos vazios\nFavor verificar!", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;

                    }
                }
                if (T is ComboBox)
                {
                    if (string.IsNullOrEmpty(T.Text) || string.IsNullOrWhiteSpace(T.Text))
                    {
                        MessageBox.Show("Há campos vazios\nFavor verificar!", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;

                    }
                }
                if (T is MaskedTextBox)
                {
                    if (string.IsNullOrEmpty(T.Text) || string.IsNullOrWhiteSpace(T.Text))
                    {
                        MessageBox.Show("Há campos vazios\nFavor verificar!", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;

                    }
                }
            }
            return true;
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


        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnAgendaDeServico agenda = new ClnAgendaDeServico();
            agenda.Dt_agendamento = dateTimePicker1.Value.ToShortDateString();
            agenda.Cd_cliente = Convert.ToInt16(textBoxCliente.Text);
            agenda.Hora_agendamento = comboBoxHorario.Text;
            agenda.Nm_pesquisa = comboBoxCliente.Text;
            agenda.Produto = comboBoxProduto.Text;
            agenda.Quantidade = numericUpDownQtd.Value.ToString();
            agenda.Cd_funcionario = Convert.ToInt16(textBoxFuncionario.Text);
            agenda.Cd_servico = Convert.ToInt16(textBoxServico.Text);
            agenda.Cd_produto = Convert.ToInt16(textBoxProduto.Text);
            if (verificaText(groupBox1))
            {
                agenda.Gravar();
                AtualizarGrid();
                LimparTxt(groupBox1);
                ClnEstoque estoque = new ClnEstoque();
                estoque.Nm_Produto = agenda.Produto;
                estoque.Qtd_Atual = Convert.ToString(Convert.ToInt32(estoque.BuscarporQtdAtual(agenda.Produto)) - Convert.ToInt32(agenda.Quantidade));
                estoque.Qtd_Minimo = estoque.BuscarporQtdMinima(agenda.Produto);
                estoque.Cd_Produto = estoque.BuscarporCodigoProduto();
                estoque.Cd_Estoque = estoque.BuscarporCodigoEstoque();
                estoque.Atualizar();
            }

        }


        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnAgendaDeServico agenda = new ClnAgendaDeServico(); ;
            if (dgv1.RowCount > 0)
            {
                textBoxFuncionario.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
                textBoxCliente.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                textBoxServico.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                textBoxProduto.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                comboBoxFuncionario.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                comboBoxCliente.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
                comboBoxServico.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgv1.CurrentRow.Cells[7].Value.ToString());
                comboBoxHorario.Text = dgv1.CurrentRow.Cells[8].ToString();
                comboBoxProduto.Text = dgv1.CurrentRow.Cells[9].Value.ToString();
                numericUpDownQtd.Value = Convert.ToInt32(dgv1.CurrentRow.Cells[10].Value.ToString());
            }
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            ClnAgendaDeServico agenda = new ClnAgendaDeServico();
            string mensagem = "Deseja excluir o cadastro," + comboBoxCliente.Text + " ?";
            int resposta = Convert.ToInt16(MessageBox.Show(mensagem, "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == 6)
            {
                ClnCliente cliente = new ClnCliente();
                agenda.Excluir(cliente.BuscarId(comboBoxCliente.Text));
            }
            LimparTxt(groupBox1);
            AtualizarGrid();
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            ClnAgendaDeServico agenda = new ClnAgendaDeServico();
            agenda.Dt_agendamento = dateTimePicker1.Value.ToShortDateString();
            //agenda.Hora_agendamento = dateTimePicker1.Value.ToShortTimeString();
            agenda.Hora_agendamento = comboBoxHorario.Text;
            agenda.Nm_pesquisa = comboBoxCliente.Text;
            ClnCliente cliente = new ClnCliente();
            agenda.Cd_cliente = cliente.BuscarId(comboBoxCliente.Text);
            ClnFuncionario funcionario = new ClnFuncionario();
            agenda.Cd_funcionario = funcionario.BuscarId(comboBoxFuncionario.Text);
            ClnServiços servico = new ClnServiços();
            agenda.Cd_servico = servico.BuscarId(comboBoxServico.Text);
            agenda.Atualizar();
            AtualizarGrid();
            LimparTxt(groupBox1);
        }

        //funcao de pesquisa
        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ClnAgendaDeServico agenda = new ClnAgendaDeServico();
            agenda.Nm_pesquisa = textBoxPesquisar.Text;
            ds = agenda.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            HorarioDoDia();
        }

        private void HorarioDoDia()
        {
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            if (dateTimePicker1.Value.DayOfWeek.ToString() == "Segunda" || dateTimePicker1.Value.DayOfWeek.ToString() == "Monday")
            {
                PreencherComboHorario(agenda.BuscarporDiaSegunda());
            }
            else if (dateTimePicker1.Value.DayOfWeek.ToString() == "Terca" || dateTimePicker1.Value.DayOfWeek.ToString() == "Tuesday")
            {
                PreencherComboHorario(agenda.BuscarporDiaTerca());
            }
            else if (dateTimePicker1.Value.DayOfWeek.ToString() == "Quarta" || dateTimePicker1.Value.DayOfWeek.ToString() == "Wednesday")
            {
                PreencherComboHorario(agenda.BuscarporDiaQuarta());
            }
            else if (dateTimePicker1.Value.DayOfWeek.ToString() == "Quinta" || dateTimePicker1.Value.DayOfWeek.ToString() == "Thursday")
            {
                PreencherComboHorario(agenda.BuscarporDiaQuinta());
            }
            else if (dateTimePicker1.Value.DayOfWeek.ToString() == "Sexta" || dateTimePicker1.Value.DayOfWeek.ToString() == "Friday")
            {
                PreencherComboHorario(agenda.BuscarporDiaSexta());
            }
            else if (dateTimePicker1.Value.DayOfWeek.ToString() == "Sabado" || dateTimePicker1.Value.DayOfWeek.ToString() == "Saturday")
            {
                PreencherComboHorario(agenda.BuscarporDiaSabado());
            }
            else if (dateTimePicker1.Value.DayOfWeek.ToString() == "Domingo" || dateTimePicker1.Value.DayOfWeek.ToString() == "Sunday")
            {
                PreencherComboHorario(agenda.BuscarporDiaDomingo());
            }


        }

        private void buttonFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario func = new CadastroFuncionario();
            func.FormClosing += new FormClosingEventHandler(AtualizarCadastros);
            func.Show();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cli = new CadastroCliente();
            cli.FormClosing += new FormClosingEventHandler(AtualizarCadastros);
            cli.Show();
        }

        private void buttonServico_Click(object sender, EventArgs e)
        {
            CadastroServiços serv = new CadastroServiços();
            serv.FormClosed += new FormClosedEventHandler(AtualizarCadastros);
            serv.Show();

        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            CadastroProduto prod = new CadastroProduto();
            prod.FormClosing += new FormClosingEventHandler(AtualizarCadastros);
            prod.Show();
        }

        private void AtualizarCadastros(object sender, EventArgs e)
        {

            PreencherComboCliente();
            PreencherComboFuncionario();
            PreencherComboServico();
            PreencherComboProduto();
            HorarioDoDia();

        }

        private void buttonHorario_Click(object sender, EventArgs e)
        {
            AgendamentoDeHorarios agenda = new AgendamentoDeHorarios();
            agenda.FormClosing += new FormClosingEventHandler(AtualizarCadastros);
            agenda.Show();
        }

        private void buttonQuantidade_Click(object sender, EventArgs e)
        {
            ControleEstoque estoque = new ControleEstoque();
            estoque.Show();
        }

        private void textBoxFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxFuncionario.Text.Equals(""))
            {
                ClnFuncionario func = new ClnFuncionario();
                func.Cd_Funcionario = Convert.ToInt16(textBoxFuncionario.Text);
                func.BuscarporCodigo();
                if (!func.Equals(null))
                {
                    comboBoxFuncionario.Text = func.Nm_Funcionario;
                }
            }
        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {

            if (!textBoxCliente.Text.Equals(""))
            {
                ClnCliente cliente = new ClnCliente();
                cliente.Cd_cliente = Convert.ToInt16(textBoxCliente.Text);
                cliente.BuscarporCodigo();
                if (!cliente.Equals(null))
                {
                    comboBoxCliente.Text = cliente.Nm_Cliente;
                }
            }
        }

        private void textBoxServico_TextChanged(object sender, EventArgs e)
        {

            if (!textBoxServico.Text.Equals(""))
            {
                ClnServiços servico = new ClnServiços();
                servico.Cd_Servico = Convert.ToInt16(textBoxServico.Text);
                servico.BuscarporCodigo();
                if (!servico.Equals(null))
                {
                    comboBoxServico.Text = servico.Nm_Servico;
                }
            }
        }

        private void textBoxProduto_TextChanged(object sender, EventArgs e)
        {

            if (!textBoxProduto.Text.Equals(""))
            {
                ClnProdutos produto = new ClnProdutos();
                produto.Cd_Produto = Convert.ToInt16(textBoxProduto.Text);
                produto.BuscarporCodigo();
                if (!produto.Equals(null))
                {
                    comboBoxProduto.Text = produto.Nm_Produto;
                }
            }
        }

    }

}
