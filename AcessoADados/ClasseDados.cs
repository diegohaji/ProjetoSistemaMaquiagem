using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace AcessoADados

{
 public class ClasseDados
    {
        string conexao = @"Persist Security Info=False;server=localhost;database=bd_lmds;uid=root;pwd=";

        private MySqlConnection AbrirBanco()
        {
            MySqlConnection cn = new MySqlConnection(conexao);
            cn.Open();
            return cn;
        }

        //Classe para Fechar o Banco de Dados
        public void FecharBanco(MySqlConnection cn)
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
        //Classe para execução de comando
        public void ExecutarComando(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = AbrirBanco();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharBanco(cn);
            }
        }
        //Classe que retorna um objeto DataSet
        public DataSet RetornarDataSet(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = AbrirBanco();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                /*  Declarado um dataadapter e um dataset
                    passar o comando para o da (SqlDataAdapter) e 
                    carregar o dataset com resultado da busca */
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharBanco(cn);
            }
        }
        //Classe para retornar um DataReader()
        public MySqlDataReader RetornarDataReader(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = AbrirBanco();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharBanco(cn);
            }
        }

        //Classe para retornar um Id Numérico
        public int RetornarIdNumerico(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = AbrirBanco();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                MySqlDataReader dr = cmd.ExecuteReader();
                int codigo;
                if (dr.Read())
                    codigo = Convert.ToInt16(dr[0]) + 1;
                else
                    codigo = 1;
                return codigo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharBanco(cn);
            }

        }
    }



}

