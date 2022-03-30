using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    internal class CargosDAO:GenericDAO
    {
        public void Insert(Cargos cargo)
        {
            String sql = String.Format("INSERT INTO dcos.Cargos (nome) VALUES ('{0}')", cargo.Nome);
            SQLinjector(sql);
        }
        public void Delete(Cargos cargo)
        {
            String sql = String.Format("DELETE FROM dcos.Cargos WHERE id_cargo = {0}", cargo.IdCargo);
            SQLinjector(sql);
        }
        public void Update(Cargos cargo)
        {
            String sql = String.Format("UPDATE dcos.Cargos SET nome = '{0}' WHERE id_cargo = {1}", cargo.Nome, cargo.IdCargo);
            SQLinjector(sql);
        }
        public List<Cargos> Select()
        {
            string sql = "SELECT* FROM dcos.Cargos";
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaCargos = new List<Cargos>();
            while (reader.Read())
            {
                Cargos cargo = new Cargos();
                cargo.IdCargo = reader.GetInt32(0);
                cargo.Nome = reader.GetString(1);
                listaCargos.Add(cargo);
            }
            connection.Close();
            return listaCargos;            
        }
    }
}
