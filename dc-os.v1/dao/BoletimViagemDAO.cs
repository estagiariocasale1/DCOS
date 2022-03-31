using System;
using Npgsql;
using dc_os.v1.model.entidades;
using System.Collections.Generic;


namespace dc_os.v1.dao
{
    internal class BoletimViagemDAO:GenericDAO
    {
        public void Insert(BoletimViagem boletim)
        {
            String sql = String.Format("string sql");
            SQLinjector(sql);
        }
        public void Delete(BoletimViagem boletim)
        {
            String sql = String.Format("string sql");
            SQLinjector(sql);
        }
        public void Update(BoletimViagem boletim)
        {
            String sql = String.Format("string sql");
            SQLinjector(sql);
        }
        
        public List<BoletimViagem> Select(string sql)
        {            
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();
          
            var listaBoletins = new List<BoletimViagem>();
            while (reader.Read())
            {
                BoletimViagem boletim = new BoletimViagem();
                boletim.IdViagem = reader.GetInt32(0);
                boletim.KmSaida = reader.GetFloat(1);
                boletim.KmChegada = reader.GetFloat(2);
                boletim.HoraSaida = reader.GetTimeSpan(3);
                boletim.HoraChegada = reader.GetTimeSpan(4);                            
                boletim.DataSaida = Convert.ToDateTime(reader.GetValue(5).ToString());
                boletim.DataChegada = Convert.ToDateTime(reader.GetValue(6).ToString());
                boletim.IdVeiculo = reader.GetInt32(6);
                boletim.Origem = reader.GetInt32(7);
                boletim.Destino = reader.GetInt32(8);
                boletim.Motorista = reader.GetInt32(9);                
                listaBoletins.Add(boletim);
            }
            connection.Close();
            return listaBoletins;            
        }
    }

}
