﻿using System;
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
        private string vl_produto;
        private string nm_marca;
        private string dt_vencimento;
        private string dt_aquisicao;
        private string uso;

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
        public string VL_Produto
        {
            get { return vl_produto; }
            set { vl_produto = value; }
        }

        public string Nm_Marca
        {
            get { return nm_marca; }
            set { nm_marca = value; }
        }

        public string Dt_Vencimento
        {
            get { return dt_vencimento; }
            set { dt_vencimento = value; }
        }

        public string Dt_Aquisicao
        {
            get { return dt_aquisicao; }
            set { dt_aquisicao = value; }
        }

        public string Uso
        {
            get { return uso; }
            set { uso = value; }
        }

        //3 - métodos da classe de Negócios (clnservico.cs)


        //3.1 Buscar dados do produto cujo codigo foi especificado
        public int BuscarporCodigo()
        {
            string csql;
            csql = "Select nm_produto From tb_produto where cd_produto=" + cd_produto;
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                nm_produto = Convert.ToString(dados.GetValue(0));
            }
            return cd_produto;
        }

        //3.2 Buscar o próximo Id Numerico para 
        //inclusao de um novo produto.
        public int BuscarId(string nmproduto)
        {
            string csql;
            csql = "Select cd_produto From tb_produto where nm_produto like ('%"+ nmproduto +"%')";
            ClasseDados cd = new ClasseDados();
            return (cd.RetornarIdNumerico(csql) - 1);
        }

        //3.3 Método para incluir um novo produto no 
        //Banco de dados
        public void Gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Insert into tb_produto");
            csql.Append("(");
            csql.Append("cd_produto,");
            csql.Append("nm_produto,");
            csql.Append("nm_marca,");
            csql.Append("vl_produto,");
            csql.Append("dt_aquisicao,");
            csql.Append("dt_vencimento,");
            csql.Append("uso) Values(");
            csql.Append(cd_produto);
            csql.Append(",'" + nm_produto + "',");
            csql.Append("'" + nm_marca + "',");
            csql.Append("'" + Convert.ToDouble(vl_produto) + "',");
            csql.Append("'" + dt_aquisicao + "',");
            csql.Append("'" + dt_vencimento + "',");
            csql.Append("'" + uso + "')");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.4 Método para atualizar (alterar um registro)
        public void Atualizar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Update tb_produto ");
            csql.Append("set nm_produto='");
            csql.Append(nm_produto);
            csql.Append("', nm_marca = ");
            csql.Append("'" + nm_marca);
            csql.Append("', vl_produto=");
            csql.Append(Convert.ToDouble(vl_produto));
            csql.Append(" ,dt_aquisicao=");
            csql.Append("'" + dt_aquisicao + "'");
            csql.Append(",dt_vencimento=");
            csql.Append("'" + dt_vencimento + "'");
            csql.Append(",uso = ");
            csql.Append("'" + uso);
            csql.Append("' where cd_produto=");
            csql.Append(cd_produto);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.5 Método para excluir um produto do 
        //Banco de dados
        public void Excluir(int cdproduto)
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tb_produto ");
            csql.Append(" where cd_produto=");
            csql.Append(cdproduto);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.6 Método para buscar os dados do produto de acordo com o nome
        public DataSet BuscarporNome()
        {
            //
            string csql;
            csql = "Select cd_produto as Codigo, nm_produto as Nome, nm_marca as Marca ,vl_produto as Valor, dt_aquisicao as Aquisicao, dt_vencimento as Vencimento, uso as Uso From tb_produto where nm_produto like('%" + nm_produto + "%')";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

        

    }
}

