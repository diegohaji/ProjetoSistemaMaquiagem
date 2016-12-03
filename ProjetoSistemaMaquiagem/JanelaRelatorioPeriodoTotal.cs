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
    public partial class JanelaRelatorioPeriodoTotal : Form
    {
        public JanelaRelatorioPeriodoTotal()
        {
            InitializeComponent();
        }

        private void JanelaRelatorioPeriodoTotal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTablePeriodoTotal' table. You can move, or remove it, as needed.
            

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try { 
            this.DataTablePeriodoTotalTableAdapter.Fill(this.DataSet1.DataTablePeriodoTotal);
            this.reportViewer1.RefreshReport();
        }
            catch (Exception ex)
            {
                MessageBox.Show("O relatório será aberto em outra janela.\nClique em OK para continuar!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
}
