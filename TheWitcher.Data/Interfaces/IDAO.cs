using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWitcher.Data.Interfaces
{
    public interface IDAO<T>: IDisposable
        where T: class, new()
    {
        T Insert(T model);
        void Update(T model);
        bool Delete(int id);
        T GetById(int id);
        List<T> GetAll();
    }
}
