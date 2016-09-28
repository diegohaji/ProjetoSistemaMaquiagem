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
            ClasseDados cd = new ClasseDados();
            StringBuilder csql = new StringBuilder();            
            csql.Append("Insert into tb_usuario");
            csql.Append("(");
            csql.Append("cd_usuario,");
            csql.Append("nome_usuario,");
            csql.Append("senha_usuario) Values(");
            ClnFuncionario funcionario = new ClnFuncionario();
            csql.Append("''");
            csql.Append(",'" + usuario + "'");
            csql.Append(",'" + senha + "')");
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());            
        }

        //busca o usuario para atualizar no banco de dados
        public bool BuscarUsuario(string usuario)
        {
            string csql;
            csql = "Select nome_usuario From tb_usuario where nome_usuario='" + usuario + "'";
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
            
            string sql;
            sql = "Select * From tb_usuario where nome_usuario='" + usuario + "'";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                this.usuario = Convert.ToString(dados.GetValue(1));
                this.senha = Convert.ToString(dados.GetValue(2));
            }
            StringBuilder csql = new StringBuilder();
            csql.Append("Update tb_usuario ");
            csql.Append("set senha_usuario='");
            csql.Append(senha);
            csql.Append("' where senha_usuario='");
            csql.Append( this.senha + "'");
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }
    
    }
}
