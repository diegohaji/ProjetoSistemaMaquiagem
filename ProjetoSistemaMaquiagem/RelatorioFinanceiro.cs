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
            // TODO: This line of code loads data into the 'sistemamaquiagemDataSet.tb_prestacao_servico' table. You can move, or remove it, as needed.
            this.tb_prestacao_servicoTableAdapter.Fill(this.sistemamaquiagemDataSet.tb_prestacao_servico);

            PreencherComboCliente();
            PreencherComboFuncionario();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void buttonPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
        {
            try {
                
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void PesquisarPeriodo_Click(object sender, EventArgs e)
        {
            
            
        }
        

       
        
    }
}
