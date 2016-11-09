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
    public partial class LancamentoServicos : Form
    {
        public LancamentoServicos()
        {
            InitializeComponent();
        }
 

        //load
        private void LancamentoServico_Load(object sender, EventArgs e)
        {
            PreencherComboFuncionario();
            PreencherComboServico();
            PreencherComboCliente();
            PreencherComboStatus();
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

        //preenche o combobox com o valor do status 
        public void PreencherComboStatus()
        {
            List<string> status = new List<string>();
            status.Add("Finalizado");
            status.Add("Pendente");
            status.Add("Cancelado");
            comboBoxStatus.DataSource = status;
        }

        //atualiza o grid
        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
            ClnLancamentoServicos lancaservico = new ClnLancamentoServicos();
            lancaservico.Nm_servico = textBoxPesquisar.Text;
            ds = lancaservico.BuscarporNome();
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

        //funcao de pesquisa
        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ClnLancamentoServicos lancaservico = new ClnLancamentoServicos();
            lancaservico.Nm_servico = textBoxPesquisar.Text;
            ds = lancaservico.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
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

        //cancelar
        private void Cancelar_Click(object sender, EventArgs e)
        {
            LimparTxt(groupBox4);
        }

        //confirmar
        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnLancamentoServicos lancamento = new ClnLancamentoServicos();
            lancamento.Nm_funcionario = comboBoxFuncionario.Text;
            lancamento.Nm_servico = comboBoxServico.Text;
            lancamento.Status_prestacao = comboBoxStatus.Text;
            lancamento.Dt_prestacao = dateTimePicker1.Value.ToShortDateString();
            lancamento.Dt_pagamento = dateTimePicker2.Value.ToShortDateString();
            DataSet ds = new DataSet();
            ds = lancamento.BuscarOValor();
            lancamento.Vl_total = ds.Tables[0].ToString();
            ClnCliente cliente = new ClnCliente();
            lancamento.Cd_cliente = cliente.BuscarId(comboBoxCliente.Text);
            ClnFuncionario funcionario = new ClnFuncionario();
            lancamento.Cd_funcionario = funcionario.BuscarId(comboBoxFuncionario.Text);
            ClnServiços servico = new ClnServiços();
            lancamento.Cd_servico = servico.BuscarId(comboBoxServico.Text);
            if (verificaText(groupBox4))
            {
                lancamento.Gravar();
                AtualizarGrid();
                LimparTxt(groupBox4);
            }
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {

            ClnLancamentoServicos agenda = new ClnLancamentoServicos();
            string mensagem = "Deseja excluir o cadastro," + comboBoxCliente.Text + " ?";
            int resposta = Convert.ToInt16(MessageBox.Show(mensagem, "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == 6)
            {
                ClnCliente cliente = new ClnCliente();
                agenda.Excluir(cliente.BuscarId(comboBoxCliente.Text));
            }
            LimparTxt(groupBox4);
            AtualizarGrid();
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            ClnLancamentoServicos lancamento = new ClnLancamentoServicos();
            lancamento.Nm_funcionario = comboBoxFuncionario.Text;
            lancamento.Nm_servico = comboBoxServico.Text;
            lancamento.Status_prestacao = comboBoxStatus.Text;
            lancamento.Dt_prestacao = dateTimePicker1.Value.ToShortDateString();
            lancamento.Dt_pagamento = dateTimePicker2.Value.ToShortDateString();
            lancamento.Vl_total = textBoxValor.Text;
            ClnCliente cliente = new ClnCliente();
            lancamento.Cd_cliente = cliente.BuscarId(comboBoxCliente.Text);
            ClnFuncionario funcionario = new ClnFuncionario();
            lancamento.Cd_funcionario = funcionario.BuscarId(comboBoxFuncionario.Text);
            ClnServiços servico = new ClnServiços();
            lancamento.Cd_servico = servico.BuscarId(comboBoxServico.Text);
            lancamento.Atualizar();
            AtualizarGrid();
            LimparTxt(groupBox4);
        }

        //função do grid
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            if (dgv1.RowCount > 0)
            {
                
                comboBoxFuncionario.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
                comboBoxCliente.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                comboBoxServico.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                comboBoxStatus.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker2.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
                textBoxValor.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
            }

        }

    }
}

