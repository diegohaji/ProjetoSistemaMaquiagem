using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoADados;
namespace CamadaDeNegocio
{
    class ClnPagamento
    {

        private int cd_pagamento;

        public int Cd_pagamento
        {
            get
            {
                return cd_pagamento;
            }

            set
            {
                cd_pagamento = value;
            }
        }

        //gravar
        public void Gravar()
        {
            int cd_cliente = BuscarCdCliente();
            int cd_funcionario = BuscarCdFuncionario();
            int cd_servico = BuscarCdServico();
            double valor_total = BuscarValorTotal();
            StringBuilder csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(0);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            csql = new StringBuilder();
            csql.Append("Insert into tb_pagamento");
            csql.Append("(");
            csql.Append("cd_pagamento,");
            csql.Append("cd_funcionario,");
            csql.Append("cd_cliente,");
            csql.Append("cd_servico,");
            csql.Append("valor_total");
            csql.Append(") Values(");
            csql.Append(cd_pagamento);
            csql.Append(",'" + cd_funcionario + "',");
            csql.Append("'" + cd_cliente + "',");
            csql.Append("'" + cd_servico + "',");
            csql.Append("'" + valor_total + "'");
            csql.Append(")");
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(1);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

        }

        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNome()
        {
            string csql;
            csql = "select tps.nm_funcionario as Funcionario,tc.nm_cliente as Cliente,tps.nm_servico as Servico, sum(vl_total) as Valor_Total_Mensal from tb_prestacao_servico as tps inner join tb_funcionario as tf on tps.cd_funcionario = tf.cd_funcionario inner join tb_cliente as tc on tps.cd_cliente = tc.cd_cliente inner join tb_servico as ts on tps.cd_servico = ts.cd_servico";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

        public Int32 BuscarCdCliente()
        {
            string csql ;
            Int32 cdcliente = 0;
            csql = "select tps.cd_cliente from tb_prestacao_servico as tps inner join tb_cliente as tc on tps.cd_cliente = tc.cd_cliente ";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                cdcliente = Convert.ToInt32(dados.GetValue(0));
            }
            return cdcliente;
        }

        public Int32 BuscarCdFuncionario()
        {
            string csql;
            Int32 cdfuncionario = 0;
            csql = "select tps.cd_funcionario from tb_prestacao_servico as tps inner join tb_funcionario as tf on tps.cd_funcionario = tf.cd_funcionario ";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                cdfuncionario = Convert.ToInt32(dados.GetValue(0));
            }
            return cdfuncionario;
        }

        public Int32 BuscarCdServico()
        {
            string csql;
            Int32 cdservico = 0;
            csql = "select tps.cd_servico from tb_prestacao_servico as tps inner join tb_servico as ts on tps.cd_servico = ts.cd_servico ";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                cdservico = Convert.ToInt32(dados.GetValue(0));
            }
            return cdservico;
        }

        public double BuscarValorTotal()
        {
            string csql;
            double valor_total = 0;
            csql = "select sum(vl_total) from tb_prestacao_servico";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                valor_total = Convert.ToDouble(dados.GetValue(0));
            }
            return valor_total;
        }
    }
}
