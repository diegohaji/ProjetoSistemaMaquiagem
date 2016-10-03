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
        private int cd_servico;
        private string servico;
        private string funcionario;
        private string horario;


        public int Cd_servico
        {
            get { return cd_servico; }
            set { cd_servico = value; }
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
            get { return horario; }
            set { horario = value; }
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
            csql.Append(cd_servico);
            csql.Append(",'" + servico + "',");
            csql.Append("'" + funcionario + "',");
            csql.Append("'" + horario + "')");
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
            csql.Append("Update into tb_horario_func");

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
