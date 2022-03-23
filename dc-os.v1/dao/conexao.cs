using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace dc_os.v1.dao
{
    public class Conexao
    {
        private static string serverName = "186.249.51.130";    //localhost
        private static string port = "5432";                    //porta default
        private static string userName = "daniel.carvalho";     //nome do administrador
        private static string password = "dccdaniel";           //senha do administrador
        private static string databaseName = "SIGMETRO";        //banco

        private string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                           serverName, port, userName, password, databaseName);

        public NpgsqlConnection GetConexao()
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                return conn;
            }
            catch
            {
                return null;
            }
        }
    }
}
