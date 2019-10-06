using System.Collections.Generic;
using TheWitcher.Domain.Models;

namespace TheWitcher.Domain.Interfaces
{
    public interface IMonstrosService
    {
        Monstro Buscar(int id);
        IEnumerable<Monstro> ListarTodos();
        IEnumerable<Monstro> BuscarPorRaca(int raca);
        IEnumerable<Monstro> BuscarPorRecompensa(double recompensa);
        Monstro Registrar(Monstro monstro);
        bool Deletar(int id);
        void Atualizar(Monstro monstro);
    }
}
