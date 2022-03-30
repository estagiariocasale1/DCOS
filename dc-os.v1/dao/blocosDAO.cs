using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    internal class blocosDAO : GenericDAO
    {
        public void Insert(Blocos bloco)
        {
            String sql = String.Format("INSERT INTO dcos.Blocos (nome) VALUES ('{0}')", bloco.Nome);
            SQLinjector(sql);
        }
        public void Delete(Blocos bloco)
        {
            String sql = String.Format("DELETE FROM dcos.Blocos WHERE id_bloco = {0}", bloco.IdBloco);
            SQLinjector(sql);
        }
        public void Update(Blocos bloco)
        {
            String sql = String.Format("UPDATE dcos.Blocos SET nome = '{0}' WHERE id_bloco = {1}", bloco.Nome, bloco.IdBloco);
            SQLinjector(sql);
        }
        public List<Blocos> Select(string sql)
        {
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaBlocos = new List<Blocos>();
            while (reader.Read())
            {
                Blocos bloco = new Blocos();
                bloco.IdBloco = reader.GetInt32(0);
                bloco.Nome = reader.GetString(1);
                listaBlocos.Add(bloco);
            }
            connection.Close();
            return listaBlocos;
        }
    }
}
