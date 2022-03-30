using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using dc_os.v1.model.entidades;


namespace dc_os.v1.dao
{
    internal class VeiculosDAO:GenericDAO
    {
        public void Insert(Veiculos veiculo)
        {
            String sql = String.Format("INSERT INTO dcos.Veiculos (nome) VALUES ('{0}', '{1}')", veiculo.Nome, veiculo.Placa);
            SQLinjector(sql);
        }
        public void Delete(Veiculos veiculo)
        {
            String sql = String.Format("DELETE FROM dcos.Veiculos WHERE id_veiculo = {0}", veiculo.IdVeiculo);
            SQLinjector(sql);
        }
        public void Update(Veiculos veiculo)
        {
            String sql = String.Format("UPDATE dcos.Veiculos SET nome = '{0}' WHERE id_veiculo = {1}", veiculo.Nome, veiculo.IdVeiculo);
            SQLinjector(sql);
        }
        public List<Veiculos> Select(string sql)
        {
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaVeiculos = new List<Veiculos>();
            while (reader.Read())
            {
                Veiculos veiculo = new Veiculos();
                veiculo.IdVeiculo = reader.GetInt32(0);
                veiculo.Nome = reader.GetString(1);
                veiculo.Placa = reader.GetString(2);
                listaVeiculos.Add(veiculo);
            }
            connection.Close();
            return listaVeiculos;
        }
    }
}
