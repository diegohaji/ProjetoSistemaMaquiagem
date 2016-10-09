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
    public partial class AgendamentoDeHorarios : Form
    {
        //Construtor
        public AgendamentoDeHorarios()
        {
            InitializeComponent();
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
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            agenda.Servico = textBoxPesquisar.Text;
            ds = agenda.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
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

        //preenche o combobox com os valores dos serviços
        public void PreencherComboTipo()
        {
            ClnServiços tipo = new ClnServiços();
            DataSet ds = tipo.BuscarporNome();
            comboBoxServico.DataSource = ds.Tables[0];
            comboBoxServico.DisplayMember = "Nome";
            comboBoxServico.ValueMember = "Codigo";
        }

        //Funcao load que atualiza o grid quando o formulario de agendar é chamado
        private void AgendamentoHorario(object sender, EventArgs e)
        {
            PreencherComboTipo();
            PreencherComboFuncionario();
            AtualizarGrid();
        }

        //Funcao que verifica se há algum campo em branco
        private bool verificaText(Control controles)
        {
            foreach (Control T in controles.Controls)
            {
                if (T is TextBox || T is MaskedTextBox ||T is ComboBox)
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

        //funçao que cadastra o agendamento
        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            agenda.Servico = comboBoxServico.Text;
            agenda.NomeFuncionario = comboBoxFuncionario.Text;
            agenda.Horario = maskedTextBoxHorario.Text;
            if (verificaText(groupBox1))
            {
                agenda.Gravar();
                AtualizarGrid();
                LimparTxt(groupBox1);
            }
        }

        //funcao que é chamada quando é cancelado o cadastro
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            LimparTxt(groupBox1);
        }

        //função do grid
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            if (dgv1.RowCount > 0)
            {
                comboBoxFuncionario.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                comboBoxServico.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBoxHorario.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            }

        }

        //função que é chamada para excluir algum horario
        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja excluir o cadastro," + comboBoxFuncionario.Text + " ?";
            int resposta = Convert.ToInt16(MessageBox.Show(mensagem, "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == 6)
            {
                ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
                agenda.Excluir(comboBoxFuncionario.Text);
            }
            LimparTxt(groupBox1);
            AtualizarGrid();
        }

        //funcao de pesquisar
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ClnCliente cliente = new ClnCliente();
            cliente.Nm_Cliente = textBoxPesquisar.Text;
            ds = cliente.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];

        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {

            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            agenda.Servico = comboBoxServico.Text;
            agenda.NomeFuncionario = comboBoxFuncionario.Text;
            agenda.Horario = maskedTextBoxHorario.Text;
            ClnFuncionario func = new ClnFuncionario();
            agenda.Cd_funcionario = func.BuscarId(comboBoxFuncionario.Text);
            agenda.Atualizar();
            AtualizarGrid();
            LimparTxt(groupBox1);
        }
    }
}
