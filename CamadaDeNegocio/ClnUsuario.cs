using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoADados;
using System.Data;
namespace CamadaDeNegocio
{
    public class ClnUsuario
    {
        private string usuario;
        private string senha;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        //grava o usuario no banco de dados
        public void Gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Insert into tb_usuario");
            csql.Append("(");
            csql.Append("nome_usuario,");
            csql.Append("senha_usuario) Values(");
            csql.Append(usuario);
            csql.Append(",'" + senha + "')");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //busca o usuario para atualizar no banco de dados
        public bool BuscarUsuario(string usuario)
        {
            string csql;
            csql = "Select * From tb_usuario where usuario=" + usuario;
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                this.usuario = Convert.ToString(dados.GetValue(0));

            }
            if (usuario.Equals(this.usuario))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        //Atualiza a senha no banco de dados
        public void NovaSenha(string senha)
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Update tb_usuario ");
            csql.Append("set senha=");
            csql.Append(senha);
            csql.Append("' where senha=");
            csql.Append(this.senha);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }
    }
}
