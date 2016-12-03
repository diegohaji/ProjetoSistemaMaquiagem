using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AcessoADados;
namespace CamadaDeNegocio
{
   public class ClnServiços
    {
        //1 - Campos privados da classe
        private int cd_servico;
        private string nm_servico;
        private string vl_servico;
        private string duracao;

        //2 - propriedades, acesso aos campos privados
        public int Cd_Servico
        {
            get { return cd_servico; }
            set { cd_servico = value; }
        }
        public string Nm_Servico
        {
            get { return nm_servico; }
            set { nm_servico = value; }
        }
        public string VL_Servico
        {
            get { return vl_servico; }
            set { vl_servico = value; }
        }

        public string Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }


        //3 - métodos da classe de Negócios (clnservico.cs)


        //3.1 Buscar dados do servico cujo codigo foi especificado
        public void BuscarporCodigo()
        {
            string csql;
            csql = "Select * From tb_servico where cd_servico=" + cd_servico;
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array dados = ds.Tables[0].Rows[0].ItemArray;
                cd_servico = Convert.ToInt16(dados.GetValue(0));
                nm_servico = Convert.ToString(dados.GetValue(1));
                vl_servico = Convert.ToString(dados.GetValue(2));
                duracao = Convert.ToString(dados.GetValue(3));                
            }
        }

        //3.2 Buscar o próximo Id Numerico para 
        //inclusao de um novo servico.
        public int BuscarId(string nome)
        {
            string csql;
            csql = "Select cd_servico From tb_servico where nm_servico like('%"+ nome +"%')";
            ClasseDados cd = new ClasseDados();
            return (cd.RetornarIdNumerico(csql) - 1);
        }

        //3.3 Método para incluir um novo servico no 
        //Banco de dados
        public void Gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(0);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            csql = new StringBuilder();
            csql.Append("Insert into tb_servico");
            csql.Append("(");
            csql.Append("cd_servico,");
            csql.Append("nm_servico,");
            csql.Append("vl_servico,");
            csql.Append("duracao) Values(");
            csql.Append(cd_servico);
            csql.Append(",'" + nm_servico + "',");
            csql.Append("'" + Convert.ToDouble(vl_servico) + "',");
            csql.Append("'" + duracao + "')");
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
            csql = new StringBuilder();
            csql.Append("SET FOREIGN_KEY_CHECKS = ");
            csql.Append(1);
            cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.4 Método para atualizar (alterar um registro)
        public void Atualizar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Update tb_servico ");
            csql.Append("set nm_servico='");
            csql.Append(nm_servico);
            csql.Append("', vl_servico='");
            csql.Append( Convert.ToDouble(vl_servico));
            csql.Append("', duracao = '");
            csql.Append(duracao);
            csql.Append("' where cd_servico=");
            csql.Append(cd_servico-1);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());

        }

        //3.5 Método para excluir um servico do 
        //Banco de dados
        public void Excluir(int cdservico)
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From tb_servico ");
            csql.Append(" where cd_servico =");
            csql.Append(cdservico);
            ClasseDados cd = new ClasseDados();
            cd.ExecutarComando(csql.ToString());
        }

        //3.6 Método para buscar os dados do servico de acordo com o nome
        public DataSet BuscarporNome()
        {
            //
            string csql;
            csql = "Select cd_servico as Codigo, nm_servico as Nome, vl_servico as Valor, duracao as Duracao From tb_servico where nm_servico like('%" + nm_servico + "%')";
            DataSet ds;
            ClasseDados cd = new ClasseDados();
            ds = cd.RetornarDataSet(csql);
            return ds;
        }

    }
}

