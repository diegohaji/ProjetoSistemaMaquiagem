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
        private string nome;
        private double horario;


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
        public string NomeServico
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        //grava o serviço e o horario no banco de dados
        public void Gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Insert into tb_agendahorario");
            csql.Append("(");
            csql.Append("cd_servico,");
            csql.Append("servico,");
            csql.Append("nome,");
            csql.Append("horario) Values(");
            csql.Append(cd_servico);
            csql.Append(",'" + servico + "',");
            csql.Append(",'" + nome + "',");
            csql.Append("'" + horario + "')");
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }
    
        public void Atualizar() {
            StringBuilder csql = new StringBuilder();
            csql.Append("Update into tb_agendahorario");




        }


}


}
