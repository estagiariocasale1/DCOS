using System;
using System.Collections.Generic;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    internal class itemDAO:GenericDAO
    {
        public void Insert(MatEquip item)
        {
            String sql = String.Format("INSERT INTO dcos.MatEquip (nome, tombamento) VALUES ('{0}', '{1}')", item.Nome, item.Tombamento);
            SQLinjector(sql);
        }
        public void Delete(MatEquip item)
        {
            String sql = String.Format("DELETE FROM dcos.MatEquip WHERE id_item = {0}", item.IdItem);
            SQLinjector(sql);
        }
        public void Update(MatEquip item)
        {
            String sql = String.Format("UPDATE dcos.MatEquip SET nome = '{0}' WHERE id_item = {1}", item.Nome, item.IdItem);
            SQLinjector(sql);
        }
        public List<MatEquip> Select(string sql)
        {
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaMatEquip = new List<MatEquip>();
            while (reader.Read())
            {
                MatEquip item = new MatEquip();
                item.IdItem = reader.GetInt32(0);
                item.Nome = reader.GetString(1);
                item.Tombamento = reader.GetString(2);
                item.Logger = reader.GetString(3);
                listaMatEquip.Add(item);
            }
            connection.Close();
            return listaMatEquip;
        }
    }
}
