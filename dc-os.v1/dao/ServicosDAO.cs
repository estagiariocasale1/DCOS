using System;
using System.Collections.Generic;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    internal class ServicosDAO:GenericDAO
    {
        public void Insert(Servicos servico)
        {
            String sql = String.Format("INSERT INTO dcos.Servicos (nome, descricao, itens) VALUES ('{0}')", servico.NomeServico, servico.Descricao, servico.Itens);
            SQLinjector(sql);
        }
        public void Delete(Servicos servico)
        {
            String sql = String.Format("DELETE FROM dcos.Servicos WHERE id_servico = {0}", servico.IdServico);
            SQLinjector(sql);
        }
        public void Update(Servicos servico)
        {
            String sql = String.Format("UPDATE dcos.Servicos SET nome = '{0}' WHERE id_servico = {1}", servico.NomeServico, servico.IdServico);
            SQLinjector(sql);
        }
        public List<Servicos> Select(string sql)
        {
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaServicos = new List<Servicos>();
            while (reader.Read())
            {
                Servicos servico = new Servicos();
                servico.IdServico = reader.GetInt32(0);
                servico.NomeServico = reader.GetString(1);
                servico.Descricao = reader.GetString(2);
                servico.Itens = reader.GetString(3);
                listaServicos.Add(servico);
            }
            connection.Close();
            return listaServicos;
        }
    }
}
