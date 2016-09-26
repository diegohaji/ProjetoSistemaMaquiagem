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
using MySql.Data.MySqlClient;

namespace ProjetoSistemaMaquiagem
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(Object sender, EventArgs e)
        {
           // AtualizarGrid();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRua_TextChanged(object sender, EventArgs e)
        {

        }

        public void LimparTxt(Control controles)
        {
            foreach (Control ctl in controles.Controls)
            {
                if (ctl is TextBox) ctl.Text = string.Empty;
                if (ctl is MaskedTextBox) ctl.Text = string.Empty;
            }
        }

        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
            ClnCliente cliente = new ClnCliente();
            cliente.Nm_Cliente = textBoxPesquisar.Text;
            ds = cliente.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];
        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            StringBuilder mensagem = new StringBuilder();
            ClnCliente Cliente = new ClnCliente();
            Cliente.Nm_Cliente = textBoxNome.Text;
            Cliente.CPF_cliente = maskedTextBoxCPF.Text;
            Cliente.Email_cliente = textBoxEmail.Text;
            Cliente.RG_Cliente = maskedTextBoxRG.Text;
            Cliente.Celular_cliente = maskedTextBoxCelular.Text;
            Cliente.Telefone_cliente = maskedTextBoxTelefone.Text;
            Cliente.CEP_cliente = maskedTextBoxCEP.Text;
            Cliente.Rua_cliente = textBoxRua.Text;
            Cliente.Numero_cliente = textBoxNumero.Text;
            Cliente.Bairro_cliente = textBoxBairro.Text;
            Cliente.Cidade_cliente = textBoxCidade.Text;
            Cliente.Estado_cliente = textBoxEstado.Text;
            Cliente.Complemento_cliente = textBoxComplemento.Text;
            if (string.IsNullOrEmpty(textBoxNome.Text))
            {
                mensagem.Append("Campo Nome em branco.\n");
            }else 
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                mensagem.Append("Campo Email em branco.\n");
            } 
            if (string.IsNullOrEmpty(maskedTextBoxRG.Text))
            {
                mensagem.Append("Campo RG em branco.\n");
            }


            if (string.IsNullOrWhiteSpace(mensagem.ToString()))
            {
                Cliente.Gravar();
                AtualizarGrid();
                LimparTxt(Cadastro);
            }
            else
            {
                MessageBox.Show(mensagem.ToString(), "Campo inválido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }


        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            LimparTxt(groupBoxEndereco);
            LimparTxt(Cadastro);

        }
        
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnCliente cliente = new ClnCliente();
            if (dgv1.RowCount > 0)
            {
                textBoxNome.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
                textBoxEmail.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                maskedTextBoxRG.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBoxCPF.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
                maskedTextBoxCelular.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
                maskedTextBoxTelefone.Text = dgv1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {

            string mensagem = "Deseja excluir o cadastro," + textBoxNome.Text  +" ?";
            int resposta = Convert.ToInt16(MessageBox.Show(mensagem,"Excluir cadastro",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            if(resposta == 1)
            {
                ClnCliente cliente = new ClnCliente();
                cliente.Excluir(textBoxNome.Text);
            }
            LimparTxt(Cadastro);
            AtualizarGrid();
        }

       
    }
}
