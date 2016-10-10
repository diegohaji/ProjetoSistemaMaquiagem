using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoADados;
using System.Data;

namespace CamadaDeNegocio
{
   public class ClnRelatorio
    {

        private string data_inicial;
        private string data_final;
        private string nome_funcionario;
        private string nome_cliente;

        public string Nome_cliente
        {
            get
            {
                return nome_cliente;
            }

            set
            {
                nome_cliente = value;
            }
        }

        public string Nome_funcionario
        {
            get
            {
                return nome_funcionario;
            }

            set
            {
                nome_funcionario = value;
            }
        }

        public string Data_final
        {
            get
            {
                return data_final;
            }

            set
            {
                data_final = value;
            }
        }

        public string Data_inicial
        {
            get
            {
                return data_inicial;
            }

            set
            {
                data_inicial = value;
            }
        }







        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNomeCliente()
        {
            string csql;
            csql = "select tc.cd_cliente as Codigo_Cliente, tc.nm_cliente as Nome, ts.nm_servico as Servico, tps.status_prestacao as Status, tps.vl_total as Valor, tps.data_prestacao as Data from tb_cliente as tc inner join tb_prestacao_servico as tps on tc.cd_cliente = tps.cd_cliente inner join tb_servico as ts on tps.cd_servico = ts.cd_servico where tc.nm_cliente like('%"+ nome_cliente +"%') ";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNomeFuncionario()
        {
            string csql;
            csql = "select tf.cd_funcionario as Codigo_Funcionario, tc.nm_funcionario as Nome, ts.nm_servico as Servico, tps.status_prestacao as Status, tps.vl_total as Valor, tps.data_prestacao as Data from tb_funcionario as tc inner join tb_prestacao_servico as tps on tf.cd_funcionario = tps.cd_funcionario inner join tb_servico as ts on tps.cd_servico = ts.cd_servico where tf.nm_funcionario like('%"+nome_funcionario+"%') ";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporData()
        {
            string csql;
            csql = "select ts.cd_servico as Codigo_Servico, ts.nm_servico as Nome, tps.vl_total as Valor, tps.data_prestacao as Periodo from tb_servico as ts inner join tb_prestacao_servico as tps on ts.cd_servico = tps.cd_servico where strcmp(" + data_inicial+", " + data_final+")";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

        //3.6 Método para buscar os dados do cliente de acordo com o nome
        public DataSet BuscarporNome()
        {
            string csql;
            csql = "select * from tb_cliente as tc join tb_funcionario join tb_servico"; 
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

    }
}
