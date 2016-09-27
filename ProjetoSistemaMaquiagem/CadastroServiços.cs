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

        private void AtualizarGrid()
        {
            DataSet ds = new DataSet();
            ClnServiços servicos = new ClnServiços();
            servicos.Nm_Servico = textBoxPesquisar.Text;
            ds = servicos.BuscarporNome();
            dgv1.DataSource = ds.Tables[0];

        }

        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            ClnServiços serv = new ClnServiços();
            serv.Nm_Servico = textBoxNome.Text;
            serv.VL_Servico = Convert.ToDouble(textBoxPreco.Text);
            serv.Gravar();
            AtualizarGrid();
            
        }

        private void CadastroServiços_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv1.CurrentRow.Selected = true;
            ClnServiços servicos = new ClnServiços();
            if (dgv1.RowCount > 0)
            {
               
                textBoxNome.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
                textBoxPreco.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
                comboBoxTipo.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
                textBoxDuracao.Text = dgv1.CurrentRow.Cells[3].Value.ToString();


            }
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
    }
}
