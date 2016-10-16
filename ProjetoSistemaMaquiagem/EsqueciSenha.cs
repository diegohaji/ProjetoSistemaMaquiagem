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
        //Construtor
        public EsqueciSenha()
        {
            InitializeComponent();
        }


        //Funcao que verifica se há algum campo em branco
        private bool verificaText(Control controles)
        {
            foreach (Control T in controles.Controls)
            {
                if (T is TextBox)
                {
                    if (string.IsNullOrEmpty(T.Text) || string.IsNullOrWhiteSpace(T.Text))
                    {
                        MessageBox.Show("Há campos vazios\nFavor verificar!", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;

                    }
                }
                if (T is ComboBox)
                {
                    if (string.IsNullOrEmpty(T.Text) || string.IsNullOrWhiteSpace(T.Text))
                    {
                        MessageBox.Show("Há campos vazios\nFavor verificar!", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;

                    }
                }
                if (T is MaskedTextBox)
                {
                    if (string.IsNullOrEmpty(T.Text) || string.IsNullOrWhiteSpace(T.Text))
                    {
                        MessageBox.Show("Há campos vazios\nFavor verificar!", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;

                    }
                }
            }
            return true;
        }


        //funcao que cria a nova senha do usuario
        private void button1_Click(object sender, EventArgs e)
        {
            ClnUsuario usuario = new ClnUsuario();
            if (verificaText(groupBox1)) { 
            if (usuario.BuscarUsuario(textBoxUsuario.Text, textBoxSenhaAtual.Text))
            {
                usuario.NovaSenha(textBoxNovaSenha.Text);
                MessageBox.Show("Senha alterada com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário inexistente!\nCadastre um novo usuário\npara acessar o sistema.", "Usuario Inexistente.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            ClnUsuario usuario = new ClnUsuario();
            if (verificaText(groupBox2)) {
                textBoxLembrarSenha.Text = (usuario.BuscarDica(textBoxLembrarUsuario.Text));
            }
        }

    }
}
