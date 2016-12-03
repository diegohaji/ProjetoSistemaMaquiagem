using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoADados;
namespace CamadaDeNegocio
{
   public class ClnPagamentoServicos
    {
        private int ordem_pagamento;
        private int cd_funcionario;
        private int cd_servico;
        private int cd_cliente;
        private string nm_cliente;
        private string nm_funcionario;
        private string nm_servico;
        private string dt_prestacao;
        private string hora_prestacao;
        private string dt_pagamento;
        private string status_prestacao;
        private string vl_total;
        private string formapagamento;

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

        public string Hora_prestacao
        {
            get
            {
                return hora_prestacao;
            }

            set
            {
                hora_prestacao = value;
            }
        }

        public string Formapagamento
        {
            get
            {
                return formapagamento;
            }

            set
            {
                formapagamento = value;
            }
        }

        public string Nm_cliente
        {
            get
            {
                return nm_cliente;
            }

            set
            {
                nm_cliente = value;
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
            csql.Append("nm_cliente,");
            csql.Append("nm_servico,");
            csql.Append("data_prestacao,");
            csql.Append("hora_prestacao,");
            csql.Append("data_pagamento,");
            csql.Append("vl_total,");
            csql.Append("forma_pagamento");
            csql.Append(") Values(");
            csql.Append((cd_funcionario));
            csql.Append(",'" + (cd_cliente) + "',");
            csql.Append("'" + (cd_servico) + "',");
            csql.Append("'" + status_prestacao + "',");
            csql.Append("'" + nm_funcionario + "',");
            csql.Append("'" + nm_cliente + "',");
            csql.Append("'" + nm_servico + "',");
            csql.Append("'" + dt_prestacao + "',");
            csql.Append("'" + hora_prestacao + "',");
            csql.Append("'" + dt_pagamento + "',");
            csql.Append("'" + Convert.ToDouble(vl_total) + "',");
            csql.Append("'" + formapagamento + "'");
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
            csql.Append("', nm_cliente = '");
            csql.Append(nm_cliente);
            csql.Append("', nm_servico = '");
            csql.Append(nm_servico);
            csql.Append("', data_prestacao ='");
            csql.Append(dt_prestacao);
            csql.Append("', hora_prestacao ='");
            csql.Append(Hora_prestacao);
            csql.Append("', data_pagamento ='");
            csql.Append(dt_pagamento);
            csql.Append("', vl_total = ");
            csql.Append(Convert.ToDouble(vl_total));
            csql.Append("', forma_pagamento ='");
            csql.Append(formapagamento);
            csql.Append(" where cd_funcionario = ");
            csql.Append((cd_funcionario));
            csql.Append("&& cd_cliente = ");
            csql.Append((cd_cliente));
            csql.Append(" && cd_servico = ");
            csql.Append(cd_servico);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(1);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());


        }

        //3.5 Método para excluir do Banco de dados
        public void Excluir(int ordem_pagamento)
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tb_prestacao_servico ");
            csql.Append(" where numero_pagamento='");
            csql.Append(ordem_pagamento + "'");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }


        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNome()
        {
            // tps.cd_funcionario as Codigo_Funcionario, tps.cd_cliente as Codigo_Cliente,tps.cd_servico as Codigo_Servico ,
            string csql;
            csql = "select tps.numero_pagamento as Numero_de_Pagamento,tps.nm_funcionario as Funcionario,tc.nm_cliente as Cliente,tps.nm_servico as Servico, tps.status_prestacao as Status,tps.data_prestacao as Data_Prestacao,tps.hora_prestacao as Hora ,tps.data_pagamento as Data_Pagamento,tps.vl_total as Valor_Total, tps.forma_pagamento as Forma_Pagamento from tb_prestacao_servico as tps inner join tb_funcionario as tf on tps.cd_funcionario=tf.cd_funcionario inner join tb_cliente as tc on tps.cd_cliente = tc.cd_cliente inner join tb_servico as ts on tps.cd_servico=ts.cd_servico";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }


        //3.8 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporDivida()
        {
            //tas.cd_funcionario as Codigo_Funcionario, tas.cd_cliente as Codigo_Cliente,tas.cd_servico as Codigo_Servico,
            string csql;
            csql = "select tas.ordem_pagamento as Ordem_de_Pagamento , tf.nm_funcionario as Funcionario,tc.nm_cliente as Cliente,ts.nm_servico as Servico, tas.data_agendamento as Data,tas.hora_agendamento as Hora_agendada,tas.status as Status, ts.vl_servico as Valor from tb_agendamento_servico as tas inner join tb_funcionario as tf on tas.cd_funcionario=tf.cd_funcionario inner join tb_cliente as tc on tas.cd_cliente = tc.cd_cliente inner join tb_servico as ts on tas.cd_servico=ts.cd_servico where ts.cd_servico = tas.cd_servico";
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

        public int BuscarporOrdemPagamento()
        {
            string csql;
            csql = "Select numero_pagamento From tb_prestacao_servico where  ";
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

    }
}
