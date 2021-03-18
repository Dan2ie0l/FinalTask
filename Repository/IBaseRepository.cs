using System;
using System.Linq;
using System.Threading.Tasks;

namespace RazorApp.Repository
{
    public interface IBaseRepository<T>
    {

        IQueryable<T> All();
        IQueryable<T> Actives();
        IQueryable<T> Deleted();
        T GetById(int id);
        void Add(T model);
        bool Delete(int id);
        void Update(T model);

    }
}

