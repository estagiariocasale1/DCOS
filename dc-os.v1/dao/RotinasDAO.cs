using System;
using System.Collections.Generic;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    internal class RotinasDAO:GenericDAO
    {
        public void Insert(Rotinas rotina)
        {
            String sql = String.Format("INSERT INTO dcos.Rotinas (nome) VALUES ('{0}')", rotina.Nome);
            SQLinjector(sql);
        }
        public void Delete(Rotinas rotina)
        {
            String sql = String.Format("DELETE FROM dcos.Rotinas WHERE id_rotina = {0}", rotina.IdRotina);
            SQLinjector(sql);
        }
        public void Update(Rotinas rotina)
        {
            String sql = String.Format("UPDATE dcos.Rotinas SET nome = '{0}' WHERE id_rotina = {1}", rotina.Nome, rotina.IdRotina);
            SQLinjector(sql);
        }
        public List<Rotinas> Select(string sql)
        {
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaRotinas = new List<Rotinas>();
            while (reader.Read())
            {
                Rotinas rotina = new Rotinas();
                rotina.IdRotina = reader.GetInt32(0);
                rotina.Nome = reader.GetString(1);
                listaRotinas.Add(rotina);
            }
            connection.Close();
            return listaRotinas;
        }
    }
}
