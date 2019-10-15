using MySql.Data.MySqlClient;
using System;
using TheWitcher.Data.Interfaces;
using TheWitcher.Domain.Models;
using System.Data;
using TheWitcher.Domain.Enums;
using System.Collections.Generic;
using TheWitcher.Data.Connections;

namespace TheWitcher.Data.DAO
{
    public class MonstrosDAO : IDAO<Monstro>, IDisposable
    {
        private IConnection _connection;
        public MonstrosDAO()
        {
            this._connection = new Connection();
        }

        public MonstrosDAO(IConnection connection)
        {
            this._connection = connection;
        }

        public bool Delete(int idMonstro)
        {
            try
            {
                using (MySqlCommand command = _connection.Buscar().CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@idmonstro", MySqlDbType.Int32).Value = idMonstro;
                    command.CommandText = $"delete from monstros where idmonstro=@idmonstro;";
                    command.ExecuteNonQuery();
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception erro)
            {

                throw new Exception(erro.Message);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<Monstro> GetAll()

        {
            List<Monstro> monstros = new List<Monstro>();
            try
            {
                using (MySqlCommand command = _connection.Buscar().CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from monstros";
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Monstro monstro = new Monstro
                        {
                            Id = (int)reader["idmonstro"],
                            Nome = reader["nome"].ToString(),
                            Idade = (int)reader["idade"],
                            Sexo = (EnumSexo)reader["sexo"],
                            Hp = (int)reader["hp"],
                            Atk = (int)reader["atk"],
                            DataEncontro = (DateTime)reader["dataencontro"],
                            Raca = (EnumRacasMonstros)reader["raca"],
                            Recompensa = Convert.ToDecimal(reader["recompensa"])
                        };
                        monstros.Add(monstro);
                    }
                }
                return monstros;
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }

        public Monstro GetById(int id)
        {
            Monstro monstro = null;
            try
            {
                using (MySqlCommand command = _connection.Buscar().CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from monstros where idmonstro=@id";
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            monstro = new Monstro();
                            reader.Read();
                            monstro.Id = reader.GetInt32(0);
                            monstro.Nome = reader.GetString(1);
                            monstro.Idade = reader.GetInt32(2);
                            monstro.Sexo = (EnumSexo)reader.GetInt32(3);
                            monstro.Hp = reader.GetInt32(4);
                            monstro.Atk = reader.GetInt32(5);
                            monstro.DataEncontro = reader.GetDateTime(6);
                            monstro.Raca = (EnumRacasMonstros)reader.GetInt32(7);
                            monstro.Recompensa = reader.GetDecimal(8);
                        }
                    }
                }
                return monstro;
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }

        public Monstro Insert(Monstro model)
        {
            try
            {
                using (MySqlCommand command = _connection.Buscar().CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into monstros (idmonstro, nome, idade, sexo, hp, atk, dataencontro, raca, recompensa)" +
                        "values (null, @nome, @idade, @sexo, @hp, @atk, @dataencontro, @raca, @recompensa)";

                    command.Parameters.Add("@nome", MySqlDbType.Text).Value = model.Nome;
                    command.Parameters.Add("@idade", MySqlDbType.Int32).Value = model.Idade;
                    command.Parameters.Add("@sexo", MySqlDbType.Int32).Value = model.Sexo;
                    command.Parameters.Add("@hp", MySqlDbType.Int32).Value = model.Hp;
                    command.Parameters.Add("@atk", MySqlDbType.Int32).Value = model.Atk;
                    command.Parameters.Add("@dataencontro", MySqlDbType.DateTime).Value = model.DataEncontro;
                    command.Parameters.Add("@raca", MySqlDbType.Int32).Value = model.Raca;
                    command.Parameters.Add("@recompensa", MySqlDbType.Decimal).Value = model.Recompensa;
                    command.ExecuteNonQuery();
                }
                return model;
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }

        public void Update(Monstro model)
        {
            try
            {
                using (MySqlCommand command = _connection.Buscar().CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText =
                        "update monstros set " +
                        "nome=@nome, idade=@idade, sexo=@sexo, hp=@hp, atk=@atk, dataencontro=@dataencontro, raca=@raca, recompensa=@recompensa " +
                        "where idmonstro=@idmonstro";

                    command.Parameters.Add("@nome", MySqlDbType.Text).Value = model.Nome;
                    command.Parameters.Add("@idade", MySqlDbType.Int32).Value = model.Idade;
                    command.Parameters.Add("@sexo", MySqlDbType.Int32).Value = model.Sexo;
                    command.Parameters.Add("@hp", MySqlDbType.Int32).Value = model.Hp;
                    command.Parameters.Add("@atk", MySqlDbType.Int32).Value = model.Atk;
                    command.Parameters.Add("@dataencontro", MySqlDbType.DateTime).Value = model.DataEncontro;
                    command.Parameters.Add("@raca", MySqlDbType.Int32).Value = model.Raca;
                    command.Parameters.Add("@recompensa", MySqlDbType.Decimal).Value = model.Recompensa;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }
    }
}
