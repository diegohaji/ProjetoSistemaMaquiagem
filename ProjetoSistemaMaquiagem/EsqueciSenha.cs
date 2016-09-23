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
    public partial class EsqueciSenha : Form
    {
        public EsqueciSenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNovaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxConfirmarNovaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClnUsuario usuario = new ClnUsuario();
            if (usuario.BuscarUsuario(textBoxUsuario.Text) && textBoxNovaSenha.Text.Equals(textBoxConfirmarNovaSenha.Text))
            {
                usuario.NovaSenha(textBoxNovaSenha.Text);
            }
            else
            {
                MessageBox.Show("Usuário inexistente!\nCadastre um novo usuário\npara acessar o sistema.", "Usuario Inexistente.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
