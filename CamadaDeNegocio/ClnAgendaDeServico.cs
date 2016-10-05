﻿using System;
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
        private int cd_funcionario;
        private int cd_servico;
        private int cd_cliente;
        private string data_agendamento;
        private string hora_agendamento;
        private string nm_pesquisa;

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

        //gravar
        public void Gravar()
        {

            StringBuilder csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(0);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

            csql = new StringBuilder();
            csql.Append("Insert into tb_agendamento_servico");
            csql.Append("(");
            csql.Append("cd_funcionario,");
            csql.Append("cd_cliente,");
            csql.Append("cd_servico,");
            csql.Append("data_agendamento,");
            csql.Append("hora_agendamento");
            csql.Append(") Values(");
            csql.Append((cd_funcionario -1 ));
            csql.Append(",'" + (cd_cliente -1 ) + "',");
            csql.Append("'" + (cd_servico -1 )+ "',");
            csql.Append("'" + data_agendamento + "',");
            csql.Append("'" + hora_agendamento + "'");
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
        public void Excluir(int cod)
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tb_agendamento_servico ");
            csql.Append(" where cd_cliente='");
            csql.Append(cod + "'");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNome()
        {
            string csql;
            csql = "select tas.cd_funcionario as Codigo_Funcionario, tas.cd_cliente as Codigo_Cliente,tas.cd_servico as Codigo_Servico,tf.nm_funcionario as Funcionario,tc.nm_cliente as Cliente,ts.nm_servico as Servico, tas.data_agendamento as Data,tas.hora_agendamento as Hora from tb_agendamento_servico as tas inner join tb_funcionario as tf on tas.cd_funcionario=tf.cd_funcionario inner join tb_cliente as tc on tas.cd_cliente = tc.cd_cliente inner join tb_servico as ts on tas.cd_servico=ts.cd_servico";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

    }
}
