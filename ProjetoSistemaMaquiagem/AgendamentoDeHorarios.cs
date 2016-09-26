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
    public partial class AgendamentoDeHorarios : Form
    {
        public AgendamentoDeHorarios()
        {
            InitializeComponent();
        }

        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            agenda.Servico = comboBoxServico.Text;
            agenda.NomeServico = textBoxNome.Text;
            agenda.Horario = Convert.ToDouble(textBoxHorario.Text);
            agenda.Gravar();
            AtualizarGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            LimparTxt(groupBox1);
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

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnAgendaDeHorario agenda = new ClnAgendaDeHorario();
            if (dgv1.RowCount > 0)
            {
                textBoxCodigo.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
                comboBoxServico.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                textBoxNome.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                textBoxHorario.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
