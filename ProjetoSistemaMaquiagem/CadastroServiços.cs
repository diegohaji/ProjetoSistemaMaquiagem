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
    public partial class CadastroServiços : Form
    {
        public CadastroServiços()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnServiços serv = new ClnServiços();
            serv.Nm_Servico = textBoxNome.Text;
            serv.VL_Servico = Convert.ToDouble(textBoxPreco.Text);
            serv.Gravar();
        }

        private void CadastroServiços_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            textBoxDuracao.Text = null;
            textBoxNome.Text = null;
            textBoxPreco.Text = null;
            comboBoxTipo.Text = null;
        }
    }
}
