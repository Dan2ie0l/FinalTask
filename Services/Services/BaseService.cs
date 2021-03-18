using RazorApp.Repository;
using RazorApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorApp.Services.Services
{
    public class BaseService<T> : IBaseService<T>
        where T : Abstract
    {
       
            private readonly IBaseRepository<T> repository;

            public BaseService(IBaseRepository<T> repository)
            {
                this.repository = repository;
            }

            public IEnumerable<T> Actives()
            {
                return repository.Actives();
            }

            public IEnumerable<T> All()
            {
                return repository.All();
            }

            public IEnumerable<T> Deleted()
            {
                return repository.Deleted();
            }

            public T GetById(int id)
            {
                return repository.GetById(id);
            }

            public void Add(T model)
            {
                model.Active = true;
                model.ModifiedOn = DateTime.Now;
                model.CreatedOn = DateTime.Now;
                repository.Add(model);
            }

            public bool Delete(int id)
            {
                return repository.Delete(id);
            }

            public void Update(T model)
            {
                repository.Update(model);
            }
        }
    }
