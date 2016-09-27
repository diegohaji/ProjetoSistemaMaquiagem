using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using AcessoADados;

namespace CamadaDeNegocio
{
    public class ClnLogin
    {
        private string login_funcionario;
        private string senha_funcionario;

        public string Login_funcionario
        {
            get { return this.login_funcionario; }
            set { this.login_funcionario = value; }
        }

        public string Senha_funcionario
        {
            get { return this.senha_funcionario; }
            set { this.senha_funcionario = value; }
        }

        public bool validarLogin(string login, string senha)
        {
            string sql = "Select nome_usuario, senha_usuario from tb_usuario where nome_usuario='" + login+"'";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                this.login_funcionario = Convert.ToString(dados.GetValue(0));
                this.senha_funcionario = Convert.ToString(dados.GetValue(1));

                if (login.Equals(this.login_funcionario) && senha.Equals(this.senha_funcionario))
                {
                    Console.WriteLine("Login Efetuado Com Sucesso");
                    return true;
                }
                else
                {
                    Console.WriteLine("Dados inválidos, tente novamente");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Dados inválidos, tente novamente");
                return false;
            }
        }
    }
}
