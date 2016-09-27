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
    public partial class CadastroUsuario : Form
    {
        //construtor
        public CadastroUsuario()
        {
            InitializeComponent();
        }
        //Funcao que cadastra o usuario
        private void button1_Click(object sender, EventArgs e)
        {
            ClnUsuario usuario = new ClnUsuario();
            usuario.Usuario = textBoxUsuario.Text;
            usuario.Senha = textBoxSenha.Text;
            usuario.Gravar();
            this.Close();
        }
    }
}
