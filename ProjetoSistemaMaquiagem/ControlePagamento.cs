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
    public partial class ControlePagamento : Form
    {
        public ControlePagamento()
        {
            InitializeComponent();
        }

        //load
        private void ControleDePagamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTablePagamentoFuncionarioComData' table. You can move, or remove it, as needed.

            PreencherComboFuncionario();


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


        //preenche o combobox com os valores dos funcionarios
        public void PreencherComboFuncionario()
        {
            ClnFuncionario tipo = new ClnFuncionario();
            DataSet ds = tipo.BuscarporNome();
            comboBoxFuncionario.DataSource = ds.Tables[0];
            comboBoxFuncionario.DisplayMember = "Nome";
            comboBoxFuncionario.ValueMember = "Codigo";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.DataTablePagamentoFuncionarioComDataTableAdapter.Fill(this.DataSet1.DataTablePagamentoFuncionarioComData, comboBoxFuncionario.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar\nFavor clicar novamente!", "Falha", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            JanelaPagamentoTotal jpt = new JanelaPagamentoTotal();
            jpt.Show();
        }
    }
}
