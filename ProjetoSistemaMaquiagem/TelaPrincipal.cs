using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AcessoADados;
using CamadaDeNegocio;


namespace ProjetoSistemaMaquiagem
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void buttonFuncionario_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cf = new CadastroFuncionario();
            cf.Show();

        }

        private void buttonServicos_Click(object sender, EventArgs e)
        {
            CadastroServiços cs = new CadastroServiços();
            cs.Show();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            CadastroCliente cc = new CadastroCliente();
            cc.Show();

        }

        private void buttonEstoque_Click(object sender, EventArgs e)
        {
            ControleEstoque ce = new ControleEstoque();
            ce.Show(); 
        }

        private void buttonAgendServico_Click(object sender, EventArgs e)
        {
            AgendamentoServico agendserv = new AgendamentoServico();
            agendserv.Show();
                 
        }

        private void buttonServPrestado_Click(object sender, EventArgs e)
        {
            LancamentoServicos ls = new LancamentoServicos();
            ls.Show(); 
        }

        private void buttonLancHorario_Click(object sender, EventArgs e)
        {
            AgendamentoDeHorarios ah = new AgendamentoDeHorarios();
            ah.Show(); 
        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioFinanceiro rf = new RelatorioFinanceiro();
            rf.Show(); 
        }

        private void buttonContFinanceiro_Click(object sender, EventArgs e)
        {
            ControlePagamento cp = new ControlePagamento();
            cp.Show();

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonCadUsuario_Click(object sender, EventArgs e)
        {
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;
            ClnLogin login = new ClnLogin();
            login.validarLogin(usuario,senha);
        }

        private void buttonEsqueciSenha_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroProduto p = new CadastroProduto();
            p.Show();
        }
    }
}
