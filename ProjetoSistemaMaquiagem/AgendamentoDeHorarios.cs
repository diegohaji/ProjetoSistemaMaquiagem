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
    public partial class AgendamentoDeHorarios : Form
    {
        //Construtor
        public AgendamentoDeHorarios()
        {
            InitializeComponent();
        }

        //inutil
        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        //inutil
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        
        //atualiza o grid
        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
           ClnServiços servico = new ClnServiços();
            servico.Nm_Servico = textBoxPesquisar.Text;
            ds = servico.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            agenda.Horario = (textBoxPesquisar.Text);
            ds = servico.BuscarporNome();
            dgv1.DataSource = ds.Tables[1];

        }
        
        //preenche o combobox com os valores dos serviços
        public void PreencherComboTipo()
        {
            ClnServiços tipo = new ClnServiços();
            DataSet ds = tipo.BuscarporNome();
            comboBoxServico.DataSource = ds.Tables[0];
            comboBoxServico.DisplayMember = "nm_servico";
            comboBoxServico.ValueMember = "cd_servico";
        }
        
        //Funcao load que atualiza o grid quando o formulario de agendar é chamado
        private void AgendamentoHorario(object sender, EventArgs e)
        {
            PreencherComboTipo();
           // AtualizarGrid();
        }
    
        //funçao que cadastra o agendamento
        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            agenda.Servico = comboBoxServico.Text;
            agenda.NomeServico = textBoxNome.Text;
            agenda.Horario = (maskedTextBoxHorario.Text);
            agenda.Gravar();
            AtualizarGrid();
        }
        
        //funcao que é chamada quando é cancelado o cadastro
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            LimparTxt(groupBox1);
        }
        
        //função do grid
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            if (dgv1.RowCount > 0)
            {
                
                comboBoxServico.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                textBoxNome.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBoxHorario.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            }
        }
        
        //função que é chamada para excluir algum horario
        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja excluir o cadastro," + textBoxNome.Text + " ?";
            int resposta = Convert.ToInt16(MessageBox.Show(mensagem, "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == 6)
            {
                ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
               // agenda.Excluir(textBoxNome.Text);
            }
            LimparTxt(groupBox1);
            AtualizarGrid();
        }
      
        //funcao de pesquisar
        private void button1_Click(object sender, EventArgs e)
        {/*
            DataSet ds = new DataSet();
            ClnCliente cliente = new ClnCliente();
            cliente.Nm_Cliente = textBoxPesquisar.Text;
            ds = cliente.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
        */
            }
    }
}
