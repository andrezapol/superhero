using System;
using System.Collections.Generic;
using System.Text;
using Avengers.Entidade;
using MySql;
using MySql.Data.MySqlClient;

namespace Avengers.Repositorio
{
    public class AvengersRepositorio
    {
        private string _strConn = System.Configuration.ConfigurationManager.AppSettings["MySql"];

        public AvengersRepositorio()
        {

        }

        public bool Insert(Heroes ohero)
        {
            // variáveis de acesso a dados
            MySqlConnection conn = null;
            MySqlCommand cmd = new MySqlCommand();
            string sql = string.Empty;
            bool ret = false;

            // cria uma conexão
            conn = new MySqlConnection(this._strConn);
            conn.Open();

            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;

            try
            {

                // Insere os dados no banco de dados
                sql = "INSERT INTO SUPERHERO (" +
                    "NOME," +
                    "DESCRICAO" +
                    ")" +
                    "VALUES (" +
                    "@NOME," +
                    "@DESCRICAO" +
                    ")";

                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                cmd.Parameters.Add("NOME", MySqlDbType.VarChar).Value = ohero.HeroName;
                cmd.Parameters.Add("DESCRICAO", MySqlDbType.Int32).Value = ohero.HeroDescription;

                // executa o insert
                if (cmd.ExecuteNonQuery() > 0)
                {
                    //ohero.Codigo = Convert.ToInt32(cmd.LastInsertedId);
                    ret = true;
                }
                else
                {
                    ret = false;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                // fecha a conexão

                conn.Close();
                conn.Dispose();
            }

            // retorna os dados
            return ret;
        }


    }
}
