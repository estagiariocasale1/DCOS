using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    public class TurnosDAO:GenericDAO
    {   
        public void Insert(Turnos turno)
        {
            String sql = String.Format("INSERT INTO dcos.turnos (nome) VALUES ('{0}')", turno.Nome);         
            SQLinjector(sql);
        }
        public void Delete(Turnos turno)
        {
            String sql = String.Format("DELETE FROM dcos.turnos WHERE id_turno = {0}", turno.IDTurno);
            SQLinjector(sql);
        }
        public void Update(Turnos turno)
        {
            String sql = String.Format("UPDATE dcos.turnos SET nome = '{0}' WHERE id_turno = {1}", turno.Nome, turno.IDTurno);
            SQLinjector(sql);
        }
        public List<Turnos> select()
        {
            string sql = "SELECT* FROM dcos.turnos";
            NpgsqlConnection connection = new Conexao().GetConexao();            
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaTurnos = new List<Turnos>();
            while (reader.Read())
            {
                Turnos turno = new Turnos();
                turno.IDTurno = reader.GetInt32(0);                
                turno.Nome = reader.GetString(1);                
                listaTurnos.Add(turno);
            }            
            return listaTurnos;
        }               
        
    }
}
