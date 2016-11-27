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
using System.Diagnostics;

namespace ProjetoSistemaMaquiagem
{
    public partial class RelatorioFinanceiro : Form
    {
        public RelatorioFinanceiro()
        {
            InitializeComponent();
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

        //preenche o combobox com os valores dos clientes
        public void PreencherComboCliente()
        {
            ClnCliente tipo = new ClnCliente();
            DataSet ds = tipo.BuscarporNome();
            comboBoxCliente.DataSource = ds.Tables[0];
            comboBoxCliente.DisplayMember = "Nome";
            comboBoxCliente.ValueMember = "Codigo";
        }

        //atualiza o grid

        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
            ClnRelatorio agenda = new ClnRelatorio();
            //agenda.Nm_pesquisa = textBoxPesquisar.Text;
            ds = agenda.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];

        }


        private void Relatorio_Financeiro_load(object sender, EventArgs e)
        {
            PreencherComboCliente();
            PreencherComboFuncionario();
            AtualizarGrid();
            
        }

        private void buttonPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            ClnRelatorio relatorio = new ClnRelatorio();
            relatorio.Nome_funcionario = comboBoxFuncionario.Text;


            //AtualizarGrid();

            DataSet ds = new DataSet();
            ds = relatorio.BuscarporNomeFuncionario();
            dgv1.DataSource = ds.Tables[0];
           

        }

        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
        {
            ClnRelatorio relatorio = new ClnRelatorio();
            relatorio.Nome_cliente = comboBoxCliente.Text;

            //AtualizarGrid();
            DataSet ds = new DataSet();
            ds = relatorio.BuscarporNomeCliente();
            dgv1.DataSource = ds.Tables[0];
                    }

        private void PesquisarPeriodo_Click(object sender, EventArgs e)
        {
            ClnRelatorio relatorio = new ClnRelatorio();
            relatorio.Data_final = dateTimePickerFinal.Value.ToShortDateString();
            relatorio.Data_inicial = dateTimePickerInicial.Value.ToShortDateString();

            //AtualizarGrid();
            DataSet ds = new DataSet();
            ds = relatorio.BuscarporData();
            dgv1.DataSource = ds.Tables[0];
            
        }
        

       
        
    }
}
