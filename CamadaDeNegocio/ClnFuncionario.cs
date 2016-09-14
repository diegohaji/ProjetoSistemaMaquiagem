using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AcessoADados;
using System.Data;

namespace CamadaDeNegocio
{
    class ClnFuncionario
    {
         
        //1 - Campos privados da classe
        private int cd_funcionario;
        private string nm_funcionario;
        private string cpf_funcionario;
        private string email_funcionario;
        private string login_funcionario;
        private string senha_funcionario;

        //2 - propriedades, acesso aos campos privados
        public int Cd_Funcionario
        {
            get { return cd_funcionario; }
            set { cd_funcionario = value; }
        }
        public string Nm_Funcionario
        {
            get { return nm_funcionario; }
            set { nm_funcionario = value; }
        }
        public string CPF_Funcionario
        {
            get { return cpf_funcionario; }
            set { cpf_funcionario = value; }
        }
        public string Email_Funcionario
        {
            get { return email_funcionario; }
            set { email_funcionario = value; }
        }

        public string Login_Funcionario
        {
            get { return login_funcionario; }
            set { login_funcionario = value; }
        }

        public string Senha_funcionario
        {
            get { return senha_funcionario; }
            set { senha_funcionario = value; }
        }


        //3 - métodos da classe de Negócios (clnFuncionario.cs)


        //3.1 Buscar dados do funcionario cujo codigo foi especificado
        public void BuscarporCodigo()
        {
            string csql;
            csql = "Select * From tb_funcionario where cd_funcionario=" + cd_funcionario;
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                cd_funcionario = Convert.ToInt16(dados.GetValue(0));
                nm_funcionario = Convert.ToString(dados.GetValue(1));
                cpf_funcionario = Convert.ToString(dados.GetValue(2));
                email_funcionario = Convert.ToString(dados.GetValue(3));
            }
        }

        //3.2 Buscar o próximo Id Numerico para 
        //inclusao de um novo funcionario.
        public int BuscarId()
        {
            string csql;
            csql = "Select * From tb_funcionario order by cd_funcionario desc limit 1";
            ClasseDados cd = new ClasseDados();
            return cd.RetornarIdNumerico(csql);
        }

        //3.3 Método para incluir um novo funcionario no 
        //Banco de dados
        public void Gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Insert into tb_funcionario");
            csql.Append("(");
            csql.Append("cd_funcionario,");
            csql.Append("nm_funcionario,");
            csql.Append("cpf_funcionario,");
            csql.Append("email_funcionario,");
            csql.Append("login_funcionario,");
            csql.Append("senha_funcionario) Values(");
            csql.Append(cd_funcionario);
            csql.Append(",'" + nm_funcionario + "',");
            csql.Append("'" + cpf_funcionario + "',");
            csql.Append("'" + email_funcionario + ",");
            csql.Append("'" + login_funcionario + ",");
            csql.Append("'" + senha_funcionario + "')");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.4 Método para atualizar (alterar um registro)
        public void Atualizar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Update tb_funcionario ");
            csql.Append("set cd_funcionario=");
            csql.Append(cd_funcionario);
            csql.Append(", nm_funcionario='");
            csql.Append(nm_funcionario);
            csql.Append("', cpf_funcionario='");
            csql.Append(cpf_funcionario);
            csql.Append("', email_funcionario='");
            csql.Append(email_funcionario);
            csql.Append("', login_funcionario='");
            csql.Append(login_funcionario);
            csql.Append("', senha_funcionario='");
            csql.Append(senha_funcionario);
            csql.Append("' where cd_funcionario=");
            csql.Append(cd_funcionario);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.5 Método para excluir um funcionario do 
        //Banco de dados
        public void Excluir()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tb_funcionario ");
            csql.Append(" where cd_funcionario=");
            csql.Append(cd_funcionario);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.6 Método para buscar os dados do funcionario de acordo com o nome
        public DataSet BuscarporNome()
        {
            string csql;
            csql = "Select * From tb_funcionario where nm_funcionario like('%" + nm_funcionario + "%')";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

    }
}

