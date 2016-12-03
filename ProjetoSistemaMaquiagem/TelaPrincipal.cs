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
            AtualizarGrid();
        }

        //atualiza o grid
        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
            ClnAgendaDeServico agenda = new ClnAgendaDeServico();
            ds = agenda.BuscarporNomePrincipal();
            dgv1.DataSource = ds.Tables[0];

        }

        public void ativarControles(bool ativar)
        {
            cadastroToolStripMenuItem.Enabled = ativar;
            serviçosToolStripMenuItem1.Enabled = ativar;
            controleFinanceiroToolStripMenuItem.Enabled = ativar;
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cf = new CadastroFuncionario();
            cf.Show();
            
        }
        
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cc = new CadastroCliente();
            cc.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroServiços cs = new CadastroServiços();
            cs.Show();

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto p = new CadastroProduto();
            p.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleEstoque ce = new ControleEstoque();
            ce.Show();
        }

        private void lançamentoDeHorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendamentoDeHorarios ah = new AgendamentoDeHorarios();
            ah.Show();
        }

        private void agendamentoDeServiçosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendamentoServico agendserv = new AgendamentoServico();
            agendserv.Show();
            AtualizarGrid();
        }

        private void pagamentoDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagamentoServicos ls = new PagamentoServicos();
            ls.Show();
            AtualizarGrid();
        }

        private void gerarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioFinanceiro rf = new RelatorioFinanceiro();
            rf.Show();
        }

        private void controleFinanceiroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ControlePagamento cp = new ControlePagamento();
            cp.Show();
        }
        
        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            dgv1.Enabled = false;
            groupBoxLogin.Enabled = true;
            groupBoxLogin.Visible = true;
            
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;
            ClnLogin login = new ClnLogin();
            if (login.validarLogin(usuario, senha))
            {
                MessageBox.Show("Logado com sucesso!", "Login válido.", MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                groupBoxLogin.Enabled = false;
                groupBoxLogin.Visible = false;
                ativarControles(true);
                dgv1.Visible = true;
                dgv1.Enabled = true;
                textBoxUsuario.Text = null;
                textBoxSenha.Text = null;
            }

            else
            {
                MessageBox.Show("Login inválido!\nDigite novamente.", "Login inválido.", MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                textBoxUsuario.Text = null;
                textBoxSenha.Text = null;

            }
        }

       

        private void buttonEsqueciSenha_Click(object sender, EventArgs e)
        {
            EsqueciSenha es = new EsqueciSenha();
            es.Show();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            groupBoxLogin.Enabled = false;
            groupBoxLogin.Visible = false;
            dgv1.Visible = true;
            dgv1.Enabled = true;
            AtualizarGrid();
        }

        private void timerAtualizarGrid_Tick(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cu = new CadastroUsuario();
            cu.Show();
        }
    }
}
