using System;
using MySql.Data.MySqlClient;
using TheWitcher.Data.Interfaces;
using System.Data;

namespace TheWitcher.Data.Connections
{
    public class Connection : IConnection
    {
        private MySqlConnection _connection;
        private readonly string con = "server=localhost;user id=root;password=12345678;database=witcher;";

        public Connection()
        {
            _connection = new MySqlConnection(con);
        }
        public MySqlConnection Abrir()
        {
            try
            {

                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                return _connection;
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }

        public MySqlConnection Buscar()
        {
            return this.Abrir();
        }

        public void Fechar()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
        /// <summary>
        /// Usamos esse método para descarregar a memória referente a essa conexão
        /// </summary>
        public void Dispose()
        {
            this.Fechar();
            GC.SuppressFinalize(this);
        }
    }
}
