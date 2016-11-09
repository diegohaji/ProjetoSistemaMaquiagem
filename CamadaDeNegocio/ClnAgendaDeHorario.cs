using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoADados;
using System.Data;
using MySql.Data.MySqlClient;

namespace CamadaDeNegocio
{
  public class ClnAgendaDeHorario
    {
        private int cd_funcionario;
        private string servico;
        private string funcionario;
        private string horarioinicial;
        private string horariofinal;


        public int Cd_funcionario
        {
            get { return cd_funcionario; }
            set { cd_funcionario = value; }
        }
        public string Servico
        {
            get { return servico; }
            set { servico = value; }
        }
        public string NomeFuncionario
        {
            get { return funcionario; }
            set { funcionario = value; }
        }
        public string Horario
        {
            get { return horarioinicial; }
            set { horarioinicial = value; }
        }

        public string Horariofinal
        {
            get
            {
                return horariofinal;
            }

            set
            {
                horariofinal = value;
            }
        }

        //grava o serviço e o horario no banco de dados
        public void Gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(0);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            csql = new StringBuilder();
            csql.Append("Insert into tb_horario_func");
            csql.Append("(");
            csql.Append("cd_funcionario,");
            csql.Append("nm_servico,");
            csql.Append("nm_funcionario,");
            csql.Append("horarios) Values(");
            csql.Append(cd_funcionario+1);
            csql.Append(",'" + servico + "',");
            csql.Append("'" + funcionario + "',");
            csql.Append("'" + horarioinicial + "')");
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(0);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

        }
    
        public void Atualizar() {
            StringBuilder csql = new StringBuilder();
            csql.Append("Update tb_horario_func ");
            csql.Append("set nm_funcionario = '");
            csql.Append(funcionario);
            csql.Append("', nm_servico = '");
            csql.Append(servico);
            csql.Append("', horarios = '");
            csql.Append(horarioinicial);
            csql.Append("' where cd_funcionario = ");
            csql.Append((cd_funcionario-1));
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.5 Método para excluir um servico do 
        //Banco de dados
        public void Excluir(string funcionario)
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tb_horario_func ");
            csql.Append(" where nm_funcionario='");
            csql.Append(funcionario + "'");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        public DataSet BuscarporNome()
        {
            string csql;
            csql = "select cd_funcionario as Codigo, nm_funcionario as Funcionario, nm_servico as Servico, horarios as Horario from tb_horario_func";
            DataSet ds = new DataSet();
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;

        }


}


}
