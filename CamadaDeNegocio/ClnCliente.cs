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
        private string telefone_cliente;
        private string celular_cliente;
        private string cep_cliente;
        private string numero_cliente;
        private string rua_cliente;
        private string bairro_cliente;
        private string cidade_cliente;
        private string estado_cliente;
        private string complemento_cliente;


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

        public string Telefone_cliente
        {
            get { return telefone_cliente; }
            set { telefone_cliente = value; }
        }

        public string Celular_cliente
        {
            get { return celular_cliente; }
            set { celular_cliente = value; }
        }
        public string CEP_cliente
        {
            get { return cep_cliente; }
            set { cep_cliente = value; }
        }
        public string Rua_cliente
        {
            get { return rua_cliente; }
            set { rua_cliente = value; }
        }
        public string Bairro_cliente
        {
            get { return bairro_cliente; }
            set { bairro_cliente = value; }
        }
        public string Cidade_cliente
        {
            get { return cidade_cliente; }
            set { cidade_cliente = value; }
        }
        public string Estado_cliente
        {
            get { return estado_cliente; }
            set { estado_cliente = value; }
        }
        public string Numero_cliente
        {
            get { return numero_cliente; }
            set { numero_cliente = value; }
        }

        public string Complemento_cliente
        {
            get { return complemento_cliente; }
            set { complemento_cliente = value; }
        }



        //3 - métodos da classe de Negócios (clnCliente.cs)


        //3.1 Buscar dados do cliente cujo codigo foi especificado
        public void BuscarporCodigo()
        {
            string csql;
            csql = "Select * From tb_cliente where cd_cliente=" + cd_cliente;
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
        public int BuscarId(string nome)
        {
            string csql;
            csql = "Select cd_cliente From tb_cliente where nm_cliente like ('%" + nome + "%')";
            ClasseDados cd = new ClasseDados();
            return cd.RetornarIdNumerico(csql);
        }

        //3.3 Método para incluir um novo cliente no 
        //Banco de dados
        public void Gravar()
        {

            StringBuilder csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(0);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

            csql = new StringBuilder();
            csql.Append("Insert into tb_cliente");
            csql.Append("(");
            csql.Append("cd_cliente,");
            csql.Append("nm_cliente,");
            csql.Append("rg_cliente,");
            csql.Append("cpf_cliente,");
            csql.Append("email_cliente");
            csql.Append(") Values(");
            csql.Append(cd_cliente);
            csql.Append(",'" + nm_cliente + "',");
            csql.Append("'" + rg_cliente + "',");
            csql.Append("'" + cpf_cliente + "',");
            csql.Append("'" + email_cliente + "'");
            csql.Append(")");
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

            csql = new StringBuilder();
            csql.Append("select cd_cliente from tb_cliente where nm_cliente = '" + nm_cliente + "'");
            cd = new ClasseDados();
            int marreta = cd.RetornarIdNumerico(csql.ToString()) - 1;

            csql = new StringBuilder();
            csql.Append("Insert into tb_endereco_cliente");
            csql.Append("(");
            csql.Append("cep,");
            csql.Append("cidade,");
            csql.Append("bairro,");
            csql.Append("logradouro,");
            csql.Append("num,");
            csql.Append("complemento,");
            csql.Append("cd_cliente,");
            csql.Append("estado) Values(");
            csql.Append(cep_cliente);
            csql.Append(",'" + cidade_cliente + "',");
            csql.Append("'" + bairro_cliente + "',");
            csql.Append("'" + rua_cliente + "',");
            csql.Append("'" + numero_cliente + "',");
            csql.Append("'" + complemento_cliente + "',");
            csql.Append("'" + marreta + "',");
            csql.Append("'" + estado_cliente + "')");
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            //Consertar a SQL dos Telefones
            /*
            csql = new StringBuilder();
            csql.Append("Insert into tb_fones_cliente");
            csql.Append("(");
            csql.Append("fone,");
            csql.Append("cd_cliente) Values('");
            csql.Append(telefone_cliente);
            csql.Append("'," + cd_cliente + "')");
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

            csql = new StringBuilder();
            csql.Append("Insert into tb_fones_cliente");
            csql.Append("(");
            csql.Append("fone,");
            csql.Append("cd_cliente) Values('");
            csql.Append(telefone_cliente);
            csql.Append("'," + cd_cliente + "')");
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
           */
            csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(1);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

        }
        //3.4 Método para atualizar (alterar um registro)
        public void Atualizar()
        {

            StringBuilder csql = new StringBuilder();
            csql.Append("Update tb_cliente ");
            csql.Append("set nm_cliente='");
            csql.Append(nm_cliente);
            csql.Append("', rg_cliente='");
            csql.Append(rg_cliente);
            csql.Append("', cpf_cliente='");
            csql.Append(cpf_cliente);
            csql.Append("', email_cliente='");
            csql.Append(email_cliente);
            csql.Append("' where cd_cliente=");
            csql.Append(cd_cliente);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

            csql = new StringBuilder();
            csql.Append("Update tb_endereco_cliente ");
            csql.Append("set cep = ");
            csql.Append(cep_cliente);
            csql.Append(", cidade ='");
            csql.Append(cidade_cliente);
            csql.Append("',bairro = '");
            csql.Append(bairro_cliente);
            csql.Append("',logradouro='");
            csql.Append(rua_cliente);
            csql.Append("num=");
            csql.Append(numero_cliente);
            csql.Append("',complemento='");
            csql.Append(complemento_cliente);
            csql.Append("cd_cliente=");
            csql.Append(cd_cliente - 1);
            csql.Append("',estado='");
            csql.Append(estado_cliente);
            csql.Append("' where cd_cliente = ");
            csql.Append(cd_cliente);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.5 Método para excluir um cliente do 
        //Banco de dados
        public void Excluir(string nome)
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tb_cliente ");
            csql.Append(" where nm_cliente='");
            csql.Append(nome + "'");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNome()
        {
            string csql;
            csql = "Select tc.cd_cliente as Codigo, tc.nm_cliente as Nome, tc.rg_cliente as RG, tc.cpf_cliente as CPF, tc.email_cliente as Email, tec.cep as CEP, tec.num as Numero, tec.logradouro as Logradouro, tec.bairro as Bairro, tec.cidade as Cidade, tec.estado as Estado, tec.complemento as Complemento From tb_cliente as tc inner join tb_endereco_cliente as tec on tc.cd_cliente = tec.cd_cliente";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }
    }

}

