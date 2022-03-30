using System;
using System.Collections.Generic;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    internal class PareceresDAO:GenericDAO
    {
        public void Insert(Pareceres parecer)
        {
            String sql = String.Format("INSERT INTO dcos.Pareceres (observacao, atendimento, id_os) VALUES ('{0}', '{0}', '{0}')", parecer.Observacao, parecer.Atendimento, parecer.IdOs);
            SQLinjector(sql);
        }
        public void Delete(Pareceres parecer)
        {
            String sql = String.Format("DELETE FROM dcos.Pareceres WHERE id_parecer = {0}", parecer.IdParecer);
            SQLinjector(sql);
        }
        public void Update(Pareceres parecer)
        {
            String sql = String.Format("UPDATE dcos.Pareceres SET nome = '{0}' WHERE id_parecer = {1}", parecer.Observacao, parecer.IdParecer);
            SQLinjector(sql);
        }
        public List<Pareceres> Select(string sql)
        {
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaPareceres = new List<Pareceres>();
            while (reader.Read())
            {
                Pareceres parecer = new Pareceres();
                parecer.IdParecer = reader.GetInt32(0);
                parecer.Observacao = reader.GetString(1);      
                parecer.Atendimento = reader.GetBoolean(2);
                parecer.IdOs = reader.GetInt32(3);
                listaPareceres.Add(parecer);
            }
            connection.Close();
            return listaPareceres;
        }
    }
}
