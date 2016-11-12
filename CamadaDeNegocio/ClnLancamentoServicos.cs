using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoADados;
namespace CamadaDeNegocio
{
   public class ClnLancamentoServicos
    {

        private int cd_funcionario;
        private int cd_servico;
        private int cd_cliente;
        private string nm_funcionario;
        private string nm_servico;
        private string dt_prestacao;
        private string dt_pagamento;
        private string status_prestacao;
        private string vl_total;
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

        public string Nm_funcionario
        {
            get
            {
                return nm_funcionario;
            }

            set
            {
                nm_funcionario = value;
            }
        }

        public string Nm_servico
        {
            get
            {
                return nm_servico;
            }

            set
            {
                nm_servico = value;
            }
        }

        public string Dt_prestacao
        {
            get
            {
                return dt_prestacao;
            }

            set
            {
                dt_prestacao = value;
            }
        }

        public string Status_prestacao
        {
            get
            {
                return status_prestacao;
            }

            set
            {
                status_prestacao = value;
            }
        }

        public string Vl_total
        {
            get
            {
                return vl_total;
            }

            set
            {
                vl_total = value;
            }
        }

        public string Dt_pagamento
        {
            get
            {
                return dt_pagamento;
            }

            set
            {
                dt_pagamento = value;
            }
        }

        //Gravar
        public void Gravar()
        {

            StringBuilder csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(0);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

            csql = new StringBuilder();
            csql.Append("Insert into tb_prestacao_servico");
            csql.Append("(");
            csql.Append("cd_funcionario,");
            csql.Append("cd_cliente,");
            csql.Append("cd_servico,");
            csql.Append("status_prestacao,");
            csql.Append("nm_funcionario,");
            csql.Append("nm_servico,");
            csql.Append("data_prestacao,");
            csql.Append("data_pagamento,");
            csql.Append("vl_total");
            csql.Append(") Values(");
            csql.Append((cd_funcionario -1));
            csql.Append(",'" + (cd_cliente -1) + "',");
            csql.Append("'" + (cd_servico - 1) + "',");
            csql.Append("'" + status_prestacao + "',");
            csql.Append("'" + nm_funcionario + "',");
            csql.Append("'" + nm_servico + "',");
            csql.Append("'" + dt_prestacao + "',");
            csql.Append("'" + dt_pagamento + "',");
            csql.Append("'" + Convert.ToDouble(vl_total) + "'");
            csql.Append(")");
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
            csql.Append("update tb_prestacao_servico ");
            csql.Append("set status_prestacao = '");
            csql.Append(status_prestacao);
            csql.Append("', nm_funcionario = '");
            csql.Append(nm_funcionario);
            csql.Append("', nm_servico = '");
            csql.Append(nm_servico);
            csql.Append("', data_prestacao ='");
            csql.Append(dt_prestacao);
            csql.Append("', data_pagamento ='");
            csql.Append(dt_pagamento);
            csql.Append("', vl_total = ");
            csql.Append(Convert.ToDouble(vl_total));
            csql.Append(" where cd_funcionario = ");
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

        //3.5 Método para excluir do Banco de dados
        public void Excluir(int cod)
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tb_prestacao_servico ");
            csql.Append(" where cd_cliente='");
            csql.Append(cod + "'");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }


        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNome()
        {
            //
            string csql;
            csql = "select tps.cd_funcionario as Codigo_Funcionario, tps.cd_cliente as Codigo_Cliente,tps.cd_servico as Codigo_Servico, tps.nm_funcionario as Funcionario,tc.nm_cliente as Cliente,tps.nm_servico as Servico, tps.status_prestacao as Status,tps.data_prestacao as Data_Prestacao, tps.data_pagamento as Data_Pagamento,tps.vl_total as Valor_Total from tb_prestacao_servico as tps inner join tb_funcionario as tf on tps.cd_funcionario=tf.cd_funcionario inner join tb_cliente as tc on tps.cd_cliente = tc.cd_cliente inner join tb_servico as ts on tps.cd_servico=ts.cd_servico";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }


        //3.8 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporDivida()
        {
            //
            string csql;
            csql = "select tas.cd_funcionario as Codigo_Funcionario, tas.cd_cliente as Codigo_Cliente,tas.cd_servico as Codigo_Servico,tf.nm_funcionario as Funcionario,tc.nm_cliente as Cliente,ts.nm_servico as Servico, tas.data_agendamento as Data,tas.status as Status, ts.vl_servico as Valor from tb_agendamento_servico as tas inner join tb_funcionario as tf on tas.cd_funcionario=tf.cd_funcionario inner join tb_cliente as tc on tas.cd_cliente = tc.cd_cliente inner join tb_servico as ts on tas.cd_servico=ts.cd_servico where ts.cd_servico = tas.cd_servico";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }


        //3.7 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarOValor()
        {
            //tps.cd_funcionario as Codigo_Funcionario, tps.cd_cliente as Codigo_Cliente,tps.cd_servico as Codigo_Servico,
            string csql;
            csql = "select vl_servico as Valor from tb_servico as ts inner join tb_agendamento_servico as tas on ts.cd_servico = tas.cd_servico";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

    }
}
