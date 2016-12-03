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
    public partial class JanelaPagamentoTotal : Form
    {
        public JanelaPagamentoTotal()
        {
            InitializeComponent();
        }

        private void JanelaPagamentoTotal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTablePagamentoTotalFuncionario' table. You can move, or remove it, as needed.
            

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                this.DataTablePagamentoTotalFuncionarioTableAdapter.Fill(this.DataSet1.DataTablePagamentoTotalFuncionario);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show("O relatório será aberto em outra janela.\nClique em OK para continuar!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
