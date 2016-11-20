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
    public partial class PagamentoServicos : Form
    {
        public PagamentoServicos()
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
            PreencherComboFormaPagamento();
            AtualizarGrid();
            AtualizarGrid2();
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
            //status.Add("Pendente");
            status.Add("Cancelado");
            comboBoxStatus.DataSource = status;
        }

        public void PreencherComboFormaPagamento()
        {
            List<string> Forma = new List<string>();
            Forma.Add("Dinheiro");
            Forma.Add("Cartão de crédito");
            Forma.Add("Cartão de débito");
            comboBoxFormaPagamento.DataSource = Forma;
        }

        public void PreencherValor()
        {/*
            ClnPagamentoServicos lancamento = new ClnPagamentoServicos();
            DataSet ds = new DataSet();
            ds = lancamento.BuscarOValor();
            lancamento.Vl_total = ds.Tables[0].ToString();
        */
            }

        //atualiza o grid 1
        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
            ClnPagamentoServicos lancaservico = new ClnPagamentoServicos();
            lancaservico.Nm_servico = textBoxPesquisar.Text;
            ds = lancaservico.BuscarporDivida();
            dgv1.DataSource = ds.Tables[0];

        }
    
        // atualiza grid 2
        private void AtualizarGrid2()
        {
            DataSet ds = new DataSet();
            ClnPagamentoServicos lancaservico = new ClnPagamentoServicos();
            lancaservico.Nm_servico = textBoxPesquisar.Text;
            ds = lancaservico.BuscarporNome();
            dgv2.DataSource = ds.Tables[0];

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
            ClnPagamentoServicos lancaservico = new ClnPagamentoServicos();
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
            ClnPagamentoServicos lancamento = new ClnPagamentoServicos();
            lancamento.Nm_funcionario = comboBoxFuncionario.Text;
            lancamento.Nm_servico = comboBoxServico.Text;
            lancamento.Status_prestacao = comboBoxStatus.Text;
            lancamento.Dt_prestacao = dateTimePicker1.Value.ToShortDateString();
            lancamento.Dt_pagamento = dateTimePicker2.Value.ToShortDateString();
            lancamento.Hora_prestacao = dateTimePicker3.Value.ToShortTimeString();
            lancamento.Vl_total = textBoxValor.Text;
            lancamento.Formapagamento = comboBoxFormaPagamento.Text;
            ClnCliente cliente = new ClnCliente();
            lancamento.Cd_cliente = cliente.BuscarId(comboBoxCliente.Text);
            ClnFuncionario funcionario = new ClnFuncionario();
            lancamento.Cd_funcionario = funcionario.BuscarId(comboBoxFuncionario.Text);
            ClnServiços servico = new ClnServiços();
            lancamento.Cd_servico = servico.BuscarId(comboBoxServico.Text);
            if (verificaText(groupBox4))
            {
                lancamento.Gravar();
                ClnAgendaDeServico agenda = new ClnAgendaDeServico();
                agenda.Excluir(agenda.BuscarporOrdemPagamento());
                AtualizarGrid();
                AtualizarGrid2();
                LimparTxt(groupBox4);

            }
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {

            ClnPagamentoServicos agenda = new ClnPagamentoServicos();
            string mensagem = "Deseja excluir o cadastro," + comboBoxCliente.Text + " ?";
            int resposta = Convert.ToInt16(MessageBox.Show(mensagem, "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == 6)
            {
                ClnCliente cliente = new ClnCliente();
                agenda.Excluir(cliente.BuscarId(comboBoxCliente.Text));
            }
            LimparTxt(groupBox4);
            AtualizarGrid();
            AtualizarGrid2();
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            ClnPagamentoServicos lancamento = new ClnPagamentoServicos();
            lancamento.Nm_funcionario = comboBoxFuncionario.Text;
            lancamento.Nm_servico = comboBoxServico.Text;
            lancamento.Status_prestacao = comboBoxStatus.Text;
            lancamento.Dt_prestacao = dateTimePicker1.Value.ToShortDateString();
            lancamento.Dt_pagamento = dateTimePicker2.Value.ToShortDateString();
            lancamento.Hora_prestacao = dateTimePicker3.Value.ToShortTimeString();
            lancamento.Vl_total = textBoxValor.Text;
            lancamento.Formapagamento = comboBoxFormaPagamento.Text;
            ClnCliente cliente = new ClnCliente();
            lancamento.Cd_cliente = cliente.BuscarId(comboBoxCliente.Text);
            ClnFuncionario funcionario = new ClnFuncionario();
            lancamento.Cd_funcionario = funcionario.BuscarId(comboBoxFuncionario.Text);
            ClnServiços servico = new ClnServiços();
            lancamento.Cd_servico = servico.BuscarId(comboBoxServico.Text);
            lancamento.Atualizar();
            AtualizarGrid();
            AtualizarGrid2();
            LimparTxt(groupBox4);
        }

        //função do grid
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            if (dgv1.RowCount > 0)
            {
                
                comboBoxFuncionario.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                comboBoxCliente.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                comboBoxServico.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgv1.CurrentRow.Cells[4].Value.ToString());
                dateTimePicker3.Value = DateTime.ParseExact(dgv1.CurrentRow.Cells[5].Value.ToString(), "HH:mm", System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None);
                //comboBoxStatus.Text = dgv1.CurrentRow.Cells[6].Value.ToString();
                textBoxValor.Text = dgv1.CurrentRow.Cells[7].Value.ToString();
            }

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            dgv2.CurrentRow.Selected = true;
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            if (dgv1.RowCount > 0)
            {

                comboBoxFuncionario.Text = dgv2.CurrentRow.Cells[4].Value.ToString();
                comboBoxCliente.Text = dgv2.CurrentRow.Cells[5].Value.ToString();
                comboBoxServico.Text = dgv2.CurrentRow.Cells[6].Value.ToString();
                comboBoxStatus.Text = dgv2.CurrentRow.Cells[7].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgv2.CurrentRow.Cells[8].Value.ToString());
                dateTimePicker2.Value = Convert.ToDateTime(dgv2.CurrentRow.Cells[9].Value.ToString());
                textBoxValor.Text = dgv2.CurrentRow.Cells[10].Value.ToString();
            }
    */
    }
    }
}

