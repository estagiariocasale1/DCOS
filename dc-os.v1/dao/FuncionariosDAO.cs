using System;
using System.Collections.Generic;
using Npgsql;
using dc_os.v1.model.entidades;

namespace dc_os.v1.dao
{
    internal class FuncionariosDAO : GenericDAO
    {
        public void Insert(Funcionarios funcionario)
        {
            String sql = String.Format("INSERT INTO dcos.Funcionarios (nome, sobrenome, matricula, telefone, id_turno, apto_a_dirigir, cargo) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", 
                funcionario.Nome, funcionario.Sobrenome, funcionario.Matricula, funcionario.Telefone, funcionario.IdTurno, funcionario.Apto, funcionario.Cargo);
            SQLinjector(sql);
        }
        public void Delete(Funcionarios funcionario)
        {
            String sql = String.Format("DELETE FROM dcos.Funcionarios WHERE id_func = {0}", funcionario.IdFunc);
            SQLinjector(sql);
        }
        public void Update(Funcionarios funcionario)
        {
            String sql = String.Format("UPDATE dcos.Funcionarios SET nome = '{0}' WHERE id_funcionario = {1}", funcionario.Nome, funcionario.IdFunc);
            SQLinjector(sql);
        }
        public List<Funcionarios> Select()
        {
            string sql = "SELECT* FROM dcos.Funcionarios";
            NpgsqlConnection connection = new Conexao().GetConexao();
            connection.Open();
            using var cmd = new NpgsqlCommand(sql, connection);
            using NpgsqlDataReader reader = cmd.ExecuteReader();

            var listaFuncionarios = new List<Funcionarios>();
            while (reader.Read())
            {
                Funcionarios funcionario = new Funcionarios();
                funcionario.IdFunc = reader.GetInt32(0);
                funcionario.Matricula = reader.GetInt32(1);
                funcionario.Nome = reader.GetString(2);
                funcionario.Sobrenome = reader.GetString(3);
                funcionario.Telefone = reader.GetString(4);
                funcionario.IdTurno = reader.GetInt32(5);
                funcionario.Cargo = reader.GetInt32(6);               
                listaFuncionarios.Add(funcionario);
            }
            connection.Close();
            return listaFuncionarios;
        }
    }
}
