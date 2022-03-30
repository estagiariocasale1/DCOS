using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    internal class RelatoriosDAO:GenericDAO
    {
        public void Insert(Relatorios relatorio)
        {
            String sql = String.Format("INSERT INTO dcos.Relatorios (nome) VALUES ('{0}', '{1}', '{2}', '{0}')", relatorio.Relato, relatorio.Relato, relatorio.CroquiAnexo, relatorio.IdOs);
            SQLinjector(sql);
        }
        public void Delete(Relatorios relatorio)
        {
            String sql = String.Format("DELETE FROM dcos.Relatorios WHERE id_relatorio = {0}", relatorio.IdRelatorio);
            SQLinjector(sql);
        }
        public void Update(Relatorios relatorio)
        {
            String sql = String.Format("UPDATE dcos.Relatorios SET nome = '{0}' WHERE id_relatorio = {1}", relatorio.Relato, relatorio.IdRelatorio);
            SQLinjector(sql);
        }
        public List<Relatorios> Select(string sql)
        {
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaRelatorios = new List<Relatorios>();
            while (reader.Read())
            {
                Relatorios relatorio = new Relatorios();
                relatorio.IdRelatorio = reader.GetInt32(0);
                relatorio.Relato = reader.GetString(1);
                relatorio.CroquiAnexo = reader.GetString(2);
                relatorio.IdOs = reader.GetInt32(3);
                listaRelatorios.Add(relatorio);
            }
            connection.Close();
            return listaRelatorios;
        }
    }
}
