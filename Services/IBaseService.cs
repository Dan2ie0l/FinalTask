using System;
using System.Collections.Generic;
using System.Text;

namespace RazorApp.Services

{
    public interface IBaseService<T>
    {
        IEnumerable<T> All();
        IEnumerable<T> Actives();
        IEnumerable<T> Deleted();
        T GetById(int id);
        void Add(T model);
        bool Delete(int id);
        void Update(T model);
    }
}
