using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    internal class LocaisDAO:GenericDAO
    {
        public void Insert(Locais local)
        {
            String sql = String.Format("INSERT INTO dcos.Locais (nome, rua, numero, bairro, cidade, cep) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", local.Nome, local.Rua, local.Numero, local.Bairro, local.Cidade, local.Cep);
            SQLinjector(sql);
        }
        public void Delete(Locais local)
        {
            String sql = String.Format("DELETE FROM dcos.Locais WHERE id_local = {0}", local.IdLocal);
            SQLinjector(sql);
        }
        public void Update(Locais local)
        {
            String sql = String.Format("UPDATE dcos.Locais SET nome = '{0}' WHERE id_local = {1}", local.Nome, local.IdLocal);
            SQLinjector(sql);
        }
        public List<Locais> Select(string sql)        {
         
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaLocais = new List<Locais>();
            while (reader.Read())
            {
                Locais local = new Locais();
                local.IdLocal = reader.GetInt32(0);
                local.Nome = reader.GetString(1);
                local.Rua = reader.GetString(2);
                local.Numero = reader.GetInt32(3);
                local.Bairro = reader.GetString(4);
                local.Cidade = reader.GetString(5);
                local.Cep = reader.GetString(6);
                listaLocais.Add(local);
            }
            connection.Close();
            return listaLocais;
        }
    }
}
