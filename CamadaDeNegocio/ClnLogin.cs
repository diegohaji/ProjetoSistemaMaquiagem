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
    class ClnLogin
    {        
        public bool validarLogin(string login, string senha)
        {
            string sql = "Select login, senha from tb_funcionario where login_funcionario="+login;
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;

            }
            else
            {
                Console.WriteLine("Usuário ou senha inválidos, tente novamente");
            }
        }



    }
}
