using System;
using System.Collections.Generic;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    internal class MacrosservicosDAO:GenericDAO
    {
        public void Insert(Macrosservicos macrosservico)
        {
            String sql = String.Format("INSERT INTO dcos.Macrosservicos (nome) VALUES ('{0}')", macrosservico.Nome);
            SQLinjector(sql);
        }
        public void Delete(Macrosservicos macrosservico)
        {
            String sql = String.Format("DELETE FROM dcos.Macrosservicos WHERE id_macrosservico = {0}", macrosservico.IdMacrosservico);
            SQLinjector(sql);
        }
        public void Update(Macrosservicos macrosservico)
        {
            String sql = String.Format("UPDATE dcos.Macrosservicos SET nome = '{0}' WHERE id_macrosservico = {1}", macrosservico.Nome, macrosservico.IdMacrosservico);
            SQLinjector(sql);
        }
        public List<Macrosservicos> Select(string sql)
        {
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaMacrosservicos = new List<Macrosservicos>();
            while (reader.Read())
            {
                Macrosservicos macrosservico = new Macrosservicos();
                macrosservico.IdMacrosservico = reader.GetInt32(0);
                macrosservico.Nome = reader.GetString(1);
                listaMacrosservicos.Add(macrosservico);
            }
            connection.Close();
            return listaMacrosservicos;
        }
    }
}
