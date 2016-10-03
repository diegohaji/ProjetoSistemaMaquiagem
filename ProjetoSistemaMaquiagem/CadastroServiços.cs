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
    public partial class CadastroServiços : Form
    {
        //Construtor
        public CadastroServiços()
        {
            InitializeComponent();
        }

        //inutil
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //inutil
        private void label4_Click(object sender, EventArgs e)
        {

        }

        //inutil
        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Atualiza o grid
        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
            ClnServiços servicos = new ClnServiços();
            servicos.Nm_Servico = textBoxPesquisar.Text;
            ds = servicos.BuscarporNome();
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

        //função que carrega o grid quando o formulario é chamado
        private void CadastroServiços_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
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

        //funçao que cadastra o serviço
        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnServiços serv = new ClnServiços();
            serv.Nm_Servico = textBoxNome.Text;
            serv.VL_Servico = Convert.ToDouble(textBoxPreco.Text);
            serv.Duracao = maskedTextBoxDuracao.Text;
            if (verificaText(groupBoxServico))
            {
                serv.Gravar();
                AtualizarGrid();
                LimparTxt(groupBoxServico);
            }
        }


        //funcao que é chamada quando é cancelado o cadastro
        private void Cancelar_Click(object sender, EventArgs e)
        {
            LimparTxt(groupBoxServico);
        }

        //funcao do grid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnServiços servicos = new ClnServiços();
            if (dgv1.RowCount > 0)
            {

                textBoxNome.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                textBoxPreco.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBoxDuracao.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            }
        }
        //função que é chamada para excluir serviço
        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja excluir o cadastro," + textBoxNome.Text + " ?";
            int resposta = Convert.ToInt16(MessageBox.Show(mensagem, "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == 6)
            {
                ClnProdutos produto = new ClnProdutos();
                produto.Excluir(textBoxNome.Text);
            }
            LimparTxt(groupBoxServico);
            AtualizarGrid();

        }
        //funcao de pesquisa
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ClnServiços servico = new ClnServiços();
            servico.Nm_Servico = textBoxPesquisar.Text;
            ds = servico.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
        }
    }
}
