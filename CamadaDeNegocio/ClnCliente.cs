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
    public class ClnCliente
    {
        //1 - Campos privados da classe
        private int idCli;
        private string nomeCli;
        private string enderecoCli;
        private string foneCli;
        private string faxCli;
        private string obsCli;

        //2 - propriedades, acesso aos campos privados
        public int IdCli
        {
            get { return idCli; }
            set { idCli = value; }
        }
        public string NomeCli
        {
            get { return nomeCli; }
            set { nomeCli = value; }
        }
        public string EnderecoCli
        {
            get { return enderecoCli; }
            set { enderecoCli = value; }
        }
        public string FoneCli
        {
            get { return foneCli; }
            set { foneCli = value; }
        }
        public string FaxCli
        {
            get { return faxCli; }
            set { faxCli = value; }
        }
        public string ObsCli
        {
            get { return obsCli; }
            set { obsCli = value; }
        }

        //3 - métodos da classe de Negócios (clnCliente.cs)


        //3.1 Buscar dados do cliente cujo codigo foi especificado
        public void BuscarporCodigo()
        {
            string csql;
            csql = "Select * From tbCliente where idCli=" + IdCli;
            DataSet ds;
           ClasseDados seguros = new ClasseDados();
            ds = seguros.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                idCli = Convert.ToInt16(dados.GetValue(0));
                nomeCli = Convert.ToString(dados.GetValue(1));
                enderecoCli = Convert.ToString(dados.GetValue(2));
                foneCli = Convert.ToString(dados.GetValue(3));
                faxCli = Convert.ToString(dados.GetValue(4));
                obsCli = Convert.ToString(dados.GetValue(5));
            }
        }

        //3.2 Buscar o próximo Id Numerico para 
        //inclusao de um novo cliente.
        public int BuscarId()
        {
            string csql;
            csql = "Select * From tbcliente order by idCli desc limit 1";
           ClasseDados seguros = new ClasseDados();
            return seguros.RetornarIdNumerico(csql);
        }

        //3.3 Método para incluir um novo cliente no 
        //Banco de dados
        public void Gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Insert into tbCliente");
            csql.Append("(");
            csql.Append("idCli,");
            csql.Append("nomeCli,");
            csql.Append("enderecoCli,");
            csql.Append("foneCli,");
            csql.Append("faxCli,");
            csql.Append("obsCli) Values(");
            csql.Append(idCli);
            csql.Append(",'" + nomeCli + "',");
            csql.Append("'" + enderecoCli + "',");
            csql.Append("'" + foneCli + "',");
            csql.Append("'" + faxCli + "',");
            csql.Append("'" + obsCli + "')");
            ClasseDados seguros = new ClasseDados();
            seguros.ExecutarComando(csql.ToString());
        }

        //3.4 Método para atualizar (alterar um registro)
        public void Atualizar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Update tbCliente ");
            csql.Append("set idCli=");
            csql.Append(IdCli);
            csql.Append(", nomeCli='");
            csql.Append(nomeCli);
            csql.Append("', enderecoCli='");
            csql.Append(enderecoCli);
            csql.Append("', foneCli='");
            csql.Append(foneCli);
            csql.Append("', faxCli='");
            csql.Append(faxCli);
            csql.Append("', obsCli='");
            csql.Append(obsCli);
            csql.Append("' where idCli=");
            csql.Append(IdCli);
            ClasseDados seguros = new ClasseDados();
            seguros.ExecutarComando(csql.ToString());
        }

        //3.5 Método para excluir um cliente do 
        //Banco de dados
        public void Excluir()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tbCliente ");
            csql.Append(" where idCli=");
            csql.Append(IdCli);
            ClasseDados seguros = new ClasseDados();
            seguros.ExecutarComando(csql.ToString());
        }

        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNome()
        {
            string csql;
            csql = "Select * From tbCliente where nomeCli like('%" + nomeCli + "%')";
            DataSet ds;
            ClasseDados seguros = new ClasseDados();
            ds = seguros.RetornarDataSet(csql);
            return ds;
        }

    }

}

