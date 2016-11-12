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
            PagamentoServicos ls = new PagamentoServicos();
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
        //inutil
        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
        }
        //inutil
        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonCadUsuario_Click(object sender, EventArgs e)
        {
            CadastroUsuario cu = new CadastroUsuario();
            cu.Show();
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;
            ClnLogin login = new ClnLogin();
            if (login.validarLogin(usuario, senha)){
                MessageBox.Show("Logado com sucesso!", "Login válido.", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                groupBoxFuncionalidades.Visible = true;
            }

            else{
                MessageBox.Show("Login inválido!\nDigite novamente.", "Login inválido.",MessageBoxButtons.OK
                    ,MessageBoxIcon.Warning);
                textBoxUsuario.Text = null;
                textBoxSenha.Text = null;

            }
                
        }

        private void buttonEsqueciSenha_Click(object sender, EventArgs e)
        {
            EsqueciSenha es = new EsqueciSenha();
            es.Show();
        }
        //cria a tela do cadastro de produtos
        private void button1_Click(object sender, EventArgs e)
        {
            CadastroProduto p = new CadastroProduto();
            p.Show();
        }

        private void buttonEstoque_Click_1(object sender, EventArgs e)
        {
            ControleEstoque es = new ControleEstoque();
            es.Show();

         
        }

        private void buttonAlterarEstoque_Click(object sender, EventArgs e)
        {
            ControleEstoque es = new ControleEstoque();
            es.Show();

        }

        private void buttonVerificarEst_Click(object sender, EventArgs e)
        {
            ControleEstoque es = new ControleEstoque();
            es.Show();

        }
    }
}
