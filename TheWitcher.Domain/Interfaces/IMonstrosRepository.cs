using System.Collections.Generic;
using TheWitcher.Domain.Models;

namespace TheWitcher.Domain.Interfaces
{
    public interface IMonstrosRepository
    {
        IEnumerable<Monstro> GetAll();
        Monstro Get(int id);
        Monstro Add(Monstro monstro);
        bool Update(Monstro monstro);
        void Remove(int id);
    }
}
