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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            comboBoxServico.Text = null;
            textBoxCodigo.Text = null;
            textBoxHorario.Text = null;
            textBoxNome.Text = null;
        }
    }
}
