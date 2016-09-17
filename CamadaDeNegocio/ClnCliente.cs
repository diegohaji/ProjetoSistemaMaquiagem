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
        private int cd_cliente;
        private string nm_cliente;
        private string rg_cliente;
        private string cpf_cliente;        
        private string email_cliente;

        //2 - propriedades, acesso aos campos privados
        public int Cd_cliente
        {
            get { return cd_cliente; }
            set { cd_cliente = value; }
        }
        public string Nm_Cliente
        {
            get { return nm_cliente; }
            set { nm_cliente = value; }
        }        
        public string CPF_cliente
        {
            get { return cpf_cliente; }
            set { cpf_cliente = value; }
        }        
        public string Email_cliente
        {
            get { return email_cliente; }
            set { email_cliente = value; }
        }
        public string RG_Cliente
        {
            get { return rg_cliente; }
            set { rg_cliente = value; }
        }

        //3 - métodos da classe de Negócios (clnCliente.cs)


        //3.1 Buscar dados do cliente cujo codigo foi especificado
        public void BuscarporCodigo()
        {
            string csql;
            csql = "Select * From tb_cliente where cd_produto=" + cd_cliente;
            DataSet ds;
           ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                cd_cliente = Convert.ToInt16(dados.GetValue(0));
                nm_cliente = Convert.ToString(dados.GetValue(1));                
                cpf_cliente = Convert.ToString(dados.GetValue(2));                
                email_cliente = Convert.ToString(dados.GetValue(3));
            }
        }

        //3.2 Buscar o próximo Id Numerico para 
        //inclusao de um novo cliente.
        public int BuscarId()
        {
            string csql;
            csql = "Select * From tb_cliente order by cd_produto desc limit 1";
           ClasseDados cd = new ClasseDados();
            return cd.RetornarIdNumerico(csql);
        }

        //3.3 Método para incluir um novo cliente no 
        //Banco de dados
        public void Gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Insert into tb_cliente");
            csql.Append("(");
            csql.Append("cd_cliente,");
            csql.Append("nm_cliente,");           
            csql.Append("cpf_cliente,");
            csql.Append("rg_cliente,");
            csql.Append("email_cliente) Values(");
            csql.Append(cd_cliente);
            csql.Append(",'" + nm_cliente + "',");            
            csql.Append("'" + cpf_cliente + "',");
            csql.Append("'" + rg_cliente + "',");
            csql.Append("'" + email_cliente + "')");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.4 Método para atualizar (alterar um registro)
        public void Atualizar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Update tb_cliente ");
            csql.Append("set cd_produto=");
            csql.Append(cd_cliente);
            csql.Append(", nm_cliente='");
            csql.Append(nm_cliente);
            csql.Append("', cpf_cliente='");
            csql.Append(cpf_cliente);
            csql.Append("', email_cliente='");
            csql.Append(email_cliente);            
            csql.Append("' where cd_cliente=");
            csql.Append(cd_cliente);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.5 Método para excluir um cliente do 
        //Banco de dados
        public void Excluir()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tb_cliente ");
            csql.Append(" where cd_cliente=");
            csql.Append(cd_cliente);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNome()
        {
            string csql;
            csql = "Select * From tb_cliente where nm_servico like('%" + nm_cliente + "%')";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

    }

}

