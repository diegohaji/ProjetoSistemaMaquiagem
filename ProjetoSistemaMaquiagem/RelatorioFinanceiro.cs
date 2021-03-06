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
using System.Diagnostics;
using Microsoft.Reporting.WinForms;

namespace ProjetoSistemaMaquiagem
{
    public partial class RelatorioFinanceiro : Form
    {
        public RelatorioFinanceiro()
        {
            InitializeComponent();
        }


        public void PreencherComboFuncionario()
        {
            ClnFuncionario tipo = new ClnFuncionario();
            DataSet ds = tipo.BuscarporNome();
            comboBoxFuncionario.DataSource = ds.Tables[0];
            comboBoxFuncionario.DisplayMember = "Nome";
            comboBoxFuncionario.ValueMember = "Codigo";
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


        private void Relatorio_Financeiro_load(object sender, EventArgs e)
        {

            PreencherComboCliente();
            PreencherComboFuncionario();
            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
            //this.reportViewer3.RefreshReport();
        }

        private void buttonPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTableFuncionarioTableAdapter.Fill(this.dataSet1.DataTableFuncionario, comboBoxFuncionario.Text);
                this.reportViewer2.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar\nFavor clicar novamente!", "Falha", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {

                this.dataTableClienteTableAdapter.Fill(this.dataSet1.DataTableCliente, comboBoxCliente.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar\nFavor clicar novamente!", "Falha", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void PesquisarPeriodo_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTablePeriodoTableAdapter.Fill(this.dataSet1.DataTablePeriodo, dateTimePickerInicial.Value.ToShortDateString(), dateTimePickerFinal.Value.ToShortDateString());
                this.reportViewer3.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar\nFavor clicar novamente!", "Falha", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }


        }

        
        private void buttonPeriodoTotal_Click(object sender, EventArgs e)
        {
            JanelaRelatorioPeriodoTotal jrpt = new JanelaRelatorioPeriodoTotal();
            jrpt.Show();
        }

        private void buttonTodosFuncionarios_Click(object sender, EventArgs e)
        {
            JanelaRelatorioTotalFuncionarios jrtf = new JanelaRelatorioTotalFuncionarios();
            jrtf.Show();
        }

        private void buttonTodosClientes_Click(object sender, EventArgs e)
        {
            JanelaRelatorioTotalClientes jrtc = new JanelaRelatorioTotalClientes();
            jrtc.Show();
        }
    }
}
