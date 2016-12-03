using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistemaMaquiagem
{
    public partial class JanelaRelatorioTotalFuncionarios : Form
    {
        public JanelaRelatorioTotalFuncionarios()
        {
            InitializeComponent();
        }

        private void JanelaRelatorioTotalFuncionarios_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                this.DataTableTodosFuncionariosTableAdapter.Fill(this.DataSet1.DataTableTodosFuncionarios);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("O relatório será aberto em outra janela.\nClique em OK para continuar!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
