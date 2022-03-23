using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using dc_os.v1.dao;

namespace dc_os.v1.dao
{
    public class GenericDAO
    {
        NpgsqlConnection connection = new Conexao().GetConexao();
        
        public void SQLinjector(string SQL)
        {
            try
            {
                connection.Open();
                var injectorcmd = connection.CreateCommand();
                injectorcmd.CommandText = SQL;
                injectorcmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Comando falhou");
            }
        }
        
        public virtual NpgsqlDataReader SQLselect(string SQL)
        {
            connection.Open();
            using var cmd = new NpgsqlCommand(SQL, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();
            return reader;     

        }

    }
}
