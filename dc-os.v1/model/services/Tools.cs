using System;
using System.Collections.Generic;
using System.Text;
using dc_os.v1.dao;

namespace dc_os.v1.model.services
{
    public class Tools
    {   // função experiemntal
        /*public DateTime TimeZoneToDatatime()
        {
            string coluna = "data";
            string idname = "id_viagem";
            string tabela = "dcos.boletim_viagem";
            int id = 8;
            string sql = String.Format("SELECT id_viagem, {0} FROM {1} WHERE {2} = {3};", coluna, tabela, idname, id);
            Console.WriteLine(sql);
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine((reader.GetValue(1)).GetType());
                Console.WriteLine(reader.GetValue(1));
            }

            connection.Close();
        }*/


        public void DateTimeToTimeZone(DateTime dt, string tabela, string coluna)
        {
            int ano = dt.Year;
            int mes = dt.Month;
            int dia = dt.Day;
            int hora = dt.Hour;
            int min = dt.Minute;
            int seg = dt.Second;
            string sql = string.Format("INSERT INTO {6} ({7}) VALUES ('{0}-{1}-{2} {3}:{4}:{5}');", ano, mes, dia, hora, min, seg, tabela, coluna);
            GenericDAO conn = new GenericDAO();
            conn.SQLinjector(sql);
        }
    }
}
