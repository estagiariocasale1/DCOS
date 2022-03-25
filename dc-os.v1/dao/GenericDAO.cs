using System;
using Npgsql;

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
       
    }
}
