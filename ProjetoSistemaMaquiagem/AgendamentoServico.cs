﻿using System;
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

        //inutil
        private void button1_Click(object sender, EventArgs e)
        {

        }

        //load
        private void AgendamentoServico_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.ShowUpDown = true;
            PreencherComboFuncionario();
            PreencherComboServico();
            PreencherComboCliente();
            PreencherComboProduto();
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
            agenda.Hora_agendamento = dateTimePicker2.Value.ToShortTimeString();
            agenda.Nm_pesquisa = comboBoxCliente.Text;
            agenda.Produto = comboBoxProduto.Text;
            agenda.Quantidade = numericUpDownQtd.Value.ToString();
            ClnCliente cliente = new ClnCliente();
            agenda.Cd_cliente = cliente.BuscarId(comboBoxCliente.Text);
            ClnFuncionario funcionario = new ClnFuncionario();
            agenda.Cd_funcionario = funcionario.BuscarId(comboBoxFuncionario.Text);
            ClnServiços servico = new ClnServiços();
            agenda.Cd_servico = servico.BuscarId(comboBoxServico.Text);
            if (verificaText(groupBox1)) { 
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
                comboBoxFuncionario.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
                comboBoxCliente.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                comboBoxServico.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dgv1.CurrentRow.Cells[3].Value.ToString());
                dateTimePicker2.Value = DateTime.ParseExact(dgv1.CurrentRow.Cells[4].Value.ToString(),"HH:mm", System.Globalization.CultureInfo.CurrentCulture, System.Globalization.DateTimeStyles.None);
                comboBoxProduto.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
                numericUpDownQtd.Value = Convert.ToInt32(dgv1.CurrentRow.Cells[6].Value.ToString());
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
            agenda.Hora_agendamento = dateTimePicker1.Value.ToShortTimeString();
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
    }

}
