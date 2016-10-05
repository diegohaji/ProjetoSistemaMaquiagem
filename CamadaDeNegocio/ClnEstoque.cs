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
        private int qtd_minimo;
        private int qtd_atual;
        private string nm_produto;


        public int Cd_Estoque
        {
            get {return cd_estoque ; }
            set {cd_estoque = value ; }
        }

        public int Cd_Produto
        {
            get { return cd_produto; }
            set { cd_produto = value; }
        }

        public int Qtd_Minimo
        {
            get { return qtd_minimo; }
            set { qtd_minimo = value; }
        }

        public int Qtd_Atual
        {
            get { return qtd_atual; }
            set { qtd_atual = value; }
        }

        public string Nm_Produto
        {
            get {return nm_produto; }
            set {nm_produto = value; }
        }


        //3.1 Buscar dados do cliente cujo codigo foi especificado
        public void BuscarporCodigo()
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
        }



        //inserir no banco de dados
        public void Gravar()
        {
            BuscarporCodigo();
            StringBuilder csql = new StringBuilder();
            csql.Append("Insert into tb_estoque_produto");
            csql.Append("(");
            csql.Append("cd_estoque,");
            csql.Append("cd_produto,");
            csql.Append("tipo,");
            csql.Append("qte_minima,");
            csql.Append("qte_atual) Values(");
            csql.Append(cd_estoque);
            csql.Append(",'" + cd_produto + "',");
            csql.Append("'" + nm_produto + "',");
            csql.Append("'" + qtd_minimo + "',");
            csql.Append("'" + qtd_atual + "')");
            ClasseDados cd = new ClasseDados();
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
