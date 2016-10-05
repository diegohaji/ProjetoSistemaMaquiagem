﻿using System;
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
        private string status_prestacao;
        private double vl_total;
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

        public double Vl_total
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
            csql.Append("vl_total");
            csql.Append(") Values(");
            csql.Append(cd_funcionario);
            csql.Append(",'" + cd_cliente + "',");
            csql.Append("'" + cd_servico + "',");
            csql.Append("'" + status_prestacao + "',");
            csql.Append("'" + nm_funcionario + "',");
            csql.Append("'" + nm_servico + "',");
            csql.Append("'" + dt_prestacao + "',");
            csql.Append("'" + vl_total + "'");
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
            csql = "select tps.cd_funcionario as Codigo_Funcionario, tps.cd_cliente as Codigo_Cliente,tps.cd_servico as Codigo_Servico,tps.nm_funcionario as Funcionario,tps.nm_servico as Servico, tps.status_prestacao as Status,tps.data_prestacao as Data,tps.vl_total as Valor_Total from tb_prestacao_servico as tps inner join tb_funcionario as tf on tps.cd_funcionario=tf.cd_funcionario inner join tb_cliente as tc on tps.cd_cliente = tc.cd_cliente inner join tb_servico as ts on tps.cd_servico=ts.cd_servico";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }






    }
}
