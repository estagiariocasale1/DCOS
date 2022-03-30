using System;
using System.Collections.Generic;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    internal class SetoresDAO:GenericDAO
    {
        public void Insert(Setores setor)
        {
            String sql = String.Format("INSERT INTO dcos.Setores (nome) VALUES ('{0}')", setor.Nome);
            SQLinjector(sql);
        }
        public void Delete(Setores setor)
        {
            String sql = String.Format("DELETE FROM dcos.Setores WHERE id_setor = {0}", setor.IdSetor);
            SQLinjector(sql);
        }
        public void Update(Setores setor)
        {
            String sql = String.Format("UPDATE dcos.Setores SET nome = '{0}' WHERE id_setor = {1}", setor.Nome, setor.IdSetor);
            SQLinjector(sql);
        }
        public List<Setores> Select(string sql)
        {
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaSetores = new List<Setores>();
            while (reader.Read())
            {
                Setores setor = new Setores();
                setor.IdSetor = reader.GetInt32(0);
                setor.Nome = reader.GetString(1);
                listaSetores.Add(setor);
            }
            connection.Close();
            return listaSetores;
        }
    }
}
