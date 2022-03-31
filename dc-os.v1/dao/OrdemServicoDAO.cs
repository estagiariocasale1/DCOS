using System;
using System.Collections.Generic;
using dc_os.v1.model.entidades;
using Npgsql;

namespace dc_os.v1.dao
{
    internal class OrdemServicoDAO:GenericDAO
    {
        public void Insert(OrdemServico os)
        {
            String sql = String.Format("string sql");
            SQLinjector(sql);
        }
        public void Delete(OrdemServico os)
        {
            String sql = String.Format("string sql");
            SQLinjector(sql);
        }
        public void Update(OrdemServico os)
        {
            String sql = String.Format("string sql");
            SQLinjector(sql);
        }

        public List<OrdemServico> Select(string sql)
        {
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaBoletins = new List<OrdemServico>();
            while (reader.Read())
            {
                OrdemServico os = new OrdemServico();
                os.IdOs = reader.GetInt32(0);
                os.HoraCriada = reader.GetTimeSpan(1);
                os.HoraIniciada = reader.GetTimeSpan(2);
                os.HoraFinalizada = reader.GetTimeSpan(3);
                os.DataCriada = Convert.ToDateTime(reader.GetValue(4).ToString());
                os.DataIniciada = Convert.ToDateTime(reader.GetValue(5).ToString());
                os.DataFinalizada = Convert.ToDateTime(reader.GetValue(6).ToString());
                os.NOs = reader.GetString(7);
                os.Status = reader.GetString(8);
                os.IdSetor = reader.GetInt32(9);
                os.IdServico = reader.GetInt32(10);
                os.IdLocal = reader.GetInt32(11);
                os.IdViagem = reader.GetInt32(12);
                os.IdTurno = reader.GetInt32(13);
                os.IdBloco = reader.GetInt32(14);
                os.IdMacrosservico = reader.GetInt32(15);
                os.IdRotina = reader.GetInt32(16);
                os.Escala = reader.GetInt32(17);
            }
            connection.Close();
            return listaBoletins;
        }

    }
}
