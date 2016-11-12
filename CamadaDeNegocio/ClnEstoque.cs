using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoADados;
using System.Data;

namespace CamadaDeNegocio
{
    public class ClnEstoque
    {
        private int cd_estoque;
        private int cd_produto;
        private string qtd_minimo;
        private string qtd_atual;
        private string nm_produto;


        public int Cd_Estoque
        {
            get { return cd_estoque; }
            set { cd_estoque = value; }
        }

        public int Cd_Produto
        {
            get { return cd_produto; }
            set { cd_produto = value; }
        }

        public string Qtd_Minimo
        {
            get { return qtd_minimo; }
            set { qtd_minimo = value; }
        }

        public string Qtd_Atual
        {
            get { return qtd_atual; }
            set { qtd_atual = value; }
        }

        public string Nm_Produto
        {
            get { return nm_produto; }
            set { nm_produto = value; }
        }


        //3.1 Buscar dados do cliente cujo codigo foi especificado
        public int BuscarporCodigoProduto()
        {
            string csql;
            csql = "Select cd_produto From tb_produto where nm_produto like('%" + this.nm_produto + "%')";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                cd_produto = Convert.ToInt16(dados.GetValue(0));

            }
            return cd_produto;
        }

        public int BuscarporCodigoEstoque()
        {
            string csql;
            csql = "Select cd_estoque From tb_estoque_produto where tipo like('%" + nm_produto + "%')";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                cd_estoque = Convert.ToInt16(dados.GetValue(0));

            }
            return cd_estoque;
        }

        public String BuscarporQtdAtual(string nm_produto)
        {
            string csql;
            csql = "Select qte_atual From tb_estoque_produto where tipo like('%" + nm_produto + "%')";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                qtd_atual = Convert.ToString(dados.GetValue(0));

            }
            return qtd_atual;
        }

        public String BuscarporQtdMinima(string nm_produto)
        {
            string csql;
            csql = "Select qte_minima From tb_estoque_produto where tipo like('%" + nm_produto + "%')";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                qtd_minimo = Convert.ToString(dados.GetValue(0));

            }
            return qtd_minimo;
        }


        //inserir no banco de dados
        public void Gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(0);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            BuscarporCodigoProduto();
            csql = new StringBuilder();
            csql.Append("Insert into tb_estoque_produto");
            csql.Append("(");
            csql.Append("cd_estoque,");
            csql.Append("cd_produto,");
            csql.Append("tipo,");
            csql.Append("qte_minima,");
            csql.Append("qte_atual) Values(");
            csql.Append(cd_estoque);
            csql.Append(",'" + (cd_produto) + "',");
            csql.Append("'" + nm_produto + "',");
            csql.Append("'" + Convert.ToInt16(qtd_minimo) + "',");
            csql.Append("'" + Convert.ToInt16(qtd_atual) + "')");
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(1);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        public void Atualizar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(0);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            csql = new StringBuilder();
            csql.Append("update tb_estoque_produto ");
            csql.Append("set ");
            csql.Append(" tipo = '");
            csql.Append(nm_produto);
            csql.Append("', qte_minima = ");
            csql.Append(Convert.ToInt16(qtd_minimo));
            csql.Append(", qte_atual = ");
            csql.Append(Convert.ToInt16(qtd_atual));
            csql.Append(" where cd_estoque = ");
            csql.Append(cd_estoque);
            csql.Append(" && cd_produto = ");
            csql.Append(cd_produto);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(1);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());


        }



        //3.6 Método para buscar os dados do produto de acordo com o nome
        public DataSet BuscarporNome()
        {
            string csql;
            csql = "Select tep.cd_estoque as Codigo_do_Estoque, tep.cd_produto as Codigo_do_Produto, tep.tipo as Nome ,tep.qte_minima as Qtd_Minima, tep.qte_atual as Qtd_Atual From tb_estoque_produto as tep inner join tb_produto as tp on tep.cd_produto = tp.cd_produto";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

    }
}
