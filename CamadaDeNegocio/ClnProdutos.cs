using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoADados;
using System.Data;
namespace CamadaDeNegocio
{
   public class ClnProdutos
    {
        //1 - Campos privados da classe
        private int cd_produto;
        private string nm_produto;
        private double vl_produto;

        
        //2 - propriedades, acesso aos campos privados
        public int Cd_Produto
        {
            get { return cd_produto; }
            set { cd_produto = value; }
        }
        public string Nm_Produto
        {
            get { return nm_produto; }
            set { nm_produto = value; }
        }
        public double VL_Produto
        {
            get { return vl_produto; }
            set { vl_produto = value; }
        }



        //3 - métodos da classe de Negócios (clnservico.cs)


        //3.1 Buscar dados do cliente cujo codigo foi especificado
        public void BuscarporCodigo()
        {
            string csql;
            csql = "Select * From tb_cliente where cd_produto=" + cd_produto;
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                cd_produto = Convert.ToInt16(dados.GetValue(0));
                nm_produto = Convert.ToString(dados.GetValue(1));
                vl_produto = Convert.ToDouble(dados.GetValue(2));

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
            csql.Append("cd_produto,");
            csql.Append("nm_servico,");
            csql.Append("vl_servico,");
            csql.Append(cd_produto);
            csql.Append(",'" + nm_produto + "',");
            csql.Append("'" + vl_produto + "',");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.4 Método para atualizar (alterar um registro)
        public void Atualizar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Update tb_cliente ");
            csql.Append("set cd_produto=");
            csql.Append(cd_produto);
            csql.Append(", nm_servico='");
            csql.Append(nm_produto);
            csql.Append("', vl_servico='");
            csql.Append(vl_produto);
            csql.Append("' where cd_produto=");
            csql.Append(cd_produto);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.5 Método para excluir um cliente do 
        //Banco de dados
        public void Excluir()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tb_cliente ");
            csql.Append(" where cd_produto=");
            csql.Append(cd_produto);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNome()
        {
            string csql;
            csql = "Select * From tb_cliente where nm_servico like('%" + nm_produto + "%')";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

    }
}

