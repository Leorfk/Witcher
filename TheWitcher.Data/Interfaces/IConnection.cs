using MySql.Data.MySqlClient;

namespace TheWitcher.Data.Interfaces
{
    public interface IConnection
    {
        MySqlConnection Abrir();
        MySqlConnection Buscar();
        void Fechar();
        void Dispose();

    }
}
