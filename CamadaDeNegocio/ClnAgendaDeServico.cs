using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoADados;
using System.Data;


namespace CamadaDeNegocio
{
   public class ClnAgendaDeServico
    {
        private int ordem_pagamento;
        private int cd_funcionario;
        private int cd_servico;
        private int cd_cliente;
        private string data_agendamento;
        private string hora_agendamento;
        private string nm_pesquisa;
        private string produto;
        private string quantidade;
        private string status;

        public int Cd_funcionario
        {
            get
            {
                return cd_funcionario;
            }

            set
            {
                cd_funcionario = value;
            }
        }

        public int Cd_servico
        {
            get
            {
                return cd_servico;
            }

            set
            {
                cd_servico = value;
            }
        }

        public int Cd_cliente
        {
            get
            {
                return cd_cliente;
            }

            set
            {
                cd_cliente = value;
            }
        }

        public string Dt_agendamento
        {
            get
            {
                return data_agendamento;
            }

            set
            {
                data_agendamento = value;
            }
        }

        public string Hora_agendamento
        {
            get
            {
                return hora_agendamento;
            }

            set
            {
                hora_agendamento = value;
            }
        }

        public string Nm_pesquisa
        {
            get
            {
                return nm_pesquisa;
            }

            set
            {
                nm_pesquisa = value;
            }
        }

        public string Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
            }
        }

        public string Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int Ordem_pagamento
        {
            get
            {
                return ordem_pagamento;
            }

            set
            {
                ordem_pagamento = value;
            }
        }

        //gravar
        public void Gravar()
        {

            StringBuilder csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(0);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            status = "pendente";
            csql = new StringBuilder();
            csql.Append("Insert into tb_agendamento_servico");
            csql.Append("(");
            csql.Append("cd_funcionario,");
            csql.Append("cd_cliente,");
            csql.Append("cd_servico,");
            csql.Append("data_agendamento,");
            csql.Append("hora_agendamento,");
            csql.Append("produto,");
            csql.Append("quantidade,");
            csql.Append("status");
            csql.Append(") Values(");
            csql.Append((cd_funcionario -1 ));
            csql.Append(",'" + (cd_cliente -1 ) + "',");
            csql.Append("'" + (cd_servico -1 )+ "',");
            csql.Append("'" + data_agendamento + "',");
            csql.Append("'" + hora_agendamento + "',");
            csql.Append("'" + produto + "',");
            csql.Append("'" + Convert.ToInt32(quantidade) + "',");
            csql.Append("'" + status + "'");
            csql.Append(")");
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

            csql = new StringBuilder();
            csql.Append("select cd_cliente from tb_cliente where cd_cliente = '" + cd_cliente + "'");
            cd = new ClasseDados();
            int marreta = cd.RetornarIdNumerico(csql.ToString()) - 1;

            csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(1);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

        }

        //3.5 Método para excluir do Banco de dados
        public void Excluir(int ordem)
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tb_agendamento_servico ");
            csql.Append(" where ordem_pagamento='");
            csql.Append(ordem + "'");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNome()
        {
            //
            string csql;
            csql = "select tas.cd_funcionario as Codigo_Funcionario, tas.cd_cliente as Codigo_Cliente,tas.cd_servico as Codigo_Servico, tf.nm_funcionario as Funcionario,tc.nm_cliente as Cliente,ts.nm_servico as Servico, tas.data_agendamento as Data,tas.hora_agendamento as Hora, tas.produto as Produto, tas.quantidade as Qtd, tas.status as Status from tb_agendamento_servico as tas inner join tb_funcionario as tf on tas.cd_funcionario=tf.cd_funcionario inner join tb_cliente as tc on tas.cd_cliente = tc.cd_cliente inner join tb_servico as ts on tas.cd_servico=ts.cd_servico";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }


        public String BuscarporCodigoFuncionario(int cdfuncionario)
        {
            string nm_funcionario;
            string csql;
            csql = "Select nm_funcionario From tb_funcionario where cd_funcionario=" + cdfuncionario;
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                nm_funcionario = Convert.ToString(dados.GetValue(1));
                return nm_funcionario;
            }
            return null;
        }

        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNomePrincipal()
        {
            //
            string csql;
            csql = "select tas.cd_funcionario as Codigo_Funcionario, tas.cd_cliente as Codigo_Cliente,tas.cd_servico as Codigo_Servico, tf.nm_funcionario as Funcionario,tc.nm_cliente as Cliente,ts.nm_servico as Servico, tas.data_agendamento as Data,tas.hora_agendamento as Hora, tas.status as Status from tb_agendamento_servico as tas inner join tb_funcionario as tf on tas.cd_funcionario=tf.cd_funcionario inner join tb_cliente as tc on tas.cd_cliente = tc.cd_cliente inner join tb_servico as ts on tas.cd_servico=ts.cd_servico";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }


        public int BuscarporOrdemPagamento()
        {
            string csql;
            csql = "Select ordem_pagamento From tb_agendamento_servico where data_agendamento like('%" + data_agendamento + "%')" + " and hora_agendamento like('%"+ hora_agendamento +"%')";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                ordem_pagamento = Convert.ToInt16(dados.GetValue(0));

            }
            return ordem_pagamento;
        }

        public void Atualizar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(0);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            status = "pendente";
            csql = new StringBuilder();
            csql.Append("update tb_agendamento_servico ");
            csql.Append("set data_agendamento = '");
            csql.Append(data_agendamento);
            csql.Append("', hora_agendamento = '");
            csql.Append(hora_agendamento);
            csql.Append("', produto = '");
            csql.Append(produto);
            csql.Append("', quantidade = '");
            csql.Append(Convert.ToInt32(quantidade));
            csql.Append("', status = '");
            csql.Append(status);
            csql.Append("' where cd_funcionario = ");
            csql.Append((cd_funcionario - 1));
            csql.Append("&& cd_cliente = ");
            csql.Append((cd_cliente - 1));
            csql.Append(" && cd_servico = ");
            csql.Append(cd_servico - 1);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(1);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }
        }
}
