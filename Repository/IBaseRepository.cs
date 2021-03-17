using System;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> All();
        IQueryable<T> Actives();
        IQueryable<T> Deleted();
        T GetById(int id);
        void Add(T model);
        bool Delete(int id);
     
    }
}
